/// <summary>
/// What one spin paid. Winning cells are flagged so the board can pulse exactly the cells
/// that earned, and the trail can fly from them. No constructor (rule C.59).
/// </summary>
public sealed class _0x45fae2d6
{
    public int TopSymbol = -1;
    public bool[] Winning = new bool[9];
    public _0x45fae2d6 _0x92ef9e5c(int _0x623f0c78, int _0xa7ae9ba4, int _0x0c50272c, bool[] _0x363017ec)
    {
        this.Credits = _0x623f0c78;
        this.LinesHit = _0xa7ae9ba4;
        this.TopSymbol = _0x0c50272c;
        this.Winning = _0x363017ec;
        return this;
    }

    public int LinesHit;
    public int Credits;
}