using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The plate that drops in when a badge stop pays out, holds, and leaves. It is the single
/// most distinctive gameplay frame in the review album, which is why stop two of every
/// route is always a badge stop.
/// </summary>
public sealed class _0xb26250a2 : MonoBehaviour
{
    private Image _0xcc8232c1;
    public void _0xaa422bec(_0x9a4ef192 _0x89dfb007, TMP_FontAsset _0xf9df89c4)
    {
        RectTransform _0x65e3049c = this.GetComponent<RectTransform>();
        Image _0x18011ae6 = _0xaefb2489.Plate(_0x65e3049c, _0x1f5ffec1._0x06c24380(new byte[9] { 17, 50, 55, 52, 54, 16, 50, 33, 55 }, 83), 0.5f, 0.565f, 900f, 520f, _0x89dfb007.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.97f), 2.2f);
        this._0x2228eee3 = _0x18011ae6.rectTransform;
        _0xaefb2489.Plate(this._0x2228eee3, _0x1f5ffec1._0x06c24380(new byte[12] { 124, 95, 90, 89, 91, 125, 95, 76, 90, 108, 87, 83 }, 62), 0.5f, 0.5f, 860f, 480f, _0x89dfb007.Plate, _0x662d66c6.Fade(_0x662d66c6.Gold, 0.3f), 2.6f);
        _0xaefb2489.Label(this._0x2228eee3, _0x1f5ffec1._0x06c24380(new byte[12] { 231, 196, 193, 194, 192, 237, 192, 196, 193, 204, 203, 194 }, 165), _0x1f5ffec1._0x06c24380(new byte[11] { 136, 139, 142, 141, 143, 234, 140, 133, 159, 132, 142 }, 202), 0.5f, 0.84f, 780f, 72f, 44f, _0x662d66c6.Gold, _0xf9df89c4, TextAlignmentOptions.Center);
        this._0xcc8232c1 = _0xaefb2489.Picture(this._0x2228eee3, _0x1f5ffec1._0x06c24380(new byte[8] { 83, 112, 117, 118, 116, 80, 99, 101 }, 17), 0.5f, 0.48f, 230f, 230f, _0x89dfb007._0x7e4623dc(1), _0x662d66c6.CobaltGlow);
        this._0x60ed1d2f = _0xaefb2489.Label(this._0x2228eee3, _0x1f5ffec1._0x06c24380(new byte[9] { 209, 242, 247, 244, 246, 221, 242, 254, 246 }, 147), "", 0.5f, 0.16f, 780f, 64f, 34f, _0x662d66c6.Cream, _0xf9df89c4, TextAlignmentOptions.Center);
        this._0x2228eee3.gameObject.SetActive(false);
    }

    private RectTransform _0x2228eee3;
    private TextMeshProUGUI _0x60ed1d2f;
    private void _0x9b7ea90f()
    {
        if (this._0x2228eee3 == null)
        {
            return;
        }

        this._0x2228eee3.DOScale(0.8f, _0x7d178cbc.Scaled(_0x7d178cbc.BadgeOut)).SetEase(Ease.InQuad).OnComplete(() => this._0x6134d5b8()).SetLink(this._0x2228eee3.gameObject);
    }

    private void _0x6134d5b8()
    {
        if (this._0x2228eee3 != null)
        {
            this._0x2228eee3.gameObject.SetActive(false);
        }
    }

    public void _0x6d4027f4(string _0xb9c5c43a, Color _0x7a56736e)
    {
        if (this._0x2228eee3 == null)
        {
            return;
        }

        if (this._0x60ed1d2f != null)
        {
            this._0x60ed1d2f.text = _0xb9c5c43a;
        }

        if (this._0xcc8232c1 != null)
        {
            this._0xcc8232c1.color = _0x7a56736e;
        }

        this._0x2228eee3.gameObject.SetActive(true);
        this._0x2228eee3.localScale = new Vector3(0.82f, 0.82f, 1f);
        this._0x2228eee3.DOScale(1f, _0x7d178cbc.Scaled(_0x7d178cbc.BadgeIn)).SetEase(Ease.OutBack).SetLink(this._0x2228eee3.gameObject);
        DOVirtual.DelayedCall(_0x7d178cbc.Scaled(_0x7d178cbc.BadgeIn + _0x7d178cbc.BadgeHold), () => this._0x9b7ea90f()).SetLink(this.gameObject);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }
}

internal static class _0x1f5ffec1
{
    internal static string _0x06c24380(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}