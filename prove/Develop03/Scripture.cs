public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string fullText)
    {
        _reference = reference;

        // Split fullText into an array of strings and store in Word objects
        string[] arrayText = fullText.Split(" ");
        foreach(string text in arrayText)
        {
            Word word = new Word(text);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {
        // Display reference info
        string text = _reference.GetDisplayText();
        
        // Interate list of words and display each word
        foreach(Word word in _words)
        {
            text += $" {word.GetDisplayText()}";
        }

        return text;
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}