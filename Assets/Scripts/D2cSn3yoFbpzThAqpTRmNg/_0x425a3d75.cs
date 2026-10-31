using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The splash, themed in the SCENE only. SplashPanel.cs and MainThreadUtil.cs are the
/// template owner's code and are never edited, not even by a comment (rule C.64) - this
/// view adds a darkening plate, the abstract mark and a caption, and retints the loading
/// bar the template already owns.
///
/// The bar matters: the template ships its track at alpha 0.004, i.e. invisible, and its
/// fill plain white. Rule G wants an accent fill on a dark track, and the inner rects are
/// re-stretched after the retint so the prefab's own 30-unit inset cannot collapse the bar
/// to nothing (ANDROID-3578). The bar root is NOT resized - at 1118x54 it is already well
/// clear of that inset.
///
/// It must also read as a different SCREEN from the lobby, or the capture gate sees one
/// screen twice: hence the heavy scrim here and none on the lobby.
/// </summary>
public sealed class _0x425a3d75 : MonoBehaviour
{
    /// <summary>
    /// Retints the template loading bar to the palette and re-stretches the rects under it.
    /// The Slider is found by COMPONENT TYPE, never by name - obfuscation renames objects.
    /// </summary>
    private void _0x50cc9592(_0x5902b324 _0xac742c8c, _0x9a4ef192 _0x755ded29)
    {
        if (_0xac742c8c == null)
        {
            return;
        }

        Slider _0xa4c2dc7f = _0xac742c8c.GetComponentInChildren<Slider>(true);
        if (_0xa4c2dc7f == null || _0xa4c2dc7f.fillRect == null)
        {
            return;
        }

        RectTransform _0xdec7d00e = _0xa4c2dc7f.fillRect.parent as RectTransform;
        if (_0xdec7d00e != null)
        {
            // Overwrite the prefab inset so the track cannot resolve to zero pixels.
            _0xdec7d00e.anchorMin = new Vector2(0f, 0f);
            _0xdec7d00e.anchorMax = new Vector2(1f, 1f);
            _0xdec7d00e.offsetMin = new Vector2(10f, 8f);
            _0xdec7d00e.offsetMax = new Vector2(-10f, -8f);
            Image _0xba8721bf = _0xdec7d00e.GetComponent<Image>();
            if (_0xba8721bf != null)
            {
                _0xba8721bf.sprite = _0x755ded29.Plate;
                _0xba8721bf.type = Image.Type.Sliced;
                _0xba8721bf.pixelsPerUnitMultiplier = 2.6f;
                _0xba8721bf.color = new Color(0.117647f, 0.101961f, 0.078431f, 0.9f);
            }
        }

        Image _0x4dd02bb1 = _0xa4c2dc7f.fillRect.GetComponent<Image>();
        if (_0x4dd02bb1 != null)
        {
            _0x4dd02bb1.sprite = _0x755ded29.Plate;
            _0x4dd02bb1.type = Image.Type.Sliced;
            _0x4dd02bb1.pixelsPerUnitMultiplier = 2.6f;
            _0x4dd02bb1.color = new Color(0.831373f, 0.686275f, 0.215686f, 1f);
        }

        // Only the offsets of the fill are ours: Slider.UpdateVisuals rewrites its anchors
        // every frame the value changes.
        _0xa4c2dc7f.fillRect.offsetMin = new Vector2(0f, 0f);
        _0xa4c2dc7f.fillRect.offsetMax = new Vector2(0f, 0f);
    }

    public void _0xa881fd0a(_0x9a4ef192 _0xd0cffaac, TMP_FontAsset _0x31c3f6e2, _0x5902b324 _0xdcd5b5f9)
    {
        RectTransform _0x2417e130 = this.GetComponent<RectTransform>();
        _0xaefb2489.Scrim(_0x2417e130, _0x7b14a7b3._0x53dd47ce(new byte[11] { 106, 73, 85, 88, 74, 81, 106, 90, 75, 80, 84 }, 57), _0xd0cffaac.Solid, _0x662d66c6.Fade(_0x662d66c6.Asphalt, 0.82f));
        RectTransform _0x8a399fc4 = _0xaefb2489.Node(_0x2417e130, _0x7b14a7b3._0x53dd47ce(new byte[10] { 99, 64, 92, 81, 67, 88, 125, 81, 66, 91 }, 48), 0.5f, 0.62f, 420f, 420f);
        Image _0x221cce0d = _0xaefb2489.Picture(_0x8a399fc4, _0x7b14a7b3._0x53dd47ce(new byte[12] { 148, 183, 171, 166, 180, 175, 130, 170, 165, 171, 162, 170 }, 199), 0.5f, 0.5f, 420f, 420f, _0xd0cffaac.Emblem, Color.white);
        _0x8a399fc4.localScale = new Vector3(0.86f, 0.86f, 1f);
        _0x8a399fc4.DOScale(1f, 0.45f).SetEase(Ease.OutBack).SetLink(this.gameObject);
        _0x221cce0d.color = new Color(1f, 1f, 1f, 0f);
        _0x221cce0d.DOFade(1f, 0.3f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        _0xaefb2489.Plate(_0x2417e130, _0x7b14a7b3._0x53dd47ce(new byte[10] { 155, 184, 164, 169, 187, 160, 154, 189, 164, 173 }, 200), 0.5f, 0.52f, 360f, 6f, _0xd0cffaac.Plate, _0x662d66c6.Fade(_0x662d66c6.Gold, 0.55f), 2.4f);
        _0xaefb2489.Label(_0x2417e130, _0x7b14a7b3._0x53dd47ce(new byte[13] { 107, 72, 84, 89, 75, 80, 123, 89, 72, 76, 81, 87, 86 }, 56), _0x7b14a7b3._0x53dd47ce(new byte[13] { 46, 45, 35, 38, 43, 44, 37, 66, 48, 45, 55, 54, 39 }, 98), 0.5f, 0.455f, 900f, 60f, 32f, _0x662d66c6.TextMuted, _0x31c3f6e2, TextAlignmentOptions.Center);
        this._0x50cc9592(_0xdcd5b5f9, _0xd0cffaac);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }
}

internal static class _0x7b14a7b3
{
    internal static string _0x53dd47ce(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}