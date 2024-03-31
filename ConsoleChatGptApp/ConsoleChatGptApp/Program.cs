// See https://aka.ms/new-console-template for more information

using ConsoleChatGptApp;

ChatGptService chatGptService = new ChatGptService();

while(true)
{
    Console.Write("- ");
    var question = Console.ReadLine();

    var result = chatGptService.GetResultChatGpt(question);

    Console.WriteLine(result);
    Console.WriteLine("\n");
}