#pragma warning disable OPENAI001

using OpenAI.Responses;

var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
if (string.IsNullOrWhiteSpace(apiKey))
{
    Console.WriteLine("OPENAI_API_KEY 환경 변수가 필요합니다.");
    return;
}

var model = "gpt-5";
var systemPrompt = "Limit your answer to one sentence.";

ResponsesClient client = new(model: model, apiKey: apiKey);

while (true)
{
    Console.Write("Prompt (exit 입력 시 종료): ");
    var userPrompt = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userPrompt))
        continue;

    if (userPrompt.Equals("exit", StringComparison.OrdinalIgnoreCase))
        break;

    var options = new CreateResponseOptions
    {
        Instructions = systemPrompt
    };

    options.InputItems.Add(ResponseItem.CreateUserMessageItem(userPrompt));

    var result = await client.CreateResponseAsync(options);

    Console.WriteLine();
    Console.WriteLine("Response:");
    Console.WriteLine(result.Value.GetOutputText());
    Console.WriteLine();
}

#pragma warning restore OPENAI001
