using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The menu shell. It owns every lobby view, shows exactly one at a time through a
/// ViewGate, and draws the face of the template Play slot - that slot carries the only
/// LoadSceneButton to the game scene but renders nothing of its own.
///
/// The 18+ notice is shown on EVERY cold start, deliberately: it is not hidden behind a
/// first-run flag, so it is always in the review album and always one tap from the lobby.
/// </summary>
public sealed class _0xda5171dd : MonoBehaviour
{
    public const int ViewAlbum = 5;
    public const int ViewLobby = 1;
    private _0x9a4ef192 _0xf8dff11d;
    public void _0x13a54356()
    {
        this.Show(ViewLobby);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    public const int ViewProfile = 7;
    public const int ViewMissions = 4;
    private readonly _0x4dc10b93[] _0x9ec77191 = new _0x4dc10b93[10];
    private _0x1e63d933 _0x91b7a6b2;
    public void _0x64a472ac(_0x9a4ef192 _0xd0cc52ee, TMP_FontAsset _0x7b378dff, RectTransform _0x8ff32bce)
    {
        this._0xf8dff11d = _0xd0cc52ee;
        this._0x3b1e7034 = _0x7b378dff;
        this._0x40aaf1fa = _0x8ff32bce;
        this._0x1a2c28b2 = _0xdb2c4cef.Build(_0xf4914d3b._0xf107532a, _0xf4914d3b._0x2a892773);
        _0x6ab3f9d5.EnsureToday();
        RectTransform _0xb0921ab5 = this.GetComponent<RectTransform>();
        this._0x30db191f();
        this._0xfc358b18 = this._0x1199c686<_0xed395f66>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[13] { 155, 164, 168, 186, 159, 162, 172, 169, 129, 162, 175, 175, 180 }, 205), ViewLobby);
        this._0xfc358b18._0x3fa24e71(this);
        this._0x1199c686<_0x2fd63b4b>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[13] { 114, 77, 65, 83, 101, 67, 65, 106, 75, 80, 77, 71, 65 }, 36), ViewAgeNotice)._0x9806123f(this);
        this._0x1199c686<_0xc0ee4864>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[12] { 135, 184, 180, 166, 131, 190, 164, 165, 180, 156, 176, 161 }, 209), ViewRouteMap)._0x5d573e0b(this);
        this._0x91b7a6b2 = this._0x1199c686<_0x1e63d933>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[13] { 37, 26, 22, 4, 55, 18, 26, 31, 10, 52, 26, 21, 7 }, 115), ViewDailyGift);
        this._0x91b7a6b2._0x2f59dc52(this);
        this._0x1199c686<_0x5906d90d>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[12] { 224, 223, 211, 193, 251, 223, 197, 197, 223, 217, 216, 197 }, 182), ViewMissions)._0x65c304bb(this);
        this._0x1199c686<_0x03111da6>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[13] { 73, 118, 122, 104, 92, 112, 118, 113, 94, 115, 125, 106, 114 }, 31), ViewAlbum)._0xdf31f18c(this);
        this._0x1199c686<_0x5c39f428>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[13] { 95, 96, 108, 126, 77, 108, 106, 102, 123, 104, 125, 102, 123 }, 9), ViewDecor)._0xe077ca67(this);
        this._0x1199c686<_0x09a9c1eb>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[11] { 41, 22, 26, 8, 47, 13, 16, 25, 22, 19, 26 }, 127), ViewProfile)._0x85ad6e92(this);
        this._0x1199c686<_0x4df9493a>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[9] { 225, 222, 210, 192, 229, 194, 219, 210, 196 }, 183), ViewRules)._0xf742d638(this);
        this._0x1199c686<_0x2627fb08>(_0xb0921ab5, _0x6c386f10._0x93d38541(new byte[12] { 117, 74, 70, 84, 112, 70, 87, 87, 74, 77, 68, 80 }, 35), ViewSettings)._0xca23a713(this);
        this.Show(ViewAgeNotice);
    }

    public _0x3394b55a _0x7b4794ef
    {
        get
        {
            return this._0x1a2c28b2;
        }
    }

    public _0x9a4ef192 _0xd24f5652
    {
        get
        {
            return this._0xf8dff11d;
        }
    }

    private RectTransform _0x40aaf1fa;
    private T _0x1199c686<T>(RectTransform _0x71458001, string _0xd451e03c, int _0xe8bf2466)
        where T : MonoBehaviour
    {
        RectTransform _0x9701ffec = _0xaefb2489.Full(_0x71458001, _0xd451e03c);
        this._0x9ec77191[_0xe8bf2466] = new _0x4dc10b93()._0x10cb5862(_0x9701ffec.gameObject);
        return _0x9701ffec.gameObject.AddComponent<T>();
    }

    public const int ViewAgeNotice = 0;
    public const int ViewRouteMap = 2;
    public const int ViewDecor = 6;
    private _0xed395f66 _0xfc358b18;
    public const int ViewRules = 8;
    public const int ViewDailyGift = 3;
    public const int ViewSettings = 9;
    /// <summary>
    /// The template Play slot is an EMPTY button - its only live graphic is a fade layer the
    /// Button multiplies to zero in its normal state. The visible face is therefore this
    /// game's own child, drawn inside the slot so the parent Button still takes the tap.
    /// </summary>
    private void _0x30db191f()
    {
        if (this._0x40aaf1fa == null)
        {
            return;
        }

        RectTransform _0xff334808 = _0xaefb2489.Full(this._0x40aaf1fa, _0x6c386f10._0x93d38541(new byte[13] { 234, 215, 205, 204, 221, 232, 212, 217, 193, 254, 217, 219, 221 }, 184));
        Image _0xf3d25f3b = _0xff334808.gameObject.AddComponent<Image>();
        _0xf3d25f3b.sprite = this._0xf8dff11d.ButtonRect;
        _0xf3d25f3b.type = Image.Type.Sliced;
        _0xf3d25f3b.pixelsPerUnitMultiplier = 1.4f;
        _0xf3d25f3b.color = Color.white;
        _0xf3d25f3b.raycastTarget = true;
        _0xaefb2489.Label(_0xff334808, _0x6c386f10._0x93d38541(new byte[14] { 255, 194, 216, 217, 200, 253, 193, 204, 212, 225, 204, 207, 200, 193 }, 173), _0x6c386f10._0x93d38541(new byte[11] { 63, 56, 45, 62, 56, 76, 62, 35, 57, 56, 41 }, 108), 0.5f, 0.5f, 640f, 110f, 56f, _0x662d66c6.Cream, this._0x3b1e7034, TextAlignmentOptions.Center);
    }

    public TMP_FontAsset _0x88e5de05
    {
        get
        {
            return this._0x3b1e7034;
        }
    }

    private _0x3394b55a _0x1a2c28b2;
    public void _0xfdf4460d(int _0xa85ddc55)
    {
        _0xf4914d3b._0x16e76d12 = _0xf4914d3b._0x16e76d12 + _0xa85ddc55;
        if (this._0xfc358b18 != null)
        {
            this._0xfc358b18._0x8755a153();
        }
    }

    /// <summary>Raises one view and lowers the rest; the Play slot belongs to the lobby only.</summary>
    public void Show(int _0x126a11f4)
    {
        for (int _0xa1e6d41a = 0; _0xa1e6d41a < this._0x9ec77191.Length; _0xa1e6d41a++)
        {
            if (this._0x9ec77191[_0xa1e6d41a] == null)
            {
                continue;
            }

            if (_0xa1e6d41a == _0x126a11f4)
            {
                this._0x9ec77191[_0xa1e6d41a].Show();
            }
            else
            {
                this._0x9ec77191[_0xa1e6d41a]._0x908a647b();
            }
        }

        if (this._0x40aaf1fa != null)
        {
            this._0x40aaf1fa.gameObject.SetActive(_0x126a11f4 == ViewLobby);
        }

        if (_0x126a11f4 == ViewLobby && this._0xfc358b18 != null)
        {
            this._0xfc358b18._0x8755a153();
        }

        if (_0x126a11f4 == ViewDailyGift && this._0x91b7a6b2 != null)
        {
            this._0x91b7a6b2._0xf4e4f1e2();
        }

        _0x4dc10b93 _0x765d53ec = _0x126a11f4 >= 0 && _0x126a11f4 < this._0x9ec77191.Length ? this._0x9ec77191[_0x126a11f4] : null;
        if (_0x765d53ec == null || _0x765d53ec._0xab14d376 == null)
        {
            return;
        }

        RectTransform _0x585aa8c9 = _0x765d53ec._0xab14d376.GetComponent<RectTransform>();
        if (_0x585aa8c9 != null)
        {
            _0x585aa8c9.anchoredPosition = new Vector2(0f, 36f);
            _0x585aa8c9.DOAnchorPosY(0f, _0x7d178cbc.Scaled(_0x7d178cbc.View)).SetEase(Ease.OutCubic).SetLink(_0x585aa8c9.gameObject);
        }
    }

    private TMP_FontAsset _0x3b1e7034;
}

internal static class _0x6c386f10
{
    internal static string _0x93d38541(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}