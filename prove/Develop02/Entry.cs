public class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;


    public void Display() 
    {
        // FIX ME
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}