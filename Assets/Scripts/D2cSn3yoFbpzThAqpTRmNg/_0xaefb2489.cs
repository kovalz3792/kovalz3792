using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// The one factory that builds this game's UI. Everything is uGUI on the template's own
/// canvases - there is not a single SpriteRenderer in the project - so the whole -29..9
/// sorting corridor is vacuous and draw order is plain hierarchy order (rule C.13): a child
/// added LATER draws ON TOP, so a frame is always created BEFORE the content it frames.
///
/// Coordinates are fractions of the panel, which is pinned to 1242x2688 by the template's
/// own AspectRatioFitter, so the same fraction lands in the same place on every device.
/// </summary>
public static class _0xaefb2489
{
    public const float RefH = 2688f;
    /// <summary>A round button carrying a glyph instead of a caption.</summary>
    public static Button IconCta(Transform _0x496e03b4, string _0x69e418b1, float _0x23437e50, float _0x696af589, float _0x23791321, Sprite _0x2e279bd3, Sprite _0x004efd01, Color _0xd0006bda, Color _0xbec7ac99, UnityAction _0xacb35715)
    {
        RectTransform _0x5e49a54d = Node(_0x496e03b4, _0x69e418b1, _0x23437e50, _0x696af589, _0x23791321, _0x23791321);
        Image _0xc05bcb41 = _0x5e49a54d.gameObject.AddComponent<Image>();
        _0xc05bcb41.sprite = _0x2e279bd3;
        _0xc05bcb41.color = _0xd0006bda;
        _0xc05bcb41.type = Image.Type.Simple;
        _0xc05bcb41.preserveAspect = true;
        _0xc05bcb41.raycastTarget = true;
        Button _0x8165902e = _0x5e49a54d.gameObject.AddComponent<Button>();
        _0x8165902e.targetGraphic = _0xc05bcb41;
        Picture(_0x5e49a54d, _0x69e418b1 + _0xfafb040a._0xc72480cc(new byte[5] { 183, 156, 137, 128, 152 }, 240), 0.5f, 0.5f, _0x23791321 * 0.52f, _0x23791321 * 0.52f, _0x004efd01, _0xbec7ac99);
        if (_0xacb35715 != null)
        {
            _0x8165902e.onClick.AddListener(() => _0xacb35715());
        }

        _0x5e49a54d.gameObject.AddComponent<_0xccfd05ae>()._0x606fe1eb(_0x5e49a54d);
        return _0x8165902e;
    }

    /// <summary>Colours a button's face and caption in one call - used for state changes.</summary>
    public static void Tint(Button _0x05cce650, Color _0x85531f90, Color _0x37541869)
    {
        if (_0x05cce650 == null)
        {
            return;
        }

        Image _0x245db55f = _0x05cce650.GetComponent<Image>();
        if (_0x245db55f != null)
        {
            _0x245db55f.color = _0x85531f90;
        }

        TextMeshProUGUI _0x402f21a0 = _0x05cce650.GetComponentInChildren<TextMeshProUGUI>(true);
        if (_0x402f21a0 != null)
        {
            _0x402f21a0.color = _0x37541869;
        }
    }

    /// <summary>An empty rect anchored at ONE point, sized in reference pixels.</summary>
    public static RectTransform Node(Transform _0x4ec06241, string _0x23c24ca4, float _0x5022b9f7, float _0x4920f895, float _0x29ccf3d1, float _0x32b5a118)
    {
        GameObject _0xc40ccf85 = new GameObject(_0x23c24ca4, typeof(RectTransform));
        RectTransform _0x7d679db4 = _0xc40ccf85.GetComponent<RectTransform>();
        _0x7d679db4.SetParent(_0x4ec06241, false);
        _0x7d679db4.anchorMin = new Vector2(_0x5022b9f7, _0x4920f895);
        _0x7d679db4.anchorMax = new Vector2(_0x5022b9f7, _0x4920f895);
        _0x7d679db4.pivot = new Vector2(0.5f, 0.5f);
        _0x7d679db4.anchoredPosition = Vector2.zero;
        _0x7d679db4.sizeDelta = new Vector2(_0x29ccf3d1, _0x32b5a118);
        _0x7d679db4.localScale = Vector3.one;
        return _0x7d679db4;
    }

    /// <summary>
    /// Content art - a symbol, an emblem, a glyph. Always Simple + preserveAspect, so the
    /// drawn shape keeps the proportions of the file it came from (rule F.2a).
    /// </summary>
    public static Image Picture(Transform _0xa5414fb6, string _0x800b5c84, float _0x9f239c65, float _0x7f55dc99, float _0xc8e4a9e4, float _0x9f8efe0f, Sprite _0x60d21d08, Color _0x894f4f16)
    {
        RectTransform _0x10979d4a = Node(_0xa5414fb6, _0x800b5c84, _0x9f239c65, _0x7f55dc99, _0xc8e4a9e4, _0x9f8efe0f);
        Image _0xc834d203 = _0x10979d4a.gameObject.AddComponent<Image>();
        _0xc834d203.sprite = _0x60d21d08;
        _0xc834d203.color = _0x894f4f16;
        _0xc834d203.type = Image.Type.Simple;
        _0xc834d203.preserveAspect = true;
        _0xc834d203.raycastTarget = false;
        return _0xc834d203;
    }

    /// <summary>A rect that fills its parent.</summary>
    public static RectTransform Full(Transform _0x31a4a7fb, string _0xbb92737c)
    {
        GameObject _0x24e4172c = new GameObject(_0xbb92737c, typeof(RectTransform));
        RectTransform _0xa1fa711d = _0x24e4172c.GetComponent<RectTransform>();
        _0xa1fa711d.SetParent(_0x31a4a7fb, false);
        Stretch(_0xa1fa711d);
        return _0xa1fa711d;
    }

    /// <summary>
    /// A 9-slice surface: plate, card, bar, rail or frame. Stretching is the point of these,
    /// so they are Sliced and never preserveAspect; the radius comes from the slice
    /// multiplier - lower is rounder.
    /// </summary>
    public static Image Plate(Transform _0xfdba0f7e, string _0x14ffb0c6, float _0x88322dd4, float _0x34b01d45, float _0x68fe6255, float _0x4b3cbcea, Sprite _0xf033cd6b, Color _0x9105d05c, float _0x932cb8a0)
    {
        RectTransform _0xc8814b21 = Node(_0xfdba0f7e, _0x14ffb0c6, _0x88322dd4, _0x34b01d45, _0x68fe6255, _0x4b3cbcea);
        Image _0x0abb5b31 = _0xc8814b21.gameObject.AddComponent<Image>();
        _0x0abb5b31.sprite = _0xf033cd6b;
        _0x0abb5b31.color = _0x9105d05c;
        _0x0abb5b31.type = Image.Type.Sliced;
        _0x0abb5b31.pixelsPerUnitMultiplier = _0x932cb8a0;
        _0x0abb5b31.raycastTarget = false;
        return _0x0abb5b31;
    }

    /// <summary>
    /// A button with a 9-slice face and a caption. Children are added face first, caption
    /// last, so the caption is never covered by its own background (rule E.1).
    /// </summary>
    public static Button Cta(Transform _0x638a3ebe, string _0x29b8c14d, float _0x50401e49, float _0x57e3749c, float _0xf2803211, float _0x9a13cb81, Sprite _0x94255f53, Color _0x98d69107, string _0x98242d4c, float _0x8c106a74, Color _0x854ebd1a, TMP_FontAsset _0x6f15d512, UnityAction _0x334e2e94)
    {
        RectTransform _0x90628d68 = Node(_0x638a3ebe, _0x29b8c14d, _0x50401e49, _0x57e3749c, _0xf2803211, _0x9a13cb81);
        Image _0xa47d7e65 = _0x90628d68.gameObject.AddComponent<Image>();
        _0xa47d7e65.sprite = _0x94255f53;
        _0xa47d7e65.color = _0x98d69107;
        _0xa47d7e65.type = Image.Type.Sliced;
        _0xa47d7e65.pixelsPerUnitMultiplier = 1.4f;
        _0xa47d7e65.raycastTarget = true;
        Button _0x128e698e = _0x90628d68.gameObject.AddComponent<Button>();
        _0x128e698e.targetGraphic = _0xa47d7e65;
        if (_0x98242d4c.Length > 0)
        {
            Label(_0x90628d68, _0x29b8c14d + _0xfafb040a._0xc72480cc(new byte[5] { 116, 89, 90, 93, 84 }, 56), _0x98242d4c, 0.5f, 0.5f, _0xf2803211 - 48f, _0x9a13cb81 - 36f, _0x8c106a74, _0x854ebd1a, _0x6f15d512, TextAlignmentOptions.Center);
        }

        if (_0x334e2e94 != null)
        {
            _0x128e698e.onClick.AddListener(() => _0x334e2e94());
        }

        _0x90628d68.gameObject.AddComponent<_0xccfd05ae>()._0x606fe1eb(_0x90628d68);
        return _0x128e698e;
    }

    /// <summary>Pins a rect to all four edges of its parent with no inset.</summary>
    public static void Stretch(RectTransform _0x11c2167f)
    {
        _0x11c2167f.anchorMin = Vector2.zero;
        _0x11c2167f.anchorMax = Vector2.one;
        _0x11c2167f.pivot = new Vector2(0.5f, 0.5f);
        _0x11c2167f.offsetMin = Vector2.zero;
        _0x11c2167f.offsetMax = Vector2.zero;
        _0x11c2167f.localScale = Vector3.one;
    }

    public const float RefW = 1242f;
    /// <summary>
    /// A caption. Line breaks belong to the caller, wrapping is off and autosize is on with
    /// the readability floor as the minimum (rule C.10). The colour must be light: the one
    /// font material in this app outlines every glyph in Asphalt (rule C.14).
    /// </summary>
    public static TextMeshProUGUI Label(Transform _0x80977017, string _0x1f5af893, string _0x7c68d301, float _0x6e035630, float _0x3a0d048a, float _0x9bf4335d, float _0x896c62ff, float _0xa1b4a7c5, Color _0x5d1f15ee, TMP_FontAsset _0xd58cd68c, TextAlignmentOptions _0x2c55a13b)
    {
        RectTransform _0x4bd92d9b = Node(_0x80977017, _0x1f5af893, _0x6e035630, _0x3a0d048a, _0x9bf4335d, _0x896c62ff);
        TextMeshProUGUI _0x948dcf6c = _0x4bd92d9b.gameObject.AddComponent<TextMeshProUGUI>();
        _0x37d5f8c0.Apply(_0x948dcf6c, _0xd58cd68c, _0xa1b4a7c5);
        _0x948dcf6c.alignment = _0x2c55a13b;
        _0x948dcf6c.color = _0x5d1f15ee;
        _0x948dcf6c.raycastTarget = false;
        _0x37d5f8c0.SetLines(_0x948dcf6c, _0x7c68d301);
        _0x4bd92d9b.gameObject.AddComponent<_0xf81721df>()._0x52b80235(_0x948dcf6c, _0x5d1f15ee);
        return _0x948dcf6c;
    }

    /// <summary>A full-bleed wash over whatever is behind it.</summary>
    public static Image Scrim(Transform _0xbdddba0e, string _0xf1e23a90, Sprite _0x0e1e0f07, Color _0x89ddf417)
    {
        RectTransform _0xaab645fb = Full(_0xbdddba0e, _0xf1e23a90);
        Image _0x24be8970 = _0xaab645fb.gameObject.AddComponent<Image>();
        _0x24be8970.sprite = _0x0e1e0f07;
        _0x24be8970.color = _0x89ddf417;
        _0x24be8970.type = Image.Type.Sliced;
        _0x24be8970.pixelsPerUnitMultiplier = 1f;
        _0x24be8970.raycastTarget = false;
        return _0x24be8970;
    }
}

internal static class _0xfafb040a
{
    internal static string _0xc72480cc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}