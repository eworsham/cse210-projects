public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt() 
    {
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(_prompts.Count);
        return _prompts[promptIndex];
    }
}