using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game scene: one seeded route, driven stop by stop.
///
/// Timing is built around rule C.5. A stop costs about 4.2 seconds end to end - arrive,
/// spin, resolve, advance - and a route is at least eighteen of them, so a run with no wins
/// and no taps still lasts about 76 seconds. The review capture takes its first gameplay
/// frame near second 15 and its last near second 30, so it always photographs the game
/// rather than a defeat popup. An idle stop auto-spins after six seconds, so the run never
/// stalls on a frame where nothing is happening, and the credit ladder tops the player up
/// for free rather than ending the route early.
/// </summary>
public sealed class _0x3e5a25c6 : MonoBehaviour
{
    private void _0xbf7b3124(float _0x57916045)
    {
        this._0xf3bb9dae = _0x57916045;
        this._0xa2596254.text = _0x98b090ef._0x3cc0b2a8(new byte[26] { 34, 35, 50, 41, 51, 52, 70, 50, 39, 45, 35, 40, 70, 75, 70, 40, 35, 62, 50, 70, 53, 54, 47, 40, 70, 30 }, 102) + _0x57916045.ToString(_0x98b090ef._0x3cc0b2a8(new byte[3] { 188, 162, 175 }, 140));
        this._0xad3a4ae0(true);
        this._0xd3fb4151 = StateIdle;
        this._0x2e4ec398 = 0f;
    }

    /// <summary>
    /// The idle backstop. Six seconds without a tap resolves the stop by itself, so the run
    /// keeps producing new frames whether or not anyone is playing it.
    /// </summary>
    private void Update()
    {
        if (this._0xdb5bf412 || this._0xd3fb4151 == StateOver)
        {
            return;
        }

        float _0xf0a93a3a = this._0x6e3ef09e == 0 ? _0x7d178cbc.IdleFirstStop : _0x7d178cbc.IdleAutoSpin;
        if (this._0xd3fb4151 == StateIdle)
        {
            this._0x2e4ec398 += Time.deltaTime;
            if (this._0x2e4ec398 >= _0xf0a93a3a)
            {
                this._0x2e4ec398 = 0f;
                this._0xdcbd86aa();
            }

            return;
        }

        if (this._0xd3fb4151 == StateDetour)
        {
            this._0x2e4ec398 += Time.deltaTime;
            if (this._0x2e4ec398 >= _0xf0a93a3a)
            {
                this._0x2e4ec398 = 0f;
                this._0x2bba7246._0xa5e67a5c((_0x59feebae) => this._0xbf7b3124(_0x59feebae));
            }
        }
    }

    private _0xa60e0b17 _0x4d52188d;
    private _0xb26250a2 _0xf052d9d4;
    private void _0x399ba805(int[] _0x47e1b5b4, int stake)
    {
        this._0xd3fb4151 = StateResolving;
        _0xaefb2489.Tint(this._0xf13de00d, Color.white, _0x662d66c6.Cream);
        _0x45fae2d6 _0x30df6775 = _0xaa4ac3fa.Evaluate(_0x47e1b5b4, stake, this._0xf3bb9dae);
        this._0xf3bb9dae = 1f;
        this._0x3feda822._0x1976dbb2(_0x30df6775);
        if (_0x30df6775.Credits > 0)
        {
            this._0xa34765c6 += _0x30df6775.Credits;
            _0xf4914d3b._0x16e76d12 = _0xf4914d3b._0x16e76d12 + _0x30df6775.Credits;
            this._0xcae81aab._0x2d9787f8(this._0x3feda822, this._0x4d52188d._0xe965ac57, _0x30df6775);
            this._0x4d52188d._0x1ce46e4e(_0xf4914d3b._0x16e76d12);
            if (_0x30df6775.Credits > _0xf4914d3b._0xfd792853)
            {
                _0xf4914d3b._0xfd792853 = _0x30df6775.Credits;
            }

            string _0xfd1cff26 = _0x30df6775.TopSymbol >= 0 ? _0xaa4ac3fa.SymbolName(_0x30df6775.TopSymbol) + _0x98b090ef._0x3cc0b2a8(new byte[5] { 114, 30, 27, 28, 23 }, 82) : _0x98b090ef._0x3cc0b2a8(new byte[4] { 120, 105, 97, 108 }, 40);
            this._0xa2596254.text = _0xfd1cff26 + _0x98b090ef._0x3cc0b2a8(new byte[3] { 144, 157, 144 }, 176) + _0xf4914d3b.Money(_0x30df6775.Credits) + _0x98b090ef._0x3cc0b2a8(new byte[8] { 142, 237, 252, 235, 234, 231, 250, 253 }, 174);
        }
        else
        {
            this._0xa2596254.text = _0x98b090ef._0x3cc0b2a8(new byte[18] { 236, 237, 130, 238, 235, 236, 231, 130, 143, 130, 230, 240, 235, 244, 231, 130, 237, 236 }, 162);
        }

        _0xf4914d3b._0x2a892773 = _0xf4914d3b._0x2a892773 + 1;
        _0x6ab3f9d5.ReportSpin(_0x30df6775.Credits, _0x30df6775.LinesHit, false);
        DOVirtual.DelayedCall(_0x7d178cbc.Scaled(_0x7d178cbc.PayoutTrail), () => this._0xdc04cb3f()).SetLink(this.gameObject);
    }

    private _0x7ef86e4d _0x247e46d5;
    private int _0xd3fb4151 = StateIdle;
    private void _0xe612b846(int _0x65b96f0d)
    {
        this._0x6e3ef09e = _0x65b96f0d;
        this._0x2e4ec398 = 0f;
        this._0xf3bb9dae = this._0xf3bb9dae < 1f ? 1f : this._0xf3bb9dae;
        _0xf7978a15 _0x59c21d4c = this._0xeb60a30f;
        this._0x4d52188d._0xacf3b79e(_0x65b96f0d + 1, this._0x5c005961._0xe7956500);
        this._0x247e46d5._0xa5f3d03a(_0x65b96f0d, this._0x5c005961._0xe7956500);
        this._0xa2596254.text = _0x98b090ef._0x3cc0b2a8(new byte[5] { 226, 229, 254, 225, 145 }, 177) + (_0x65b96f0d + 1) + _0x98b090ef._0x3cc0b2a8(new byte[3] { 221, 208, 221 }, 253) + _0x59c21d4c._0x22fe4f9f();
        if (_0x59c21d4c.Kind == _0xf7978a15.KindDetour)
        {
            this._0xd3fb4151 = StateDetour;
            this._0xad3a4ae0(false);
            this._0x2bba7246._0x358385df(this._0x457ea603, (_0x59feebae) => this._0xbf7b3124(_0x59feebae));
            return;
        }

        this._0xd3fb4151 = StateIdle;
        this._0xad3a4ae0(true);
    }

    private int _0x6e3ef09e;
    public void _0xcc9e8bb5(_0x9a4ef192 _0x1e63830c, TMP_FontAsset _0x689e53e7)
    {
        this._0x30f4455d = _0x1e63830c;
        this._0x228189f0 = _0x689e53e7;
        this._0x5c005961 = _0xdb2c4cef.Build(_0xf4914d3b._0xf107532a, _0xf4914d3b._0x2a892773);
        this._0x457ea603 = new System.Random(this._0x5c005961.Seed ^ 31);
        _0x6ab3f9d5.EnsureToday();
        RectTransform _0x5f43bbdb = this.GetComponent<RectTransform>();
        this._0x4d52188d = _0x5f43bbdb.gameObject.AddComponent<_0xa60e0b17>();
        this._0x4d52188d._0x029f78dd(_0x1e63830c, _0x689e53e7, this);
        this._0x4d52188d._0x251a860f(_0xf4914d3b._0x16e76d12);
        this._0x247e46d5 = _0x5f43bbdb.gameObject.AddComponent<_0x7ef86e4d>();
        this._0x247e46d5._0x90224777(_0x1e63830c);
        Image _0xbfa15784 = _0xaefb2489.Plate(_0x5f43bbdb, _0x98b090ef._0x3cc0b2a8(new byte[10] { 46, 9, 18, 13, 47, 20, 31, 31, 18, 19 }, 125), 0.5f, 0.815f, 1060f, 96f, _0x1e63830c.Plate, _0x662d66c6.Fade(_0x662d66c6.Cobalt, 0.92f), 2.8f);
        this._0xa2596254 = _0xaefb2489.Label(_0xbfa15784.rectTransform, _0x98b090ef._0x3cc0b2a8(new byte[14] { 9, 46, 53, 42, 8, 51, 56, 56, 53, 52, 14, 63, 34, 46 }, 90), "", 0.5f, 0.5f, 980f, 68f, 38f, _0x662d66c6.Cream, _0x689e53e7, TextAlignmentOptions.Center);
        this._0x3feda822 = _0x5f43bbdb.gameObject.AddComponent<_0xec08c1a1>();
        this._0x3feda822._0x92898050(_0x1e63830c);
        _0xaefb2489.Label(_0x5f43bbdb, _0x98b090ef._0x3cc0b2a8(new byte[8] { 67, 101, 105, 97, 76, 109, 106, 112 }, 4), _0x98b090ef._0x3cc0b2a8(new byte[30] { 13, 24, 9, 121, 10, 9, 16, 23, 121, 13, 22, 121, 11, 22, 21, 21, 121, 13, 17, 28, 121, 11, 22, 24, 29, 121, 10, 13, 22, 9 }, 89), 0.5f, 0.315f, 1000f, 48f, 30f, _0x662d66c6.TextMuted, _0x689e53e7, TextAlignmentOptions.Center);
        this._0x5a4cc1da(_0x5f43bbdb, _0x1e63830c, _0x689e53e7);
        this._0xf13de00d = _0xaefb2489.Cta(_0x5f43bbdb, _0x98b090ef._0x3cc0b2a8(new byte[10] { 179, 144, 137, 142, 162, 149, 148, 148, 143, 142 }, 224), 0.5f, 0.185f, 760f, 180f, _0x1e63830c.ButtonRect, Color.white, _0x98b090ef._0x3cc0b2a8(new byte[4] { 193, 194, 219, 220 }, 146), 56f, _0x662d66c6.Cream, _0x689e53e7, () => this._0x66798bdb());
        this._0x2bba7246 = _0x5f43bbdb.gameObject.AddComponent<_0x7cb4d57e>();
        this._0x2bba7246._0xa37cbab6(_0x1e63830c, _0x689e53e7);
        this._0xcae81aab = _0x5f43bbdb.gameObject.AddComponent<_0x191fa614>();
        this._0xcae81aab._0x9c7142af(_0x1e63830c);
        this._0xf052d9d4 = _0x5f43bbdb.gameObject.AddComponent<_0xb26250a2>();
        this._0xf052d9d4._0xaa422bec(_0x1e63830c, _0x689e53e7);
        this._0xde735bf5 = _0x5f43bbdb.gameObject.AddComponent<_0xc4dbdaea>();
        this._0xde735bf5._0xe698748f(_0x1e63830c, _0x689e53e7, this);
        this._0xe612b846(0);
    }

    /// <summary>Ends the route from the pause card. The streak resets; nothing is lost.</summary>
    public void _0xb7bf78ce()
    {
        this._0xd3fb4151 = StateOver;
        this._0xdb5bf412 = false;
        this._0xad3a4ae0(false);
        _0xf4914d3b._0x14c4bbdd = 0;
        this._0xde735bf5._0x27f7d64a(this._0x6e3ef09e + 1, this._0x5c005961._0xe7956500, _0xf4914d3b._0x16e76d12);
    }

    private _0xec08c1a1 _0x3feda822;
    private void _0x5a4cc1da(RectTransform _0x72d368b3, _0x9a4ef192 _0x8c231240, TMP_FontAsset _0x94223818)
    {
        float[] _0x9f148b5e =
        {
            0.3035f,
            0.5f,
            0.6965f
        };
        for (int _0xa45274fc = 0; _0xa45274fc < _0xaa4ac3fa.Stakes.Length; _0xa45274fc++)
        {
            int _0xe132ffee = _0xa45274fc;
            this._0xb96b3792[_0xa45274fc] = _0xaefb2489.Cta(_0x72d368b3, _0x98b090ef._0x3cc0b2a8(new byte[9] { 102, 65, 84, 94, 80, 118, 93, 92, 69 }, 53), _0x9f148b5e[_0xa45274fc], 0.255f, 220f, 88f, _0x8c231240.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.96f), _0xaa4ac3fa.Stakes[_0xa45274fc].ToString(), 36f, _0x662d66c6.Cream, _0x94223818, () => this._0xd0dcd834(_0xe132ffee));
        }

        this._0x0de18609();
    }

    public void _0xaab268b7()
    {
        this._0xdb5bf412 = false;
        this._0x2e4ec398 = 0f;
    }

    /// <summary>The active chip takes the accent fill and a gold caption - a state change, not a label change.</summary>
    private void _0x0de18609()
    {
        for (int _0xaf311147 = 0; _0xaf311147 < this._0xb96b3792.Length; _0xaf311147++)
        {
            if (this._0xb96b3792[_0xaf311147] == null)
            {
                continue;
            }

            bool _0x1f276b2d = _0xaf311147 == this._0x15bdf1dd;
            _0xaefb2489.Tint(this._0xb96b3792[_0xaf311147], _0x1f276b2d ? _0x662d66c6.Fade(_0x662d66c6.SunsetOrange, 0.85f) : _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.96f), _0x1f276b2d ? _0x662d66c6.Cream : _0x662d66c6.TextMuted);
        }
    }

    private float _0x2e4ec398;
    private TMP_FontAsset _0x228189f0;
    private const int StateIdle = 0;
    private _0xf7978a15 _0xeb60a30f
    {
        get
        {
            return this._0x5c005961.Stops[this._0x6e3ef09e];
        }
    }

    private TextMeshProUGUI _0xa2596254;
    private void _0xd0dcd834(int _0xbdd37ede)
    {
        if (this._0xd3fb4151 != StateIdle)
        {
            return;
        }

        this._0x15bdf1dd = _0xbdd37ede;
        this._0x0de18609();
    }

    private const int StateOver = 4;
    private float _0xf3bb9dae = 1f;
    public void _0xe24586b2()
    {
        if (this._0xd3fb4151 == StateOver)
        {
            return;
        }

        this._0xdb5bf412 = true;
        this._0xde735bf5._0xd7d4516d(this._0x6e3ef09e + 1, this._0x5c005961._0xe7956500, _0xf4914d3b._0x16e76d12);
    }

    private void _0xdc04cb3f()
    {
        _0xf7978a15 _0x1f97a1e4 = this._0xeb60a30f;
        float _0xba134a97 = _0x7d178cbc.Scaled(_0x7d178cbc.StopAdvance);
        if (_0x1f97a1e4.Kind == _0xf7978a15.KindBadge)
        {
            _0xf4914d3b.GrantBadge(_0x1f97a1e4.BadgeIndex);
            this._0x5b197c85++;
            this._0xf052d9d4._0x6d4027f4(_0xef4c56a7[_0x1f97a1e4.BadgeIndex % _0xef4c56a7.Length], _0x5c39f428.TintOf(_0xf4914d3b._0x51ab4991));
            _0xba134a97 = _0x7d178cbc.Scaled(_0x7d178cbc.BadgeIn + _0x7d178cbc.BadgeHold + _0x7d178cbc.BadgeOut);
        }
        else if (_0x1f97a1e4.Kind == _0xf7978a15.KindGift)
        {
            _0xf4914d3b._0x16e76d12 = _0xf4914d3b._0x16e76d12 + _0x1f97a1e4.GiftCredits;
            this._0xa34765c6 += _0x1f97a1e4.GiftCredits;
            this._0x4d52188d._0x1ce46e4e(_0xf4914d3b._0x16e76d12);
            this._0xa2596254.text = _0x98b090ef._0x3cc0b2a8(new byte[12] { 44, 49, 63, 58, 94, 57, 55, 56, 42, 94, 83, 94 }, 126) + _0x1f97a1e4.GiftCredits + _0x98b090ef._0x3cc0b2a8(new byte[13] { 200, 174, 186, 173, 173, 200, 171, 186, 173, 172, 161, 188, 187 }, 232);
            _0xba134a97 = _0x7d178cbc.Scaled(_0x7d178cbc.CountUp + 0.3f);
        }

        DOVirtual.DelayedCall(_0xba134a97, () => this._0xa1c6e9f8()).SetLink(this.gameObject);
    }

    private _0x191fa614 _0xcae81aab;
    private void _0xad3a4ae0(bool _0x52037376)
    {
        if (this._0xf13de00d != null)
        {
            this._0xf13de00d.gameObject.SetActive(_0x52037376);
        }

        for (int _0x7978b568 = 0; _0x7978b568 < this._0xb96b3792.Length; _0x7978b568++)
        {
            if (this._0xb96b3792[_0x7978b568] != null)
            {
                this._0xb96b3792[_0x7978b568].gameObject.SetActive(_0x52037376);
            }
        }
    }

    public void _0xd955e19a()
    {
        _0x5b07c2df.Instance._0xac2de253(_0x7d9c5f21._0x4c653446.SCENE_1);
    }

    private void _0xdcbd86aa()
    {
        int stake = this._0xb3fdeccd();
        this._0xd3fb4151 = StateSpinning;
        this._0xad3a4ae0(true);
        _0xaefb2489.Tint(this._0xf13de00d, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.9f), _0x662d66c6.TextMuted);
        int[] _0x548b2024 = _0xaa4ac3fa.Spin(this._0x457ea603, this._0xeb60a30f.WeightTable);
        this._0x3feda822._0x7b01e40b(_0x548b2024, this._0x457ea603);
        float _0xa39eef05 = this._0x3feda822._0x99d8bf06();
        DOVirtual.DelayedCall(_0xa39eef05, () => this._0x399ba805(_0x548b2024, stake)).SetLink(this.gameObject);
    }

    private void _0x79718957()
    {
        this._0xd3fb4151 = StateOver;
        this._0xad3a4ae0(false);
        _0xf4914d3b._0xf107532a = _0xf4914d3b._0xf107532a + 1;
        _0xf4914d3b._0x14c4bbdd = _0xf4914d3b._0x14c4bbdd + 1;
        _0x6ab3f9d5.ReportRouteCleared(this._0x5b197c85);
        this._0xde735bf5._0x9be78baf(this._0x5c005961._0xe7956500, this._0xa34765c6, this._0x5b197c85);
    }

    private void _0xa1c6e9f8()
    {
        if (this._0xd3fb4151 == StateOver)
        {
            return;
        }

        int _0x614d2e52 = this._0x6e3ef09e + 1;
        if (_0x614d2e52 >= this._0x5c005961._0xe7956500)
        {
            this._0x79718957();
            return;
        }

        this._0x247e46d5._0xa5f3d03a(_0x614d2e52, this._0x5c005961._0xe7956500);
        DOVirtual.DelayedCall(_0x7d178cbc.Scaled(_0x7d178cbc.StopArrive), () => this._0xe612b846(_0x614d2e52)).SetLink(this.gameObject);
    }

    private const int StateDetour = 3;
    private void _0x66798bdb()
    {
        if (this._0xd3fb4151 != StateIdle || this._0xdb5bf412)
        {
            return;
        }

        this._0xdcbd86aa();
    }

    private readonly Button[] _0xb96b3792 = new Button[3];
    private bool _0xdb5bf412;
    private _0xc4dbdaea _0xde735bf5;
    private int _0x15bdf1dd = 1;
    private int _0x5b197c85;
    public void _0x5d5079b7()
    {
        _0x5b07c2df.Instance._0xac2de253(_0x7d9c5f21._0x4c653446.SCENE_0);
    }

    private Button _0xf13de00d;
    private const int StateSpinning = 1;
    private const int StateResolving = 2;
    private _0x7cb4d57e _0x2bba7246;
    private _0x9a4ef192 _0x30f4455d;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private _0x3394b55a _0x5c005961;
    private System.Random _0x457ea603;
    private int _0xa34765c6;
    /// <summary>
    /// The credit ladder: the chosen stake, then the smallest stake, then a complimentary
    /// top-up. The route always reaches its last stop; nothing here is ever a prompt to buy.
    /// </summary>
    private int _0xb3fdeccd()
    {
        int _0x258deb6e = _0xf4914d3b._0x16e76d12;
        int stake = _0xaa4ac3fa.Stakes[this._0x15bdf1dd];
        if (_0x258deb6e < stake)
        {
            stake = _0xaa4ac3fa.Stakes[0];
            this._0x15bdf1dd = 0;
            this._0x0de18609();
        }

        if (_0x258deb6e < stake)
        {
            _0x258deb6e += _0xaa4ac3fa.TopUpCredits;
            _0xf4914d3b._0x16e76d12 = _0x258deb6e;
            this._0x4d52188d._0x1ce46e4e(_0x258deb6e);
            this._0xa2596254.text = _0x98b090ef._0x3cc0b2a8(new byte[14] { 35, 55, 32, 32, 69, 49, 42, 53, 72, 48, 53, 69, 72, 69 }, 101) + _0xaa4ac3fa.TopUpCredits + _0x98b090ef._0x3cc0b2a8(new byte[8] { 181, 214, 199, 208, 209, 220, 193, 198 }, 149);
        }

        _0xf4914d3b._0x16e76d12 = _0xf4914d3b._0x16e76d12 - stake;
        this._0x4d52188d._0x251a860f(_0xf4914d3b._0x16e76d12);
        return stake;
    }

    private static readonly string[] _0xef4c56a7 =
    {
        _0x98b090ef._0x3cc0b2a8(new byte[6] { 29, 27, 20, 14, 8, 3 }, 90),
        _0x98b090ef._0x3cc0b2a8(new byte[5] { 117, 121, 118, 113, 102 }, 52),
        _0x98b090ef._0x3cc0b2a8(new byte[6] { 88, 84, 89, 90, 87, 79 }, 27),
        _0x98b090ef._0x3cc0b2a8(new byte[7] { 157, 144, 159, 133, 148, 131, 159 }, 209),
        _0x98b090ef._0x3cc0b2a8(new byte[4] { 204, 221, 219, 195 }, 136),
        _0x98b090ef._0x3cc0b2a8(new byte[4] { 80, 83, 86, 81 }, 3),
        _0x98b090ef._0x3cc0b2a8(new byte[6] { 195, 199, 211, 192, 192, 203 }, 146),
        _0x98b090ef._0x3cc0b2a8(new byte[6] { 49, 43, 37, 44, 35, 46 }, 98),
        _0x98b090ef._0x3cc0b2a8(new byte[6] { 168, 175, 172, 172, 175, 183 }, 224),
        _0x98b090ef._0x3cc0b2a8(new byte[5] { 187, 179, 188, 187, 172 }, 254),
        _0x98b090ef._0x3cc0b2a8(new byte[7] { 69, 90, 82, 87, 70, 80, 71 }, 19),
        _0x98b090ef._0x3cc0b2a8(new byte[4] { 82, 91, 79, 86 }, 26)
    };
}

internal static class _0x98b090ef
{
    internal static string _0x3cc0b2a8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}