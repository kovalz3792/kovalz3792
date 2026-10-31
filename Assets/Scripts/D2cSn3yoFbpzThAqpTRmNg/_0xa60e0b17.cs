using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This game's own top bar: credits, the stop counter and the two navigation controls.
///
/// It is built from scratch rather than dressed onto the template strip. The template's
/// LEFT_BUTTON / RIGHT_BUTTON carry persistent inspector events, and obfuscation renames
/// the methods those events name by string - so a reused template button is dead in the
/// shipped build even though it looks wired in the editor. Both of this game's controls
/// take their behaviour from a lambda instead.
/// </summary>
public sealed class _0xa60e0b17 : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    public void _0x029f78dd(_0x9a4ef192 _0x7e3d646d, TMP_FontAsset _0x77a47c22, _0x3e5a25c6 _0x56df8dc8)
    {
        RectTransform _0xe0fdb0dd = this.GetComponent<RectTransform>();
        Image _0xe6e5c070 = _0xaefb2489.Plate(_0xe0fdb0dd, _0x658e656a._0xdb4baa7d(new byte[6] { 144, 173, 188, 154, 185, 170 }, 216), 0.5f, 0.9535f, 1180f, 210f, _0x7e3d646d.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.94f), 2.6f);
        _0xaefb2489.Plate(_0xe6e5c070.rectTransform, _0x658e656a._0xdb4baa7d(new byte[10] { 250, 199, 214, 240, 211, 192, 247, 214, 213, 215 }, 178), 0.5f, 0.045f, 1120f, 5f, _0x7e3d646d.Plate, _0x662d66c6.Fade(_0x662d66c6.Gold, 0.4f), 2f);
        this._0x7ecd8f04 = _0xaefb2489.Label(_0xe6e5c070.rectTransform, _0x658e656a._0xdb4baa7d(new byte[10] { 222, 227, 242, 213, 228, 243, 242, 255, 226, 229 }, 150), _0x658e656a._0xdb4baa7d(new byte[7] { 210, 210, 210, 210, 210, 210, 210 }, 226), 0.5f, 0.64f, 520f, 96f, 62f, _0x662d66c6.Gold, _0x77a47c22, TextAlignmentOptions.Center);
        _0xaefb2489.Label(_0xe6e5c070.rectTransform, _0x658e656a._0xdb4baa7d(new byte[17] { 202, 247, 230, 193, 240, 231, 230, 235, 246, 241, 193, 227, 242, 246, 235, 237, 236 }, 130), _0x658e656a._0xdb4baa7d(new byte[7] { 151, 134, 145, 144, 157, 128, 135 }, 212), 0.5f, 0.26f, 400f, 52f, 26f, _0x662d66c6.TextMuted, _0x77a47c22, TextAlignmentOptions.Center);
        _0xaefb2489.IconCta(_0xe6e5c070.rectTransform, _0x658e656a._0xdb4baa7d(new byte[7] { 80, 109, 124, 90, 121, 123, 115 }, 24), 0.08f, 0.5f, 130f, _0x7e3d646d.ButtonRound, _0x7e3d646d.IconBack, Color.white, _0x662d66c6.Cream, () => _0x5b07c2df.Instance._0xac2de253(_0x7d9c5f21._0x4c653446.SCENE_0));
        _0xaefb2489.IconCta(_0xe6e5c070.rectTransform, _0x658e656a._0xdb4baa7d(new byte[8] { 6, 59, 42, 30, 47, 59, 61, 43 }, 78), 0.92f, 0.5f, 130f, _0x7e3d646d.ButtonRound, _0x7e3d646d.IconPause, Color.white, _0x662d66c6.Cream, () => _0x56df8dc8._0xe24586b2());
        this._0xa021f867 = _0xaefb2489.Label(_0xe0fdb0dd, _0x658e656a._0xdb4baa7d(new byte[14] { 106, 87, 70, 113, 86, 77, 82, 97, 77, 87, 76, 86, 71, 80 }, 34), _0x658e656a._0xdb4baa7d(new byte[11] { 92, 91, 64, 95, 47, 62, 47, 32, 47, 62, 55 }, 15), 0.5f, 0.905f, 700f, 56f, 34f, _0x662d66c6.Cream, _0x77a47c22, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0xa021f867;
    public void _0xacf3b79e(int _0xa03b3903, int _0xa4afd1e1)
    {
        if (this._0xa021f867 != null)
        {
            this._0xa021f867.text = _0x658e656a._0xdb4baa7d(new byte[5] { 44, 43, 48, 47, 95 }, 127) + _0xa03b3903 + _0x658e656a._0xdb4baa7d(new byte[3] { 60, 51, 60 }, 28) + _0xa4afd1e1;
        }
    }

    public void _0x251a860f(int _0x88f58370)
    {
        this._0x259bde66 = _0x88f58370;
        if (this._0x7ecd8f04 != null)
        {
            this._0x7ecd8f04.text = _0xf4914d3b.Money(_0x88f58370);
        }
    }

    private int _0x259bde66;
    private TextMeshProUGUI _0x7ecd8f04;
    /// <summary>Where the coin trail flies to, in this canvas's own space.</summary>
    public RectTransform _0xe965ac57
    {
        get
        {
            return this._0x7ecd8f04 != null ? this._0x7ecd8f04.rectTransform : this.GetComponent<RectTransform>();
        }
    }

    private void _0x737ce25f(int _0xae4db9a0, int _0x667a31b2, float _0x7942a925)
    {
        if (this._0x7ecd8f04 == null)
        {
            return;
        }

        int _0x9c3648d0 = (int)Mathf.Lerp(_0xae4db9a0, _0x667a31b2, _0x7942a925);
        this._0x7ecd8f04.text = _0xf4914d3b.Money(_0x9c3648d0);
    }

    /// <summary>Counts the readout up to a new total and pulses it, so a win is felt.</summary>
    public void _0x1ce46e4e(int _0x0441f2b2)
    {
        if (this._0x7ecd8f04 == null)
        {
            this._0x259bde66 = _0x0441f2b2;
            return;
        }

        int _0x87aff8fd = this._0x259bde66;
        this._0x259bde66 = _0x0441f2b2;
        DOTween.To(() => 0f, _0xaee54441 => this._0x737ce25f(_0x87aff8fd, _0x0441f2b2, _0xaee54441), 1f, _0x7d178cbc.Scaled(_0x7d178cbc.CountUp)).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        this._0x7ecd8f04.rectTransform.DOPunchScale(new Vector3(0.06f, 0.06f, 0f), _0x7d178cbc.Scaled(0.3f), 6, 0.8f).SetLink(this.gameObject);
    }
}

internal static class _0x658e656a
{
    internal static string _0xdb4baa7d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}