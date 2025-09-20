public class Word
{

    private string _string;
    private bool _isHidden;


    public Word(string text)
    {
        _string = text;
        _isHidden = false;

    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }


    public bool IsHidden()
    {

        return _isHidden;
    }
    

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _string.Length);
        }
        else
        {
            return _string;
        }

    }


}