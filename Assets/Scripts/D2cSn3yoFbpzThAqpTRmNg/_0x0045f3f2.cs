using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The one object this game adds to 1_MenuScene. It owns the serialized art and hands it to
/// the splash brand and the lobby, both of which are built INTO the template's own panels -
/// PanelController.Instance.Panels[index].Content - rather than onto a canvas of their own.
/// A second canvas would either draw over the popups or sit visible underneath the splash
/// for the whole of its run.
///
/// Set-up lives in Start, never Awake: the template claims Awake for its own singletons and
/// the order between two scene roots is undefined (rule C.59).
/// </summary>
public sealed class _0x0045f3f2 : MonoBehaviour
{
    [SerializeField]
    private Sprite _sprite3;
    [SerializeField]
    private Sprite _sprite5;
    private void _0x1ee5a639(_0xeeea9c75 _0x09e7fcc4, _0x9a4ef192 _0xf476425d)
    {
        _0x5902b324 _0x1343b65f = _0x09e7fcc4.Panels[_0x7d9c5f21._0x491f71dc.DEFAULT];
        if (_0x1343b65f == null || _0x1343b65f.Content == null)
        {
            return;
        }

        RectTransform _0x10beae7b = _0xaefb2489.Full(_0x1343b65f.Content.transform, _0x4d74d113._0x7afb6580(new byte[14] { 189, 128, 154, 155, 138, 163, 128, 141, 141, 150, 189, 128, 128, 155 }, 239));
        // FIRST sibling on purpose: the template Play slot is the only other child of this
        // panel and it has to stay on top of the lobby backdrop. Every sheet hides the slot
        // while it is open, so nothing is ever covered by it.
        _0x10beae7b.SetAsFirstSibling();
        _0x10beae7b.gameObject.AddComponent<_0xda5171dd>()._0x64a472ac(_0xf476425d, this._font, this._playSlot);
    }

    private void _0x9f25ec3c(_0xeeea9c75 _0x72cf4865, _0x9a4ef192 _0x96120d97)
    {
        _0x5902b324 _0x711b03b3 = _0x72cf4865.Panels[_0x7d9c5f21._0x491f71dc.SPLASH];
        if (_0x711b03b3 == null || _0x711b03b3.Content == null)
        {
            return;
        }

        RectTransform _0x4b6aa3db = _0xaefb2489.Full(_0x711b03b3.Content.transform, _0x4d74d113._0x7afb6580(new byte[16] { 84, 105, 115, 114, 99, 85, 118, 106, 103, 117, 110, 68, 116, 103, 104, 98 }, 6));
        _0x4b6aa3db.SetAsFirstSibling();
        _0x4b6aa3db.gameObject.AddComponent<_0x425a3d75>()._0xa881fd0a(_0x96120d97, this._font, _0x711b03b3);
    }

    [SerializeField]
    private Sprite _buttonRound;
    /// <summary>
    /// The template Play slot that already carries a LoadSceneButton to the game scene.
    /// It renders nothing of its own, so the visible face is drawn into it at runtime; its
    /// size and position come from the scene (rule G.3).
    /// </summary>
    [SerializeField]
    private RectTransform _playSlot;
    private void Start()
    {
        _0x9a4ef192 _0xebfbdcbe = new _0x9a4ef192()._0x71902a68(this._plate, this._solid, this._buttonRect, this._buttonRound, this._logo, this._iconBack, this._iconPause, new Sprite[] { this._sprite1, this._sprite2, this._sprite3, this._sprite4, this._sprite5 });
        _0xeeea9c75 _0x7c5c4753 = _0xeeea9c75.Instance;
        if (_0x7c5c4753 == null)
        {
            return;
        }

        this._0x9f25ec3c(_0x7c5c4753, _0xebfbdcbe);
        this._0x1ee5a639(_0x7c5c4753, _0xebfbdcbe);
        this._0x8151fee1(_0x7c5c4753);
        // Keep the template coin readouts in step with this game's credit rail.
        _0xf4914d3b._0x16e76d12 = _0xf4914d3b._0x16e76d12;
    }

    [SerializeField]
    private Sprite _buttonRect;
    [SerializeField]
    private Sprite _sprite1;
    [SerializeField]
    private Sprite _sprite2;
    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private Sprite _solid;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _sprite4;
    [SerializeField]
    private Sprite _logo;
    [SerializeField]
    private Sprite _iconPause;
    /// <summary>
    /// The template ships seven tutorial panels and this game dresses none of them - its
    /// control is a single tap and the game scene carries a visible hint instead. Their
    /// placeholder copy must still never reach a screen (rule C.15), and the panels stay in
    /// place because the controller addresses them by index.
    /// </summary>
    private void _0x8151fee1(_0xeeea9c75 _0x8b406209)
    {
        for (int _0x19d0b974 = _0x7d9c5f21._0x491f71dc.TUTORIAL0; _0x19d0b974 <= _0x7d9c5f21._0x491f71dc.TUTORIAL6; _0x19d0b974++)
        {
            if (_0x19d0b974 < 0 || _0x19d0b974 >= _0x8b406209.Panels.Count)
            {
                continue;
            }

            _0x5902b324 _0xd8f8b93c = _0x8b406209.Panels[_0x19d0b974];
            if (_0xd8f8b93c == null)
            {
                continue;
            }

            TMP_Text[] _0x768c6d9e = _0xd8f8b93c.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xfe49bd39 = 0; _0xfe49bd39 < _0x768c6d9e.Length; _0xfe49bd39++)
            {
                _0x768c6d9e[_0xfe49bd39].text = "";
            }
        }
    }

    [SerializeField]
    private Sprite _plate;
}

internal static class _0x4d74d113
{
    internal static string _0x7afb6580(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}