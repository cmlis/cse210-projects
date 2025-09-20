
public class Scripture
{

    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {

        _reference = reference;

        //Converting the text to a List of  Word objects
        _words = text.Split(" ").Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomNum = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = randomNum.Next(_words.Count);

            // Only hide if the word is not already hidden
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
            else
            {
                // If the word was already hidden, try another word
                i--; // decrement i to hide the intended number of words
            }
        }

    }

    public string GetDisplayText()
    {
        {
            if (_words == null) throw new Exception("_words is null");
            if (_reference == null) throw new Exception("_reference is null");

            return _reference.GetDisplayText() + " - " +
                   string.Join(" ", _words.Select(w => w.GetDisplayText()));
        }
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false; // found a visible word
            }
        }
        return true;
    }
    
    public void HideAllWords()
{
    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            word.Hide();
        }
    }
}

}