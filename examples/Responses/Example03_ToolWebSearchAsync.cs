using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI.Responses;

namespace OpenAI.Examples;

public partial class ResponseExamples
{
    [Test]
    public async Task Example03_ToolWebSearchAsync()
    {
        OpenAIResponseClient client = new(model: "gpt-4o-mini", apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"));

        OpenAIResponse response = await client.CreateResponseAsync(
            userInputText: "What's a happy news headline from today?",
            new ResponseCreationOptions()
            {
                Tools = { ResponseTool.CreateWebSearchTool() },
            });

        foreach (ResponseItem item in response.OutputItems)
        {
            if (item is WebSearchCallResponseItem webSearchCall)
            {
                Console.WriteLine($"[Web search invoked]({webSearchCall.Status}) {webSearchCall.Id}");
            }
            else if (item is MessageResponseItem message)
            {
                Console.WriteLine($"[{message.Role}] {message.Content?.FirstOrDefault()?.Text}");
            }
        }
    }
}
