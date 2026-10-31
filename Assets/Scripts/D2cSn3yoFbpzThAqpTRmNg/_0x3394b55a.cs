/// <summary>
/// A whole generated route: its sign-word name and its ordered stops. The name is drawn
/// from a word table and never carries the application name (hard rule 1).
/// </summary>
public sealed class _0x3394b55a
{
    public _0xf7978a15[] Stops = new _0xf7978a15[0];
    public int _0xe7956500
    {
        get
        {
            return this.Stops.Length;
        }
    }

    public int Seed;
    public int _0xa6224b61(int _0x1012abb6)
    {
        int _0x20836edf = 0;
        for (int _0x54f2e041 = 0; _0x54f2e041 < this.Stops.Length; _0x54f2e041++)
        {
            if (this.Stops[_0x54f2e041].Kind == _0x1012abb6)
            {
                _0x20836edf++;
            }
        }

        return _0x20836edf;
    }

    public _0x3394b55a _0x9eef7ced(string _0xf4789bc3, _0xf7978a15[] _0xe2439e47, int _0x0dfaa99c, bool _0x318585d2)
    {
        this.SignName = _0xf4789bc3;
        this.Stops = _0xe2439e47;
        this.Seed = _0x0dfaa99c;
        this.IsFallback = _0x318585d2;
        return this;
    }

    public bool IsFallback;
    public string SignName = "";
}