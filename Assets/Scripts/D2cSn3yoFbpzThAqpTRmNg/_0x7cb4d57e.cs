using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A detour stop: three face-down sign cards replace the SPIN button, and the one the
/// player taps flips over to reveal the multiplier it applies to the next spin. The flip is
/// a real, visible confirmation rather than a changed caption (rule C.7).
/// </summary>
public sealed class _0x7cb4d57e : MonoBehaviour
{
    /// <summary>Resolves the stop without a tap, so an idle run never stalls (rule C.5).</summary>
    public void _0xa5e67a5c(System.Action<float> _0xe2bb8543)
    {
        if (this._0xc7c518be || !this._0xea9f69f7)
        {
            return;
        }

        this._0xc7c518be = true;
        this._0x3f639a03(_0x720a2681[0], _0xe2bb8543);
    }

    /// <summary>Deals three cards; `onPicked` gets the multiplier the player turned over.</summary>
    public void _0x358385df(System.Random _0xfba294db, System.Action<float> _0x136e0553)
    {
        if (this._0xa11559df == null)
        {
            return;
        }

        for (int _0x2c9b7843 = this._0xa11559df.childCount - 1; _0x2c9b7843 >= 0; _0x2c9b7843--)
        {
            Destroy(this._0xa11559df.GetChild(_0x2c9b7843).gameObject);
        }

        this._0xc7c518be = false;
        this._0xa11559df.gameObject.SetActive(true);
        float[] _0x662fc17c =
        {
            _0x720a2681[0],
            _0x720a2681[1],
            _0x720a2681[2]
        };
        for (int _0x00b5eb9a = _0x662fc17c.Length - 1; _0x00b5eb9a > 0; _0x00b5eb9a--)
        {
            int _0x85194448 = _0xfba294db.Next(0, _0x00b5eb9a + 1);
            float _0x9db65c11 = _0x662fc17c[_0x00b5eb9a];
            _0x662fc17c[_0x00b5eb9a] = _0x662fc17c[_0x85194448];
            _0x662fc17c[_0x85194448] = _0x9db65c11;
        }

        _0xaefb2489.Label(this._0xa11559df, _0xbe4e0d90._0x05a59fa5(new byte[12] { 202, 235, 250, 225, 251, 252, 222, 252, 225, 227, 254, 250 }, 142), _0xbe4e0d90._0x05a59fa5(new byte[22] { 65, 64, 81, 74, 80, 87, 37, 40, 37, 81, 80, 87, 75, 37, 74, 75, 64, 37, 86, 76, 66, 75 }, 5), 0.5f, 0.345f, 1000f, 56f, 32f, _0x662d66c6.SunsetOrange, this._0x90684aa4, TextAlignmentOptions.Center);
        float[] _0x105cb99a =
        {
            0.21f,
            0.5f,
            0.79f
        };
        for (int _0x53694af0 = 0; _0x53694af0 < 3; _0x53694af0++)
        {
            float _0xc8ec148b = _0x662fc17c[_0x53694af0];
            Image _0xc4f7fb1e = _0xaefb2489.Plate(this._0xa11559df, _0xbe4e0d90._0x05a59fa5(new byte[10] { 249, 216, 201, 210, 200, 207, 254, 220, 207, 217 }, 189), _0x105cb99a[_0x53694af0], 0.215f, 320f, 360f, this._0x6ce3e80d.Plate, _0x662d66c6.Cobalt, 2.6f);
            TextMeshProUGUI _0x94d7f788 = _0xaefb2489.Label(_0xc4f7fb1e.rectTransform, _0xbe4e0d90._0x05a59fa5(new byte[10] { 65, 96, 113, 106, 112, 119, 67, 100, 102, 96 }, 5), _0xbe4e0d90._0x05a59fa5(new byte[1] { 236 }, 211), 0.5f, 0.5f, 260f, 200f, 96f, _0x662d66c6.Cream, this._0x90684aa4, TextAlignmentOptions.Center);
            RectTransform _0x60db75e9 = _0xaefb2489.Full(_0xc4f7fb1e.rectTransform, _0xbe4e0d90._0x05a59fa5(new byte[9] { 120, 89, 72, 83, 73, 78, 116, 85, 72 }, 60));
            Image _0x84468fa6 = _0x60db75e9.gameObject.AddComponent<Image>();
            _0x84468fa6.color = new Color(1f, 1f, 1f, 0f);
            _0x84468fa6.raycastTarget = true;
            Button _0x13a13b44 = _0x60db75e9.gameObject.AddComponent<Button>();
            _0x13a13b44.targetGraphic = _0x84468fa6;
            _0x13a13b44.onClick.AddListener(() => this._0xb39962af(_0xc4f7fb1e, _0x94d7f788, _0xc8ec148b, _0x136e0553));
            _0x60db75e9.gameObject.AddComponent<_0xccfd05ae>()._0x606fe1eb(_0xc4f7fb1e.rectTransform);
        }
    }

    public void _0xa37cbab6(_0x9a4ef192 _0x74617e49, TMP_FontAsset _0x5c78307a)
    {
        this._0x6ce3e80d = _0x74617e49;
        this._0x90684aa4 = _0x5c78307a;
        this._0xa11559df = _0xaefb2489.Full(this.GetComponent<RectTransform>(), _0xbe4e0d90._0x05a59fa5(new byte[11] { 47, 14, 31, 4, 30, 25, 40, 10, 25, 15, 24 }, 107));
        this._0xa11559df.gameObject.SetActive(false);
    }

    private static readonly float[] _0x720a2681 =
    {
        1.5f,
        2f,
        3f
    };
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private RectTransform _0xa11559df;
    private _0x9a4ef192 _0x6ce3e80d;
    private bool _0xc7c518be;
    private TMP_FontAsset _0x90684aa4;
    private void _0x3f639a03(float _0xf3aec9e0, System.Action<float> _0xd00dbd12)
    {
        if (this._0xa11559df != null)
        {
            this._0xa11559df.gameObject.SetActive(false);
        }

        if (_0xd00dbd12 != null)
        {
            _0xd00dbd12(_0xf3aec9e0);
        }
    }

    private void _0xb39962af(Image _0xaffa07d0, TextMeshProUGUI _0x008504f3, float _0x310571f4, System.Action<float> _0x649e5ee0)
    {
        if (this._0xc7c518be)
        {
            return;
        }

        this._0xc7c518be = true;
        _0xaffa07d0.color = _0x662d66c6.SunsetOrange;
        _0x008504f3.text = _0xbe4e0d90._0x05a59fa5(new byte[1] { 93 }, 37) + _0x310571f4.ToString(_0xbe4e0d90._0x05a59fa5(new byte[3] { 182, 168, 165 }, 134));
        _0xaffa07d0.rectTransform.DOLocalRotate(new Vector3(0f, 360f, 0f), _0x7d178cbc.Scaled(0.35f), RotateMode.FastBeyond360).SetEase(Ease.InOutQuad).SetLink(_0xaffa07d0.gameObject);
        DOVirtual.DelayedCall(_0x7d178cbc.Scaled(0.8f), () => this._0x3f639a03(_0x310571f4, _0x649e5ee0)).SetLink(this.gameObject);
    }

    public bool _0xea9f69f7
    {
        get
        {
            return this._0xa11559df != null && this._0xa11559df.gameObject.activeSelf;
        }
    }
}

internal static class _0xbe4e0d90
{
    internal static string _0x05a59fa5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}