using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The 18+ notice. Shown before the lobby on EVERY cold start and dismissed by one tap, so
/// the statement is always made and always in the review album. The same wording is one tap
/// away for ever afterwards, under RULES.
///
/// Every glyph here is ASCII: a chevron or an arrow character falls back to a colon or to
/// tofu on Android, and this is the first screen anyone sees.
/// </summary>
public sealed class _0x2fd63b4b : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    public static readonly string Statement = _0x03920495._0x4df4405a(new byte[117] { 101, 122, 97, 103, 102, 114, 127, 19, 112, 97, 118, 119, 122, 103, 96, 19, 123, 114, 101, 118, 19, 125, 124, 19, 97, 118, 114, 127, 19, 101, 114, 127, 102, 118, 29, 57, 103, 123, 118, 106, 19, 112, 114, 125, 125, 124, 103, 19, 113, 118, 19, 113, 124, 102, 116, 123, 103, 31, 19, 100, 122, 103, 123, 119, 97, 114, 100, 125, 57, 124, 97, 19, 118, 107, 112, 123, 114, 125, 116, 118, 119, 29, 57, 125, 124, 19, 97, 118, 114, 127, 30, 126, 124, 125, 118, 106, 19, 116, 114, 126, 113, 127, 122, 125, 116, 29, 19, 125, 124, 19, 99, 97, 122, 105, 118, 96, 29 }, 51);
    public void _0x9806123f(_0xda5171dd _0x722b251d)
    {
        _0x9a4ef192 _0x0a477277 = _0x722b251d._0xd24f5652;
        TMP_FontAsset _0x986cff22 = _0x722b251d._0x88e5de05;
        RectTransform _0x1acfbec5 = this.GetComponent<RectTransform>();
        _0xaefb2489.Scrim(_0x1acfbec5, _0x03920495._0x4df4405a(new byte[11] { 163, 130, 153, 132, 142, 136, 190, 142, 159, 132, 128 }, 237), _0x0a477277.Solid, _0x662d66c6.Fade(_0x662d66c6.Asphalt, 0.74f));
        Image _0x32001b26 = _0xaefb2489.Plate(_0x1acfbec5, _0x03920495._0x4df4405a(new byte[10] { 201, 232, 243, 238, 228, 226, 212, 238, 224, 233 }, 135), 0.5f, 0.66f, 540f, 540f, _0x0a477277.Plate, _0x662d66c6.Cobalt, 2.8f);
        _0xaefb2489.Plate(_0x32001b26.rectTransform, _0x03920495._0x4df4405a(new byte[13] { 161, 128, 155, 134, 140, 138, 188, 134, 136, 129, 189, 134, 130 }, 239), 0.5f, 0.5f, 492f, 492f, _0x0a477277.Plate, _0x662d66c6.Fade(_0x662d66c6.Cream, 0.22f), 3.2f);
        _0xaefb2489.Label(_0x32001b26.rectTransform, _0x03920495._0x4df4405a(new byte[9] { 38, 7, 28, 1, 11, 13, 41, 15, 13 }, 104), _0x03920495._0x4df4405a(new byte[3] { 12, 5, 22 }, 61), 0.5f, 0.5f, 440f, 300f, 184f, _0x662d66c6.Cream, _0x986cff22, TextAlignmentOptions.Center);
        _0xaefb2489.Label(_0x1acfbec5, _0x03920495._0x4df4405a(new byte[13] { 143, 174, 181, 168, 162, 164, 137, 164, 160, 165, 168, 175, 166 }, 193), _0x03920495._0x4df4405a(new byte[18] { 174, 165, 191, 174, 185, 191, 170, 162, 165, 166, 174, 165, 191, 203, 164, 165, 167, 178 }, 235), 0.5f, 0.49f, 1040f, 70f, 52f, _0x662d66c6.Gold, _0x986cff22, TextAlignmentOptions.Center);
        TextMeshProUGUI _0x890306e0 = _0xaefb2489.Label(_0x1acfbec5, _0x03920495._0x4df4405a(new byte[10] { 201, 232, 243, 238, 228, 226, 197, 232, 227, 254 }, 135), Statement, 0.5f, 0.385f, 1060f, 300f, 34f, _0x662d66c6.Cream, _0x986cff22, TextAlignmentOptions.Center);
        _0xaefb2489.Cta(_0x1acfbec5, _0x03920495._0x4df4405a(new byte[11] { 208, 241, 234, 247, 253, 251, 219, 240, 234, 251, 236 }, 158), 0.5f, 0.22f, 720f, 168f, _0x0a477277.ButtonRect, Color.white, _0x03920495._0x4df4405a(new byte[5] { 124, 119, 109, 124, 107 }, 57), 56f, _0x662d66c6.Cream, _0x986cff22, () => _0x722b251d.Show(_0xda5171dd.ViewLobby));
        _0xaefb2489.Cta(_0x1acfbec5, _0x03920495._0x4df4405a(new byte[11] { 113, 80, 75, 86, 92, 90, 109, 74, 83, 90, 76 }, 63), 0.5f, 0.145f, 520f, 104f, _0x0a477277.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f), _0x03920495._0x4df4405a(new byte[10] { 133, 146, 150, 147, 247, 133, 130, 155, 146, 132 }, 215), 38f, _0x662d66c6.Gold, _0x986cff22, () => _0x722b251d.Show(_0xda5171dd.ViewRules));
        _0x32001b26.rectTransform.anchoredPosition = new Vector2(0f, 60f);
        _0x32001b26.rectTransform.DOAnchorPosY(0f, 0.35f).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        _0x890306e0.color = _0x662d66c6.Fade(_0x662d66c6.Cream, 0f);
        _0x890306e0.DOFade(1f, 0.25f).SetDelay(0.12f).SetLink(this.gameObject);
    }
}

internal static class _0x03920495
{
    internal static string _0x4df4405a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}