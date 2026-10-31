using TMPro;
using UnityEngine;

/// <summary>
/// The one object this game adds to 2_GameScene. It hands the serialized art to the stop
/// director and clears the template HUD out of the way first.
///
/// The template parents its own strip - a pair of corner buttons, a coin container, a score
/// and a timer, all drawn for a different game - under the very panel this game fills. Stage
/// 5da switches most of it off by name, but the panel still has to end up with ONE
/// consistent set of controls, so every child the template put there is deactivated here and
/// this game's own HUD is built in its place (rules C.2 and H).
///
/// Set-up is in Start, not Awake: the template owns Awake for its singletons (rule C.59).
/// </summary>
public sealed class _0xf6606e06 : MonoBehaviour
{
    [SerializeField]
    private Sprite _logo;
    [SerializeField]
    private Sprite _sprite3;
    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _sprite1;
    [SerializeField]
    private Sprite _iconBack;
    private void Start()
    {
        _0xeeea9c75 _0xa55994db = _0xeeea9c75.Instance;
        if (_0xa55994db == null)
        {
            return;
        }

        _0x5902b324 _0xaa9ff575 = _0xa55994db.Panels[_0x7d9c5f21._0x491f71dc.DEFAULT];
        if (_0xaa9ff575 == null || _0xaa9ff575.Content == null)
        {
            return;
        }

        _0x9a4ef192 _0xfdb8378d = new _0x9a4ef192()._0x71902a68(this._plate, this._solid, this._buttonRect, this._buttonRound, this._logo, this._iconBack, this._iconPause, new Sprite[] { this._sprite1, this._sprite2, this._sprite3, this._sprite4, this._sprite5 });
        Transform _0x6a109390 = _0xaa9ff575.Content.transform;
        for (int _0x8858f315 = _0x6a109390.childCount - 1; _0x8858f315 >= 0; _0x8858f315--)
        {
            _0x6a109390.GetChild(_0x8858f315).gameObject.SetActive(false);
        }

        RectTransform _0x27dbcb43 = _0xaefb2489.Full(_0x6a109390, _0x222e68f9._0xd4381a86(new byte[12] { 214, 235, 229, 224, 215, 240, 235, 244, 214, 235, 235, 240 }, 132));
        _0x27dbcb43.gameObject.AddComponent<_0x3e5a25c6>()._0xcc9e8bb5(_0xfdb8378d, this._font);
    }

    [SerializeField]
    private Sprite _sprite4;
    [SerializeField]
    private Sprite _sprite2;
    [SerializeField]
    private Sprite _sprite5;
    [SerializeField]
    private Sprite _solid;
    [SerializeField]
    private Sprite _buttonRect;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _buttonRound;
    [SerializeField]
    private Sprite _iconPause;
}

internal static class _0x222e68f9
{
    internal static string _0xd4381a86(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}