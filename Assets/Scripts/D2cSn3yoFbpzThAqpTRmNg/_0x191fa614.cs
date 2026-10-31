using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The coin trail: a handful of sparks that fly from the winning cells to the credit
/// readout while the number counts up. Every spark is linked to its own object, so a
/// scene change kills them instead of leaving DOTween animating destroyed images on the
/// next scene's first frame (rule C.56).
/// </summary>
public sealed class _0x191fa614 : MonoBehaviour
{
    public void _0x9c7142af(_0x9a4ef192 _0x19001d34)
    {
        this._0x541d8e0a = _0x19001d34;
    }

    public void _0x2d9787f8(_0xec08c1a1 _0xcb1dfb80, RectTransform _0x1a760974, _0x45fae2d6 _0x6917d60e)
    {
        if (_0xcb1dfb80 == null || _0x1a760974 == null || this._0x541d8e0a == null)
        {
            return;
        }

        RectTransform _0x0766745c = this.GetComponent<RectTransform>();
        int _0x68f3b59f = 0;
        for (int _0xa99007d3 = 0; _0xa99007d3 < _0x6917d60e.Winning.Length && _0x68f3b59f < 14; _0xa99007d3++)
        {
            if (!_0x6917d60e.Winning[_0xa99007d3])
            {
                continue;
            }

            Image _0x0da8f230 = _0xaefb2489.Picture(_0x0766745c, _0x80d66ab9._0x3b655352(new byte[10] { 160, 134, 149, 157, 152, 167, 132, 149, 134, 159 }, 244), 0.5f, 0.5f, 70f, 70f, this._0x541d8e0a._0x7e4623dc(0), _0x662d66c6.GoldLight);
            _0x0da8f230.rectTransform.position = _0xcb1dfb80._0x704c3508(_0xa99007d3);
            float _0x5d82fc27 = 0.04f * _0x68f3b59f;
            _0x0da8f230.rectTransform.DOMove(_0x1a760974.position, _0x7d178cbc.Scaled(_0x7d178cbc.PayoutTrail)).SetDelay(_0x5d82fc27).SetEase(Ease.InOutCubic).SetLink(_0x0da8f230.gameObject);
            _0x0da8f230.DOFade(0f, _0x7d178cbc.Scaled(0.3f)).SetDelay(_0x5d82fc27 + _0x7d178cbc.Scaled(_0x7d178cbc.PayoutTrail) - 0.3f).SetLink(_0x0da8f230.gameObject);
            Destroy(_0x0da8f230.gameObject, _0x7d178cbc.Scaled(_0x7d178cbc.PayoutTrail) + _0x5d82fc27 + 0.4f);
            _0x68f3b59f++;
        }
    }

    private _0x9a4ef192 _0x541d8e0a;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }
}

internal static class _0x80d66ab9
{
    internal static string _0x3b655352(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}