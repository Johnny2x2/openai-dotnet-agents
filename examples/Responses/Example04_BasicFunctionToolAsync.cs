using NUnit.Framework;
using OpenAI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenAI.Examples;

public partial class ResponseExamples
{
    [Test]
    public async Task Example04_BasicFunctionTool()
    {
        OpenAIResponseClient client = new(model: "gpt-4o-mini", apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"));

        List<ResponseItem> messages = [ResponseItem.CreateUserMessageItem("What's the weather in boston today?"),];

        ResponseTool getCurrentWeatherTool = ResponseTool.CreateFunctionTool(
                functionName: nameof(GetCurrentWeather),
                functionDescription: "Get the current weather in a given location",
                functionParameters: BinaryData.FromBytes("""
                    {
                        "type": "object",
                        "properties": {
                            "location": {
                                "type": "string",
                                "description": "The city and state, e.g. Boston, MA"
                            },
                            "unit": {
                                "type": "string",
                                "enum": [ "celsius", "fahrenheit" ],
                                "description": "The temperature unit to use. Infer this from the specified location."
                            }
                        },
                        "required": [ "location" ]
                    }
                    """u8.ToArray())
            );
        ResponseTool getCurrentLocationTool = ResponseTool.CreateFunctionTool(
                        functionName: nameof(GetCurrentLocation),
                        functionDescription: "Get the user's current location", functionParameters: BinaryData.FromBytes("""
                    {
                        "type": "object",
                        "properties": {}
                    }
                    """u8.ToArray())
                    );

        OpenAIResponse response;
        ResponseCreationOptions options = new ResponseCreationOptions();

        options.Tools.Add(getCurrentWeatherTool);
        options.Tools.Add(getCurrentLocationTool);

        bool requiresAction = false;

        do
        {
            requiresAction = false;

            response = await client.CreateResponseAsync(messages, options);

            foreach (ResponseItem item in response.OutputItems)
            {
                if (item is WebSearchCallResponseItem webSearchCall)
                {
                    messages.Add(webSearchCall);
                    Console.WriteLine($"[Web search invoked]({webSearchCall.Status}) {webSearchCall.Id}");
                }
                else if (item is MessageResponseItem message)
                {
                    messages.Add(message);
                    Console.WriteLine($"[{message.Role}] {message.Content?.FirstOrDefault()?.Text}");
                }
                else if (item is FunctionCallResponseItem toolCall)
                {
                    messages.Add(toolCall);
                    
                    switch (toolCall.FunctionName)
                    {
                        case nameof(GetCurrentLocation):
                            {
                                string toolResult = GetCurrentLocation();
                                messages.Add(ResponseItem.CreateFunctionCallOutputItem(toolCall.CallId, toolResult));
                                break;
                            }

                        case nameof(GetCurrentWeather):
                            {
                                // The arguments that the model wants to use to call the function are specified as a
                                // stringified JSON object based on the schema defined in the tool definition. Note that
                                // the model may hallucinate arguments too. Consequently, it is important to do the
                                // appropriate parsing and validation before calling the function.
                                using JsonDocument argumentsJson = JsonDocument.Parse(toolCall.FunctionArguments);
                                bool hasLocation = argumentsJson.RootElement.TryGetProperty("location", out JsonElement location);
                                bool hasUnit = argumentsJson.RootElement.TryGetProperty("unit", out JsonElement unit);

                                if (!hasLocation)
                                {
                                    throw new ArgumentNullException(nameof(location), "The location argument is required.");
                                }

                                string toolResult = hasUnit
                                    ? GetCurrentWeather(location.GetString(), unit.GetString())
                                    : GetCurrentWeather(location.GetString());
                                messages.Add(ResponseItem.CreateFunctionCallOutputItem(toolCall.CallId, toolResult)); ;
                                break;
                            }

                        default:
                            {
                                // Handle other unexpected calls.
                                throw new NotImplementedException();
                            }
                    }

                    requiresAction = true;
                }
            }
        } while (requiresAction);

        
    }

    private static string GetCurrentLocation()
    {
        // Call the location API here.
        return "San Francisco";
    }

    private static string GetCurrentWeather(string location, string unit = "celsius")
    {
        // Call the weather API here.
        return $"31 {unit}";
    }
}

