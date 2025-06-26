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
    public class InstanceTools
    {
        public static string GetCurrentLocation()
        {
            // Call the location API here.
            return "San Francisco";
        }

        public static string GetCurrentWeather(string location, string unit = "celsius")
        {
            // Call the weather API here.
            return $"31 {unit}";
        }
    }

    [Test]
    public async Task Example04_BasicFunctionTool()
    {
        OpenAIResponseClient client = new(model: "gpt-4o-mini", apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"));

        List<ResponseItem> messages = [ResponseItem.CreateUserMessageItem("What's the weather in boston today?"),];

        ResponseTools tools = new ResponseTools();

        tools.AddFunctionTools([typeof(InstanceTools),]);

        OpenAIResponse response;
        ResponseCreationOptions options = new ResponseCreationOptions();

        foreach (var item in tools.Tools)
        {
            options.Tools.Add(item);
        }

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

                    FunctionCallOutputResponseItem functionOutputResponse = await tools.CallAsync(toolCall);
                    messages.Add(functionOutputResponse);

                    requiresAction = true;
                }
            }
        } while (requiresAction);

        
    }

    
}

