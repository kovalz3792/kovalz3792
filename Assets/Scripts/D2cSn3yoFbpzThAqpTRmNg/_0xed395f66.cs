using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The lobby. It carries the credit rail, a preview of the route about to be driven, the
/// primary call to action and two rows of navigation chips.
///
/// It draws NO scrim, which is what makes it read as a different screen from both the
/// splash and every sheet - all of those wash the same background down. The primary CTA is
/// the template Play slot, a sibling of this view, so nothing here is placed in its band.
/// </summary>
public sealed class _0xed395f66 : MonoBehaviour
{
    private Color _0xdb42a714(int _0x8ec77a72)
    {
        if (_0x8ec77a72 == _0xf7978a15.KindBadge)
        {
            return _0x662d66c6.CobaltGlow;
        }

        if (_0x8ec77a72 == _0xf7978a15.KindGift)
        {
            return _0x662d66c6.SignGreen;
        }

        if (_0x8ec77a72 == _0xf7978a15.KindDetour)
        {
            return _0x662d66c6.SunsetOrange;
        }

        return _0x662d66c6.Gold;
    }

    private TextMeshProUGUI _0xe8f50028;
    private Button _0x8e3ef1e4(RectTransform _0x5fb3b113, _0x9a4ef192 _0xb4e497cd, TMP_FontAsset _0x7906c4b9, string _0x874a9c17, float _0x00987552, float _0xa0454afa, float _0xaff0a01b, float _0xeb4e6038, float _0xefe38e1c, string _0xd86690f8, UnityEngine.Events.UnityAction _0x13a47a6a)
    {
        return _0xaefb2489.Cta(_0x5fb3b113, _0x874a9c17, _0x00987552, _0xa0454afa, _0xaff0a01b, _0xeb4e6038, _0xb4e497cd.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.96f), _0xd86690f8, _0xefe38e1c, _0x662d66c6.Cream, _0x7906c4b9, _0x13a47a6a);
    }

    private void _0x999fc555(RectTransform _0x252d2ad5, _0x9a4ef192 _0xa0f808b1, TMP_FontAsset _0xea975aa4, _0xda5171dd _0x60b43c92)
    {
        Image _0x83c6de36 = _0xaefb2489.Plate(_0x252d2ad5, _0xf0059c10._0x35683b7b(new byte[14] { 129, 162, 175, 175, 180, 159, 162, 184, 185, 168, 142, 172, 191, 169 }, 205), 0.5f, 0.60f, 1060f, 720f, _0xa0f808b1.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.94f), 2.4f);
        RectTransform _0xa4ab51fa = _0x83c6de36.rectTransform;
        _0x3394b55a _0x81bb5792 = _0x60b43c92._0x7b4794ef;
        _0xaefb2489.Label(_0xa4ab51fa, _0xf0059c10._0x35683b7b(new byte[14] { 133, 166, 171, 171, 176, 155, 166, 188, 189, 172, 135, 168, 164, 172 }, 201), _0x81bb5792.SignName, 0.5f, 0.855f, 900f, 92f, 48f, _0x662d66c6.Gold, _0xea975aa4, TextAlignmentOptions.Center);
        RectTransform _0x482c83c8 = _0xaefb2489.Node(_0xa4ab51fa, _0xf0059c10._0x35683b7b(new byte[13] { 213, 246, 251, 251, 224, 202, 237, 246, 233, 201, 240, 233, 234 }, 153), 0.5f, 0.62f, 960f, 56f);
        int _0x07a76de9 = _0x81bb5792._0xe7956500 < 18 ? _0x81bb5792._0xe7956500 : 18;
        float _0x1e7ba99f = 960f / _0x07a76de9;
        for (int _0xab6ba86a = 0; _0xab6ba86a < _0x07a76de9; _0xab6ba86a++)
        {
            float _0x34b04070 = (_0xab6ba86a + 0.5f) / _0x07a76de9;
            Image _0x1c4702d3 = _0xaefb2489.Plate(_0x482c83c8, _0xf0059c10._0x35683b7b(new byte[7] { 15, 40, 51, 44, 12, 53, 44 }, 92), _0x34b04070, 0.5f, _0x1e7ba99f - 14f, 34f, _0xa0f808b1.Plate, _0x662d66c6.Fade(this._0xdb42a714(_0x81bb5792.Stops[_0xab6ba86a].Kind), 0.2f), 1.6f);
            _0x1c4702d3.DOFade(1f, 0.25f).SetDelay(0.03f * _0xab6ba86a).SetLink(_0x1c4702d3.gameObject);
        }

        _0xaefb2489.Picture(_0xa4ab51fa, _0xf0059c10._0x35683b7b(new byte[13] { 65, 98, 111, 111, 116, 95, 98, 120, 121, 104, 76, 127, 121 }, 13), 0.20f, 0.33f, 300f, 300f, _0xa0f808b1._0x7e4623dc(0), Color.white);
        _0xaefb2489.Label(_0xa4ab51fa, _0xf0059c10._0x35683b7b(new byte[15] { 182, 149, 152, 152, 131, 168, 149, 143, 142, 159, 169, 142, 149, 138, 137 }, 250), _0x81bb5792._0xe7956500 + _0xf0059c10._0x35683b7b(new byte[6] { 24, 107, 108, 119, 104, 107 }, 56), 0.655f, 0.44f, 560f, 64f, 34f, _0x662d66c6.Cream, _0xea975aa4, TextAlignmentOptions.Left);
        _0xaefb2489.Label(_0xa4ab51fa, _0xf0059c10._0x35683b7b(new byte[17] { 146, 177, 188, 188, 167, 140, 177, 171, 170, 187, 141, 167, 179, 188, 177, 178, 173 }, 222), _0xf0059c10._0x35683b7b(new byte[14] { 141, 152, 234, 247, 249, 252, 152, 235, 225, 245, 250, 247, 244, 235 }, 184), 0.655f, 0.32f, 560f, 64f, 34f, _0x662d66c6.Cream, _0xea975aa4, TextAlignmentOptions.Left);
        _0xaefb2489.Label(_0xa4ab51fa, _0xf0059c10._0x35683b7b(new byte[14] { 217, 250, 247, 247, 236, 199, 250, 224, 225, 240, 211, 231, 240, 240 }, 149), _0xf0059c10._0x35683b7b(new byte[17] { 78, 90, 77, 77, 40, 75, 90, 77, 76, 65, 92, 91, 40, 71, 70, 68, 81 }, 8), 0.655f, 0.20f, 560f, 64f, 30f, _0x662d66c6.TextMuted, _0xea975aa4, TextAlignmentOptions.Left);
        _0xa4ab51fa.anchoredPosition = new Vector2(0f, -40f);
        _0xa4ab51fa.DOAnchorPosY(0f, _0x7d178cbc.Scaled(_0x7d178cbc.Card)).SetDelay(0.08f).SetEase(Ease.OutCubic).SetLink(_0x83c6de36.gameObject);
    }

    private void _0xbaecc7da(RectTransform _0xf138fb81, _0x9a4ef192 _0x6c68eda5, TMP_FontAsset _0xc111da20, _0xda5171dd _0xdc60dc01)
    {
        Button _0x64c2d3f6 = this._0x8e3ef1e4(_0xf138fb81, _0x6c68eda5, _0xc111da20, _0xf0059c10._0x35683b7b(new byte[11] { 144, 191, 168, 140, 177, 171, 170, 187, 147, 191, 174 }, 222), 0.21f, 0.205f, 330f, 112f, 36f, _0xf0059c10._0x35683b7b(new byte[9] { 216, 197, 223, 222, 207, 170, 199, 203, 218 }, 138), () => _0xdc60dc01.Show(_0xda5171dd.ViewRouteMap));
        Button _0xd4a5d9d6 = this._0x8e3ef1e4(_0xf138fb81, _0x6c68eda5, _0xc111da20, _0xf0059c10._0x35683b7b(new byte[12] { 25, 54, 33, 19, 54, 62, 59, 46, 16, 62, 49, 35 }, 87), 0.50f, 0.205f, 330f, 112f, 36f, _0xf0059c10._0x35683b7b(new byte[10] { 185, 188, 180, 177, 164, 221, 186, 180, 187, 169 }, 253), () => _0xdc60dc01.Show(_0xda5171dd.ViewDailyGift));
        this._0x8e3ef1e4(_0xf138fb81, _0x6c68eda5, _0xc111da20, _0xf0059c10._0x35683b7b(new byte[11] { 210, 253, 234, 209, 245, 239, 239, 245, 243, 242, 239 }, 156), 0.79f, 0.205f, 330f, 112f, 36f, _0xf0059c10._0x35683b7b(new byte[8] { 196, 192, 218, 218, 192, 198, 199, 218 }, 137), () => _0xdc60dc01.Show(_0xda5171dd.ViewMissions));
        this._0xb56f6a25 = _0xaefb2489.Plate(_0xd4a5d9d6.GetComponent<RectTransform>(), _0xf0059c10._0x35683b7b(new byte[10] { 175, 128, 151, 166, 136, 135, 149, 165, 142, 149 }, 225), 0.9f, 0.78f, 26f, 26f, _0x6c68eda5.Plate, _0x662d66c6.Gold, 0.6f);
        this._0x8e3ef1e4(_0xf138fb81, _0x6c68eda5, _0xc111da20, _0xf0059c10._0x35683b7b(new byte[8] { 65, 110, 121, 78, 99, 109, 122, 98 }, 15), 0.12f, 0.115f, 212f, 100f, 28f, _0xf0059c10._0x35683b7b(new byte[5] { 155, 150, 152, 143, 151 }, 218), () => _0xdc60dc01.Show(_0xda5171dd.ViewAlbum));
        this._0x8e3ef1e4(_0xf138fb81, _0x6c68eda5, _0xc111da20, _0xf0059c10._0x35683b7b(new byte[8] { 105, 70, 81, 99, 66, 68, 72, 85 }, 39), 0.31f, 0.115f, 212f, 100f, 28f, _0xf0059c10._0x35683b7b(new byte[5] { 241, 240, 246, 250, 231 }, 181), () => _0xdc60dc01.Show(_0xda5171dd.ViewDecor));
        this._0x8e3ef1e4(_0xf138fb81, _0x6c68eda5, _0xc111da20, _0xf0059c10._0x35683b7b(new byte[10] { 43, 4, 19, 53, 23, 10, 3, 12, 9, 0 }, 101), 0.50f, 0.115f, 212f, 100f, 28f, _0xf0059c10._0x35683b7b(new byte[7] { 244, 246, 235, 226, 237, 232, 225 }, 164), () => _0xdc60dc01.Show(_0xda5171dd.ViewProfile));
        this._0x8e3ef1e4(_0xf138fb81, _0x6c68eda5, _0xc111da20, _0xf0059c10._0x35683b7b(new byte[8] { 184, 151, 128, 164, 131, 154, 147, 133 }, 246), 0.69f, 0.115f, 212f, 100f, 28f, _0xf0059c10._0x35683b7b(new byte[5] { 136, 143, 150, 159, 137 }, 218), () => _0xdc60dc01.Show(_0xda5171dd.ViewRules));
        this._0x8e3ef1e4(_0xf138fb81, _0x6c68eda5, _0xc111da20, _0xf0059c10._0x35683b7b(new byte[11] { 238, 193, 214, 243, 197, 212, 212, 201, 206, 199, 211 }, 160), 0.88f, 0.115f, 212f, 100f, 28f, _0xf0059c10._0x35683b7b(new byte[8] { 205, 219, 202, 202, 215, 208, 217, 205 }, 158), () => _0xdc60dc01.Show(_0xda5171dd.ViewSettings));
        RectTransform _0x9295f75f = _0x64c2d3f6.GetComponent<RectTransform>();
        _0x9295f75f.localScale = new Vector3(0.92f, 0.92f, 1f);
        _0x9295f75f.DOScale(1f, _0x7d178cbc.Scaled(0.26f)).SetEase(Ease.OutBack).SetLink(_0x64c2d3f6.gameObject);
    }

    public void _0x3fa24e71(_0xda5171dd _0x141b04a8)
    {
        _0x9a4ef192 _0x68e53a48 = _0x141b04a8._0xd24f5652;
        TMP_FontAsset _0x032daf17 = _0x141b04a8._0x88e5de05;
        RectTransform _0x75ee04b8 = this.GetComponent<RectTransform>();
        // A wash over the lower third so the controls sit on contrast.
        _0xaefb2489.Plate(_0x75ee04b8, _0xf0059c10._0x35683b7b(new byte[15] { 241, 210, 223, 223, 196, 251, 210, 210, 201, 216, 207, 234, 220, 206, 213 }, 189), 0.5f, 0.19f, 1242f, 1022f, _0x68e53a48.Plate, _0x662d66c6.Fade(_0x662d66c6.Asphalt, 0.62f), 1f);
        this._0xd2332443(_0x75ee04b8, _0x68e53a48, _0x032daf17);
        this._0x999fc555(_0x75ee04b8, _0x68e53a48, _0x032daf17, _0x141b04a8);
        _0xaefb2489.Label(_0x75ee04b8, _0xf0059c10._0x35683b7b(new byte[9] { 217, 250, 247, 247, 236, 221, 252, 251, 225 }, 149), _0xf0059c10._0x35683b7b(new byte[26] { 123, 110, 127, 15, 110, 15, 124, 123, 96, 127, 15, 124, 102, 104, 97, 15, 123, 96, 15, 125, 96, 99, 99, 15, 102, 123 }, 47), 0.5f, 0.247f, 1000f, 48f, 28f, _0x662d66c6.TextMuted, _0x032daf17, TextAlignmentOptions.Center);
        this._0xbaecc7da(_0x75ee04b8, _0x68e53a48, _0x032daf17, _0x141b04a8);
        this._0x8755a153();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    private Image _0xb56f6a25;
    /// <summary>Re-reads the numbers another sheet may have changed.</summary>
    public void _0x8755a153()
    {
        if (this._0xe8f50028 != null)
        {
            this._0xe8f50028.text = _0xf4914d3b.Money(_0xf4914d3b._0x16e76d12);
        }

        if (this._0xb56f6a25 != null)
        {
            this._0xb56f6a25.gameObject.SetActive(_0x1e63d933.IsClaimable());
        }
    }

    private void _0xd2332443(RectTransform _0xd4c6cbc2, _0x9a4ef192 _0x5bcb431c, TMP_FontAsset _0xe3d5161b)
    {
        Image _0x6d0b1bf5 = _0xaefb2489.Plate(_0xd4c6cbc2, _0xf0059c10._0x35683b7b(new byte[15] { 190, 157, 144, 144, 139, 177, 128, 151, 150, 155, 134, 160, 147, 155, 158 }, 242), 0.5f, 0.905f, 1060f, 148f, _0x5bcb431c.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.95f), 2.6f);
        _0xaefb2489.Plate(_0x6d0b1bf5.rectTransform, _0xf0059c10._0x35683b7b(new byte[19] { 16, 51, 62, 62, 37, 31, 46, 57, 56, 53, 40, 14, 61, 53, 48, 25, 56, 59, 57 }, 92), 0.5f, 0.07f, 1000f, 5f, _0x5bcb431c.Plate, _0x662d66c6.Fade(_0x662d66c6.Gold, 0.45f), 2f);
        this._0xe8f50028 = _0xaefb2489.Label(_0x6d0b1bf5.rectTransform, _0xf0059c10._0x35683b7b(new byte[16] { 205, 238, 227, 227, 248, 194, 243, 228, 229, 232, 245, 215, 224, 237, 244, 228 }, 129), _0xf0059c10._0x35683b7b(new byte[1] { 66 }, 114), 0.30f, 0.5f, 480f, 92f, 62f, _0x662d66c6.Gold, _0xe3d5161b, TextAlignmentOptions.Left);
        _0xaefb2489.Label(_0x6d0b1bf5.rectTransform, _0xf0059c10._0x35683b7b(new byte[18] { 212, 247, 250, 250, 225, 219, 234, 253, 252, 241, 236, 219, 249, 232, 236, 241, 247, 246 }, 152), _0xf0059c10._0x35683b7b(new byte[17] { 87, 67, 84, 84, 49, 65, 93, 80, 72, 49, 82, 67, 84, 85, 88, 69, 66 }, 17), 0.78f, 0.5f, 420f, 56f, 28f, _0x662d66c6.TextMuted, _0xe3d5161b, TextAlignmentOptions.Right);
        _0x6d0b1bf5.rectTransform.anchoredPosition = new Vector2(0f, 40f);
        _0x6d0b1bf5.rectTransform.DOAnchorPosY(0f, _0x7d178cbc.Scaled(0.3f)).SetEase(Ease.OutCubic).SetLink(_0x6d0b1bf5.gameObject);
    }
}

internal static class _0xf0059c10
{
    internal static string _0x35683b7b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}