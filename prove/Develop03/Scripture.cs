public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ParseTextIntoWords(text);
    }

    private List<Word> ParseTextIntoWords(string text)
    {
        var words = new List<Word>();
        string[] splitText = text.Split(' ');
        foreach (string wordText in splitText)
        {
            words.Add(new Word(wordText));
        }
        return words;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        while (numberToHide > 0 && visibleWords.Count > 0)
            {
                int index = rand.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
                numberToHide--;
                visibleWords = _words.Where(w => !w.IsHidden()).ToList();
            }
    }

    public string GetDisplayText()
    {
        List<string> displayText = new List<string>();
        foreach (Word word in _words)
        {
            displayText.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", displayText)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
    
