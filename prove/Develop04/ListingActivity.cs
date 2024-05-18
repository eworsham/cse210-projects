public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = [];

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    public void Run()
    {
        // Show starting message
        DisplayStartingMessage();



        // Show ending message
        DisplayEndingMessage();
    }

    public string GetRandonPrompt()
    {
        return "";
    }

    public List<string> GetListFromUser()
    {
        return [];
    }   
}