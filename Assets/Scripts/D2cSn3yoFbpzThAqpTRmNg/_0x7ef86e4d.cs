using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// How far along the route the player is. The fill is a left-anchored rect whose WIDTH is
/// driven - not a scale - so the rounded ends stay the right shape at every length.
/// </summary>
public sealed class _0x7ef86e4d : MonoBehaviour
{
    private const float TrackWidth = 1060f;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private const float Inset = 8f;
    private RectTransform _0xa78b872b;
    public void _0x90224777(_0x9a4ef192 _0xefaf10c4)
    {
        RectTransform _0x3e8e5956 = this.GetComponent<RectTransform>();
        Image _0x7e4ddc40 = _0xaefb2489.Plate(_0x3e8e5956, _0xd5f74983._0x5122c867(new byte[13] { 96, 66, 95, 87, 66, 85, 67, 67, 100, 66, 81, 83, 91 }, 48), 0.5f, 0.875f, TrackWidth, 44f, _0xefaf10c4.Plate, _0x662d66c6.TarWarm, 2.2f);
        RectTransform _0x0f1713f1 = _0xaefb2489.Node(_0x7e4ddc40.rectTransform, _0xd5f74983._0x5122c867(new byte[12] { 177, 147, 142, 134, 147, 132, 146, 146, 167, 136, 141, 141 }, 225), 0f, 0.5f, 0f, 28f);
        _0x0f1713f1.pivot = new Vector2(0f, 0.5f);
        _0x0f1713f1.anchoredPosition = new Vector2(Inset, 0f);
        Image _0x588517b0 = _0x0f1713f1.gameObject.AddComponent<Image>();
        _0x588517b0.sprite = _0xefaf10c4.Plate;
        _0x588517b0.type = Image.Type.Sliced;
        _0x588517b0.pixelsPerUnitMultiplier = 2.2f;
        _0x588517b0.color = _0x662d66c6.SunsetOrange;
        _0x588517b0.raycastTarget = false;
        this._0xa78b872b = _0x0f1713f1;
    }

    public void _0xa5f3d03a(int _0x4540e23a, int _0x538b9de9)
    {
        if (this._0xa78b872b == null || _0x538b9de9 <= 0)
        {
            return;
        }

        float _0x7127aafa = (float)_0x4540e23a / _0x538b9de9;
        float width = (TrackWidth - Inset * 2f) * Mathf.Clamp01(_0x7127aafa);
        this._0xa78b872b.DOSizeDelta(new Vector2(width, 28f), _0x7d178cbc.Scaled(0.35f)).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        Image _0x61c589ec = this._0xa78b872b.GetComponent<Image>();
        if (_0x61c589ec != null)
        {
            _0x61c589ec.color = Color.Lerp(_0x662d66c6.SunsetOrange, _0x662d66c6.Gold, Mathf.Clamp01(_0x7127aafa));
        }
    }
}

internal static class _0xd5f74983
{
    internal static string _0x5122c867(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}