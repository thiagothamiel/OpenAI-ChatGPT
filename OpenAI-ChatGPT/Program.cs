using OpenAI;

OpenAIAPI api = new OpenAIAPI("YOUR-TOKEN",Engine.Davinci);

var results = 
    api.Completions.CreateCompletionsAsync(new CompletionRequest("Quando o Brasil foi descoberto?",
        temperature: 0.1, max_tokens: 2000), 1).Result;

Console.WriteLine(results.Completions[0].Text);
Console.ReadKey();