using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// The chrome every lobby sheet shares: a scrim so the sheet reads as a layer over the
/// lobby rather than another lobby, a road-sign header and one close control. Built in one
/// place so the close cross sits at the SAME fraction on every sheet - the review scenario
/// taps it by coordinate and a sheet that does not close turns the rest of the album into
/// five photographs of the same screen.
/// </summary>
public static class _0xab5b90a8
{
    public const float CloseY = 0.905f;
    public const float CloseX = 0.885f;
    /// <summary>
    /// A themed line for a list that has nothing in it yet. No screen in this game is ever
    /// allowed to be an empty area with no explanation.
    /// </summary>
    public static void Empty(RectTransform _0x92b7fb37, TMP_FontAsset _0x1cb20069, string _0xfec340b2)
    {
        _0xaefb2489.Label(_0x92b7fb37, _0xb4dae8c1._0x4bbe4369(new byte[10] { 12, 36, 57, 61, 48, 26, 61, 40, 61, 44 }, 73), _0xfec340b2, 0.5f, 0.5f, 1000f, 200f, 34f, _0x662d66c6.TextMuted, _0x1cb20069, TextAlignmentOptions.Center);
    }

    /// <summary>Draws the chrome into `host` and returns the rect the caller fills.</summary>
    public static RectTransform Open(RectTransform _0x4ac18f09, _0x9a4ef192 _0x22393ece, TMP_FontAsset _0xabb8d72a, string _0xff89e2c0, UnityAction _0x6a26c2da)
    {
        _0xaefb2489.Scrim(_0x4ac18f09, _0xb4dae8c1._0x4bbe4369(new byte[10] { 9, 50, 63, 63, 46, 9, 57, 40, 51, 55 }, 90), _0x22393ece.Solid, _0x662d66c6.Fade(_0x662d66c6.Asphalt, 0.88f));
        Image _0x75135307 = _0xaefb2489.Plate(_0x4ac18f09, _0xb4dae8c1._0x4bbe4369(new byte[11] { 34, 25, 20, 20, 5, 57, 20, 16, 21, 20, 3 }, 113), 0.5f, CloseY, 1060f, 120f, _0x22393ece.Plate, _0x662d66c6.Cobalt, 2.8f);
        _0xaefb2489.Label(_0x75135307.rectTransform, _0xb4dae8c1._0x4bbe4369(new byte[10] { 185, 130, 143, 143, 158, 190, 131, 158, 134, 143 }, 234), _0xff89e2c0, 0.5f, 0.5f, 820f, 78f, 46f, _0x662d66c6.Cream, _0xabb8d72a, TextAlignmentOptions.Center);
        _0xaefb2489.IconCta(_0x4ac18f09, _0xb4dae8c1._0x4bbe4369(new byte[10] { 200, 243, 254, 254, 239, 216, 247, 244, 232, 254 }, 155), CloseX, CloseY, 104f, _0x22393ece.ButtonRound, _0x22393ece.IconBack, Color.white, _0x662d66c6.Cream, _0x6a26c2da);
        return _0xaefb2489.Node(_0x4ac18f09, _0xb4dae8c1._0x4bbe4369(new byte[9] { 109, 86, 91, 91, 74, 124, 81, 90, 71 }, 62), 0.5f, 0.44f, 1100f, 1800f);
    }
}

internal static class _0xb4dae8c1
{
    internal static string _0x4bbe4369(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}