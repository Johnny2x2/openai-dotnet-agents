using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
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
    public void Example05_StructuredOutput()
    {
        OpenAIResponseClient client = new(model: "gpt-4o-mini", apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"));

        List<ResponseItem> messages = [ResponseItem.CreateUserMessageItem("How can I solve 8x + 7 = -23 ? "),];

        OpenAIResponse response;
        ResponseCreationOptions options = new ResponseCreationOptions();

        ResponseTextFormat ResponseFormat = ResponseTextFormat.CreateJsonSchemaFormat(
                jsonSchemaFormatName: "math_reasoning",
                jsonSchema: BinaryData.FromBytes("""
            {
                "type": "object",
                "properties": {
                    "steps": {
                        "type": "array",
                        "items": {
                            "type": "object",
                            "properties": {
                                "explanation": { "type": "string" },
                                "output": { "type": "string" }
                            },
                            "required": ["explanation", "output"],
                            "additionalProperties": false
                        }
                    },
                    "final_answer": { "type": "string" }
                },
                "required": ["steps", "final_answer"],
                "additionalProperties": false
            }
            """u8.ToArray()),
                jsonSchemaIsStrict: true);

        ResponseTextOptions textOptions = new ResponseTextOptions();
        textOptions.TextFormat = ResponseFormat;

        options.TextOptions = textOptions;

        response = client.CreateResponse(messages, options);

        foreach (ResponseItem item in response.OutputItems)
        {
            if (item is MessageResponseItem message)
            {
                messages.Add(message);
                Console.WriteLine($"[{message.Role}] {message.Content?.FirstOrDefault()?.Text}");

                using JsonDocument structuredJson = JsonDocument.Parse(message.Content?.FirstOrDefault()?.Text);

                Console.WriteLine($"Final answer: {structuredJson.RootElement.GetProperty("final_answer")}");
                Console.WriteLine("Reasoning steps:");

                foreach (JsonElement stepElement in structuredJson.RootElement.GetProperty("steps").EnumerateArray())
                {
                    Console.WriteLine($"  - Explanation: {stepElement.GetProperty("explanation")}");
                    Console.WriteLine($"    Output: {stepElement.GetProperty("output")}");
                }
            }
        }
            
    }
}
