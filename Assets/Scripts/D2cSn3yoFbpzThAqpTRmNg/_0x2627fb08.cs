using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three rows, and every one of them really changes something.
///
/// There is deliberately NO sound row: this build ships without audio, so a speaker, a
/// volume slider or a music toggle would be a control with nothing behind it (rule C.20).
/// There is no vibration row either - the template manifest declares no VIBRATE permission
/// and the manifest is not ours to edit, so that switch would be dead or worse.
/// </summary>
public sealed class _0x2627fb08 : MonoBehaviour
{
    public void _0xca23a713(_0xda5171dd _0x072cc58d)
    {
        this._0x3961269d = _0x072cc58d;
        this._0x36b3c869 = _0x072cc58d._0xd24f5652;
        this._0x52182b8b = _0x072cc58d._0x88e5de05;
        RectTransform _0x44c99248 = this.GetComponent<RectTransform>();
        _0xab5b90a8.Open(_0x44c99248, this._0x36b3c869, this._0x52182b8b, _0xfe1bb001._0x7ae3bce4(new byte[8] { 226, 244, 229, 229, 248, 255, 246, 226 }, 177), () => _0x072cc58d._0x13a54356());
        this._0x96b88998 = _0xaefb2489.Full(_0x44c99248, _0xfe1bb001._0x7ae3bce4(new byte[12] { 251, 205, 220, 220, 193, 198, 207, 219, 250, 199, 223, 219 }, 168));
        this._0x080e392c();
    }

    private void _0xd2078043()
    {
        if (this._0x403a3947 != null)
        {
            return;
        }

        this._0x403a3947 = _0xaefb2489.Full(this._0x96b88998, _0xfe1bb001._0x7ae3bce4(new byte[15] { 131, 181, 164, 164, 185, 190, 183, 163, 147, 191, 190, 182, 185, 162, 189 }, 208));
        _0xaefb2489.Scrim(this._0x403a3947, _0xfe1bb001._0x7ae3bce4(new byte[12] { 251, 215, 214, 222, 209, 202, 213, 235, 219, 202, 209, 213 }, 184), this._0x36b3c869.Solid, _0x662d66c6.Fade(_0x662d66c6.Asphalt, 0.9f));
        Image _0x4a38e659 = _0xaefb2489.Plate(this._0x403a3947, _0xfe1bb001._0x7ae3bce4(new byte[11] { 56, 20, 21, 29, 18, 9, 22, 56, 26, 9, 31 }, 123), 0.5f, 0.52f, 1000f, 540f, this._0x36b3c869.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.98f), 2.4f);
        _0xaefb2489.Label(_0x4a38e659.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[14] { 231, 203, 202, 194, 205, 214, 201, 236, 193, 197, 192, 205, 202, 195 }, 164), _0xfe1bb001._0x7ae3bce4(new byte[14] { 48, 39, 49, 39, 54, 66, 50, 48, 45, 37, 48, 39, 49, 49 }, 98), 0.5f, 0.78f, 900f, 76f, 44f, _0x662d66c6.Gold, this._0x52182b8b, TextAlignmentOptions.Center);
        _0xaefb2489.Label(_0x4a38e659.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[11] { 16, 60, 61, 53, 58, 33, 62, 17, 60, 55, 42 }, 83), _0xfe1bb001._0x7ae3bce4(new byte[62] { 145, 128, 151, 150, 155, 134, 129, 254, 242, 144, 147, 150, 149, 151, 129, 242, 147, 156, 150, 242, 159, 155, 129, 129, 155, 157, 156, 129, 216, 149, 157, 242, 144, 147, 145, 153, 242, 134, 157, 242, 134, 154, 151, 155, 128, 242, 129, 134, 147, 128, 134, 155, 156, 149, 242, 132, 147, 158, 135, 151, 129, 252 }, 210), 0.5f, 0.52f, 900f, 160f, 32f, _0x662d66c6.Cream, this._0x52182b8b, TextAlignmentOptions.Center);
        _0xaefb2489.Cta(_0x4a38e659.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[10] { 166, 138, 139, 131, 140, 151, 136, 188, 128, 150 }, 229), 0.3f, 0.2f, 420f, 130f, this._0x36b3c869.Plate, _0x662d66c6.Fade(_0x662d66c6.SignRed, 0.95f), _0xfe1bb001._0x7ae3bce4(new byte[9] { 108, 123, 109, 123, 106, 30, 112, 113, 105 }, 62), 34f, _0x662d66c6.Cream, this._0x52182b8b, () => this._0x4fb7fc51());
        _0xaefb2489.Cta(_0x4a38e659.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[9] { 230, 202, 203, 195, 204, 215, 200, 235, 202 }, 165), 0.7f, 0.2f, 420f, 130f, this._0x36b3c869.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f), _0xfe1bb001._0x7ae3bce4(new byte[7] { 230, 232, 232, 253, 141, 228, 249 }, 173), 34f, _0x662d66c6.Cream, this._0x52182b8b, () => this._0xdf025c99());
    }

    public void _0x080e392c()
    {
        if (this._0x96b88998 == null)
        {
            return;
        }

        for (int _0xc84f88a5 = this._0x96b88998.childCount - 1; _0xc84f88a5 >= 0; _0xc84f88a5--)
        {
            Destroy(this._0x96b88998.GetChild(_0xc84f88a5).gameObject);
        }

        this._0x403a3947 = null;
        this._0x7dc58094(0.705f, _0xfe1bb001._0x7ae3bce4(new byte[13] { 207, 216, 217, 200, 222, 216, 189, 208, 210, 201, 212, 210, 211 }, 157), _0xf4914d3b._0x570a1891, true);
        this._0x7dc58094(0.595f, _0xfe1bb001._0x7ae3bce4(new byte[18] { 224, 225, 239, 224, 136, 235, 231, 230, 252, 250, 233, 251, 252, 136, 252, 237, 240, 252 }, 168), _0xf4914d3b._0x646fff08, false);
        Image _0x6e45cb67 = _0xaefb2489.Plate(this._0x96b88998, _0xfe1bb001._0x7ae3bce4(new byte[16] { 17, 39, 54, 54, 43, 44, 37, 49, 16, 39, 49, 39, 54, 16, 45, 53 }, 66), 0.5f, 0.485f, 1060f, 160f, this._0x36b3c869.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltCard, 0.95f), 2.4f);
        _0xaefb2489.Label(_0x6e45cb67.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[18] { 242, 196, 213, 213, 200, 207, 198, 210, 243, 196, 210, 196, 213, 237, 192, 195, 196, 205 }, 161), _0xfe1bb001._0x7ae3bce4(new byte[14] { 122, 109, 123, 109, 124, 8, 120, 122, 103, 111, 122, 109, 123, 123 }, 40), 0.33f, 0.5f, 560f, 70f, 38f, _0x662d66c6.Cream, this._0x52182b8b, TextAlignmentOptions.Left);
        _0xaefb2489.Cta(_0x6e45cb67.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[19] { 238, 216, 201, 201, 212, 211, 218, 206, 239, 216, 206, 216, 201, 255, 200, 201, 201, 210, 211 }, 189), 0.805f, 0.5f, 300f, 96f, this._0x36b3c869.Plate, _0x662d66c6.Fade(_0x662d66c6.SignRed, 0.9f), _0xfe1bb001._0x7ae3bce4(new byte[5] { 17, 6, 16, 6, 23 }, 67), 32f, _0x662d66c6.Cream, this._0x52182b8b, () => this._0xd2078043());
        _0xaefb2489.Label(this._0x96b88998, _0xfe1bb001._0x7ae3bce4(new byte[12] { 236, 218, 203, 203, 214, 209, 216, 204, 241, 208, 203, 218 }, 191), _0xfe1bb001._0x7ae3bce4(new byte[76] { 189, 188, 178, 189, 213, 182, 186, 187, 161, 167, 180, 166, 161, 213, 183, 167, 188, 178, 189, 161, 176, 187, 166, 213, 176, 163, 176, 167, 172, 213, 185, 180, 183, 176, 185, 219, 255, 167, 176, 177, 160, 182, 176, 213, 184, 186, 161, 188, 186, 187, 213, 166, 189, 186, 167, 161, 176, 187, 166, 213, 176, 163, 176, 167, 172, 213, 180, 187, 188, 184, 180, 161, 188, 186, 187, 219 }, 245), 0.5f, 0.355f, 1040f, 120f, 28f, _0x662d66c6.TextMuted, this._0x52182b8b, TextAlignmentOptions.Center);
    }

    private RectTransform _0x403a3947;
    private TMP_FontAsset _0x52182b8b;
    private void _0xc41319e4(bool _0x6af15525)
    {
        if (_0x6af15525)
        {
            _0xf4914d3b._0x570a1891 = !_0xf4914d3b._0x570a1891;
        }
        else
        {
            _0xf4914d3b._0x646fff08 = !_0xf4914d3b._0x646fff08;
            _0x9ba1c2ee.Apply(this.transform.root);
        }

        this._0x080e392c();
    }

    private void _0x7dc58094(float _0x04eb1e90, string _0xd09ea2f6, bool _0x40e5785f, bool _0xc3fd77e6)
    {
        Image _0x9a9d58d2 = _0xaefb2489.Plate(this._0x96b88998, _0xfe1bb001._0x7ae3bce4(new byte[11] { 155, 173, 188, 188, 161, 166, 175, 187, 154, 167, 191 }, 200), 0.5f, _0x04eb1e90, 1060f, 160f, this._0x36b3c869.Plate, _0x662d66c6.Fade(_0x40e5785f ? _0x662d66c6.TarWarm : _0x662d66c6.AsphaltCard, 0.95f), 2.4f);
        _0xaefb2489.Label(_0x9a9d58d2.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[16] { 166, 144, 129, 129, 156, 155, 146, 134, 167, 154, 130, 185, 148, 151, 144, 153 }, 245), _0xd09ea2f6, 0.33f, 0.5f, 560f, 70f, 38f, _0x40e5785f ? _0x662d66c6.Gold : _0x662d66c6.Cream, this._0x52182b8b, TextAlignmentOptions.Left);
        Image _0xed16c26f = _0xaefb2489.Plate(_0x9a9d58d2.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[14] { 223, 233, 248, 248, 229, 226, 235, 255, 216, 227, 235, 235, 224, 233 }, 140), 0.835f, 0.5f, 120f, 64f, this._0x36b3c869.Plate, _0x40e5785f ? _0x662d66c6.Gold : _0x662d66c6.Fade(_0x662d66c6.Asphalt, 0.9f), 0.9f);
        _0xaefb2489.Plate(_0xed16c26f.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[12] { 158, 168, 185, 185, 164, 163, 170, 190, 134, 163, 162, 175 }, 205), _0x40e5785f ? 0.72f : 0.28f, 0.5f, 52f, 52f, this._0x36b3c869.Plate, _0x40e5785f ? _0x662d66c6.Asphalt : _0x662d66c6.TextMuted, 0.6f);
        RectTransform _0x90b2ee61 = _0xaefb2489.Full(_0x9a9d58d2.rectTransform, _0xfe1bb001._0x7ae3bce4(new byte[14] { 238, 216, 201, 201, 212, 211, 218, 206, 239, 210, 202, 245, 212, 201 }, 189));
        Image _0x88988430 = _0x90b2ee61.gameObject.AddComponent<Image>();
        _0x88988430.color = new Color(1f, 1f, 1f, 0f);
        _0x88988430.raycastTarget = true;
        Button _0xced93ab5 = _0x90b2ee61.gameObject.AddComponent<Button>();
        _0xced93ab5.targetGraphic = _0x88988430;
        _0xced93ab5.onClick.AddListener(() => this._0xc41319e4(_0xc3fd77e6));
        _0x90b2ee61.gameObject.AddComponent<_0xccfd05ae>()._0x606fe1eb(_0x9a9d58d2.rectTransform);
    }

    private void _0x4fb7fc51()
    {
        _0xf4914d3b.ResetAll();
        this._0xdf025c99();
        this._0x3961269d.Show(_0xda5171dd.ViewLobby);
    }

    private RectTransform _0x96b88998;
    private _0x9a4ef192 _0x36b3c869;
    private void _0xdf025c99()
    {
        if (this._0x403a3947 != null)
        {
            Destroy(this._0x403a3947.gameObject);
            this._0x403a3947 = null;
        }
    }

    private _0xda5171dd _0x3961269d;
}

internal static class _0xfe1bb001
{
    internal static string _0x7ae3bce4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}