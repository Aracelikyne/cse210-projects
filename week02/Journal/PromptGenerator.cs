public class PromptGenerator
{
    private Random rand = new Random();
    private List<string> _prompts = new List<string>
    {
        "What was my favorite memory today", "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What goals do I want to set for myself tomorrow?", "What did I accomplish today?", "What was the most exciting thing that happened to me today?"
    };

    public string GetRandomPrompt()
    {
        int randomIndex = rand.Next(0, _prompts.Count);

        return _prompts[randomIndex];
    }


}