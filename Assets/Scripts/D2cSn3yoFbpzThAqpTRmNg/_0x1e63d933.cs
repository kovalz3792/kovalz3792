using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The free daily crate. Claiming it confirms itself four ways at once - the crate punches,
/// the credit figure counts up, the heading changes and the button goes to its disabled
/// countdown state - because a button that only changes its own caption reads as broken
/// (rule C.7).
///
/// The clock is the local one. Nothing here is bought, and nothing can be cashed out.
/// </summary>
public sealed class _0x1e63d933 : MonoBehaviour
{
    private float _0xb1a81880;
    public const int GiftCredits = 500;
    private TextMeshProUGUI _0xccdfa803;
    private TextMeshProUGUI _0xe50e1cda;
    private void _0xc8db405a()
    {
        if (!IsClaimable())
        {
            return;
        }

        _0xf4914d3b._0xcc22e047 = System.DateTime.UtcNow.Ticks;
        _0xf4914d3b._0xecd6f2a5 = -1;
        _0x6ab3f9d5.EnsureToday();
        this._0x707e806d._0xfdf4460d(GiftCredits);
        if (this._0xe662e681 != null)
        {
            this._0xe662e681.rectTransform.DOPunchScale(new Vector3(0.14f, 0.14f, 0f), 0.45f, 8, 0.6f).SetLink(this._0xe662e681.gameObject);
        }

        this._0xf4e4f1e2();
    }

    public void _0x2f59dc52(_0xda5171dd _0xd43469d1)
    {
        this._0x707e806d = _0xd43469d1;
        _0x9a4ef192 _0x0ef56078 = _0xd43469d1._0xd24f5652;
        TMP_FontAsset _0xaf0e070f = _0xd43469d1._0x88e5de05;
        RectTransform _0x92fa5d3e = this.GetComponent<RectTransform>();
        _0xab5b90a8.Open(_0x92fa5d3e, _0x0ef56078, _0xaf0e070f, _0xaf009576._0x095991e2(new byte[10] { 130, 135, 143, 138, 159, 230, 129, 143, 128, 146 }, 198), () => _0xd43469d1._0x13a54356());
        this._0xe662e681 = _0xaefb2489.Picture(_0x92fa5d3e, _0xaf009576._0x095991e2(new byte[9] { 171, 133, 138, 152, 175, 158, 141, 152, 137 }, 236), 0.5f, 0.63f, 460f, 460f, _0x0ef56078._0x7e4623dc(4), Color.white);
        this._0xe662e681.rectTransform.DOAnchorPosY(10f, 1.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this.gameObject);
        this._0xccdfa803 = _0xaefb2489.Label(_0x92fa5d3e, _0xaf009576._0x095991e2(new byte[11] { 246, 216, 215, 197, 249, 212, 208, 213, 216, 223, 214 }, 177), _0xaf009576._0x095991e2(new byte[16] { 7, 26, 0, 1, 16, 117, 18, 28, 19, 1, 117, 7, 16, 20, 17, 12 }, 85), 0.5f, 0.46f, 1000f, 72f, 48f, _0x662d66c6.Gold, _0xaf0e070f, TextAlignmentOptions.Center);
        this._0xe50e1cda = _0xaefb2489.Label(_0x92fa5d3e, _0xaf009576._0x095991e2(new byte[13] { 173, 131, 140, 158, 169, 133, 159, 132, 158, 142, 133, 157, 132 }, 234), "", 0.5f, 0.395f, 900f, 96f, 72f, _0x662d66c6.Cream, _0xaf0e070f, TextAlignmentOptions.Center);
        this._0x8e7e306c = _0xaefb2489.Label(_0x92fa5d3e, _0xaf009576._0x095991e2(new byte[8] { 200, 230, 233, 251, 205, 224, 235, 246 }, 143), "", 0.5f, 0.335f, 1040f, 110f, 34f, _0x662d66c6.TextMuted, _0xaf0e070f, TextAlignmentOptions.Center);
        this._0xaff85db8 = _0xaefb2489.Cta(_0x92fa5d3e, _0xaf009576._0x095991e2(new byte[9] { 178, 156, 147, 129, 182, 153, 148, 156, 152 }, 245), 0.5f, 0.23f, 720f, 168f, _0x0ef56078.ButtonRect, Color.white, _0xaf009576._0x095991e2(new byte[10] { 202, 197, 200, 192, 196, 169, 206, 192, 207, 221 }, 137), 50f, _0x662d66c6.Cream, _0xaf0e070f, () => this._0xc8db405a());
        this._0xf4e4f1e2();
    }

    public static bool IsClaimable()
    {
        return System.DateTime.UtcNow.Ticks - _0xf4914d3b._0xcc22e047 >= DayTicks;
    }

    private const long DayTicks = 864000000000L;
    private Button _0xaff85db8;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    public void _0xf4e4f1e2()
    {
        bool _0x9dca487c = IsClaimable();
        if (this._0xccdfa803 != null)
        {
            this._0xccdfa803.text = _0x9dca487c ? _0xaf009576._0x095991e2(new byte[16] { 152, 133, 159, 158, 143, 234, 141, 131, 140, 158, 234, 152, 143, 139, 142, 147 }, 202) : _0xaf009576._0x095991e2(new byte[12] { 33, 42, 55, 59, 79, 40, 38, 41, 59, 79, 38, 33 }, 111);
        }

        if (this._0x8e7e306c != null)
        {
            this._0x8e7e306c.text = _0x9dca487c ? GiftCredits + _0xaf009576._0x095991e2(new byte[29] { 252, 154, 142, 153, 153, 252, 159, 142, 153, 152, 149, 136, 143, 252, 247, 252, 145, 149, 143, 143, 149, 147, 146, 252, 142, 153, 143, 153, 136 }, 220) : _0xaf009576._0x095991e2(new byte[40] { 5, 11, 4, 22, 17, 98, 3, 16, 7, 98, 4, 16, 7, 7, 98, 3, 12, 6, 98, 3, 16, 16, 11, 20, 7, 98, 7, 20, 7, 16, 27, 98, 112, 118, 98, 10, 13, 23, 16, 17 }, 66);
        }

        if (this._0xe50e1cda != null)
        {
            this._0xe50e1cda.text = _0x9dca487c ? "" : this._0x169951c1();
        }

        if (this._0xaff85db8 != null)
        {
            this._0xaff85db8.interactable = _0x9dca487c;
            _0xaefb2489.Tint(this._0xaff85db8, _0x9dca487c ? Color.white : _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.92f), _0x9dca487c ? _0x662d66c6.Cream : _0x662d66c6.TextMuted);
        }
    }

    private Image _0xe662e681;
    private string _0x169951c1()
    {
        long _0xee5d3e5c = DayTicks - (System.DateTime.UtcNow.Ticks - _0xf4914d3b._0xcc22e047);
        if (_0xee5d3e5c < 0)
        {
            _0xee5d3e5c = 0;
        }

        System.TimeSpan _0x4bfbee33 = System.TimeSpan.FromTicks(_0xee5d3e5c);
        return _0x4bfbee33.Hours.ToString(_0xaf009576._0x095991e2(new byte[2] { 38, 38 }, 22)) + _0xaf009576._0x095991e2(new byte[1] { 104 }, 82) + _0x4bfbee33.Minutes.ToString(_0xaf009576._0x095991e2(new byte[2] { 134, 134 }, 182)) + _0xaf009576._0x095991e2(new byte[1] { 42 }, 16) + _0x4bfbee33.Seconds.ToString(_0xaf009576._0x095991e2(new byte[2] { 245, 245 }, 197));
    }

    private void Update()
    {
        if (IsClaimable())
        {
            return;
        }

        this._0xb1a81880 += Time.unscaledDeltaTime;
        if (this._0xb1a81880 < 1f)
        {
            return;
        }

        this._0xb1a81880 = 0f;
        if (this._0xe50e1cda != null)
        {
            this._0xe50e1cda.text = this._0x169951c1();
        }
    }

    private _0xda5171dd _0x707e806d;
    private TextMeshProUGUI _0x8e7e306c;
}

internal static class _0xaf009576
{
    internal static string _0x095991e2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}