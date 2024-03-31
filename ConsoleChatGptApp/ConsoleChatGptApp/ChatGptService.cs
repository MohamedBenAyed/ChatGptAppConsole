namespace ConsoleChatGptApp
{
    public class ChatGptService
    {
        public string GetResultChatGpt(string question)
        {
            //Please use your OpenAIAPI. This one is deleted
            string result  = string.Empty;

            var openAIAPI = new OpenAI_API.OpenAIAPI("openapikey");

            var completions = openAIAPI.Completions.CreateCompletionAsync(
               prompt: question,
               model: "gpt-3.5-turbo-instruct",
               max_tokens: 100,
               temperature: 0.5f
               );

            var completionsResult = completions.Result.Completions;

            if (completionsResult is not null && completionsResult.Count > 0)
            {
                return result = completionsResult[0].Text;
            }

            return result;
        }
    }
}
