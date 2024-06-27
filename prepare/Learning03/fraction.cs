public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int top)
    {
        _topNum = top;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {

        _topNum = top;
        _bottomNum = bottom;
    }

    public int GetTopNum()
    {
        return _topNum;
    }

    public int GetBottomNum()
    {
        return _bottomNum;
    }

    public void SetTopNum(int top)
    {
        _topNum = top;
    }

    public void SetBottomNum(int bottom)
    {
        _bottomNum = bottom;
    }

    public String GetFractionString()
    {
        string line = $"{_topNum}/{_bottomNum}";
        return line;
    }

    public double GetDecimalValue()
    {
        return (double)_topNum / (double)_bottomNum;
    }
}