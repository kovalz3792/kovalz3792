/// <summary>
/// One stop of a route. Built by the generator, read by the game scene.
/// No constructor (rule C.59) - the fields are filled by Init, which returns the object.
/// </summary>
public sealed class _0xf7978a15
{
    public const int KindDetour = 3;
    public int GiftCredits; // only meaningful on a gift stop
    public const int KindBadge = 1;
    public string _0x22fe4f9f()
    {
        if (this.Kind == KindBadge)
        {
            return _0x5b8e9e58._0x53e56ed4(new byte[10] { 158, 157, 152, 155, 153, 252, 152, 142, 147, 140 }, 220);
        }

        if (this.Kind == KindGift)
        {
            return _0x5b8e9e58._0x53e56ed4(new byte[9] { 244, 233, 231, 226, 134, 225, 239, 224, 242 }, 166);
        }

        if (this.Kind == KindDetour)
        {
            return _0x5b8e9e58._0x53e56ed4(new byte[6] { 35, 34, 51, 40, 50, 53 }, 103);
        }

        return _0x5b8e9e58._0x53e56ed4(new byte[6] { 145, 128, 152, 142, 148, 149 }, 193);
    }

    public _0xf7978a15 _0x10678694(int _0x04d8e9e5, int _0x19f1b1a8, int _0xef1ea1bb, int _0x72b0ddb9)
    {
        this.Kind = _0x04d8e9e5;
        this.WeightTable = _0x19f1b1a8;
        this.BadgeIndex = _0xef1ea1bb;
        this.GiftCredits = _0x72b0ddb9;
        return this;
    }

    public int Kind;
    public const int KindPayout = 0;
    public int WeightTable; // 0 LEAN, 1 EVEN, 2 RICH
    public const int KindGift = 2;
    public int BadgeIndex; // only meaningful on a badge stop
}

internal static class _0x5b8e9e58
{
    internal static string _0x53e56ed4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}