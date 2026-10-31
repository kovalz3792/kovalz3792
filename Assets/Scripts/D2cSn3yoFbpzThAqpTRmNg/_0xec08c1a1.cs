using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The three by three gantry sign the stops resolve on.
///
/// Child order is the whole point here and it is fixed: backdrop, then the FRAME, then the
/// window with the symbols, then the payline overlay. uGUI draws later siblings on top, and
/// generated frame art has an opaque centre, so a frame added after its content hides every
/// symbol behind a gold blank (rules C.13 and C.63).
///
/// The geometry is derived the way a tile board has to be, from the usable width minus the
/// frame on BOTH sides, so no cell can stick out past the rounded edge:
///     FRAME = 56 ; CELL = floor((1068 - 2*56) / 3) = 318 ; BOARD = 318*3 + 2*56 = 1066.
/// </summary>
public sealed class _0xec08c1a1 : MonoBehaviour
{
    private bool _0x2e595d44;
    private RectTransform _0x183bfa9b;
    public bool _0x4a5f39d8
    {
        get
        {
            return this._0x2e595d44;
        }
    }

    public const int BoardSize = WindowSize + Frame * 2;
    /// <summary>
    /// Pulses the cells that earned and strokes the lines they sit on. The overlay is the
    /// only thing in the gantry allowed above the symbols, and it is drawn at low alpha.
    /// </summary>
    public void _0x1976dbb2(_0x45fae2d6 _0x5f368db4)
    {
        this._0x2170d6c7();
        for (int _0x3d00c5e2 = 0; _0x3d00c5e2 < this._0xf4e164a4.Length; _0x3d00c5e2++)
        {
            if (this._0xf4e164a4[_0x3d00c5e2] == null || !_0x5f368db4.Winning[_0x3d00c5e2])
            {
                continue;
            }

            this._0xf4e164a4[_0x3d00c5e2].rectTransform.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), _0x7d178cbc.Scaled(0.35f), 7, 0.7f).SetLink(this._0xf4e164a4[_0x3d00c5e2].gameObject);
        }

        if (_0x5f368db4.LinesHit <= 0)
        {
            return;
        }

        for (int _0x1b3a2a22 = 0; _0x1b3a2a22 < _0xaa4ac3fa.Rows; _0x1b3a2a22++)
        {
            bool _0xe927f5ef = true;
            for (int _0x28b1ec3c = 0; _0x28b1ec3c < _0xaa4ac3fa.Columns; _0x28b1ec3c++)
            {
                _0xe927f5ef = _0xe927f5ef && _0x5f368db4.Winning[_0x1b3a2a22 * _0xaa4ac3fa.Columns + _0x28b1ec3c];
            }

            if (_0xe927f5ef)
            {
                float _0xec5600d6 = 1f - (_0x1b3a2a22 + 0.5f) / _0xaa4ac3fa.Rows;
                _0xaefb2489.Plate(this._0x183bfa9b, _0xfb8f259e._0xf05b9511(new byte[10] { 197, 244, 236, 249, 252, 251, 240, 199, 250, 226 }, 149), 0.5f, _0xec5600d6, WindowSize - 40f, 8f, this._0xfc197b79.Plate, _0x662d66c6.Fade(_0x662d66c6.GoldLight, 0.55f), 1.2f);
            }
        }

        if (_0x5f368db4.Winning[0] && _0x5f368db4.Winning[4] && _0x5f368db4.Winning[8])
        {
            this._0x5fdc1aa4(-45f);
        }

        if (_0x5f368db4.Winning[6] && _0x5f368db4.Winning[4] && _0x5f368db4.Winning[2])
        {
            this._0x5fdc1aa4(45f);
        }
    }

    public void _0x2170d6c7()
    {
        if (this._0x183bfa9b == null)
        {
            return;
        }

        for (int _0x56ba0a82 = this._0x183bfa9b.childCount - 1; _0x56ba0a82 >= 0; _0x56ba0a82--)
        {
            Destroy(this._0x183bfa9b.GetChild(_0x56ba0a82).gameObject);
        }
    }

    public const int Cell = 318;
    private void _0x5fdc1aa4(float _0x7a385dd8)
    {
        Image _0xab7d36dd = _0xaefb2489.Plate(this._0x183bfa9b, _0xfb8f259e._0xf05b9511(new byte[15] { 216, 233, 241, 228, 225, 230, 237, 204, 225, 233, 239, 231, 230, 233, 228 }, 136), 0.5f, 0.5f, WindowSize * 1.38f, 8f, this._0xfc197b79.Plate, _0x662d66c6.Fade(_0x662d66c6.GoldLight, 0.5f), 1.2f);
        _0xab7d36dd.rectTransform.localEulerAngles = new Vector3(0f, 0f, _0x7a385dd8);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    /// <summary>Puts a grid on screen with no animation.</summary>
    public void _0x2cbb9263(int[] _0x0f949501)
    {
        this._0x87532d9a = _0x0f949501;
        for (int _0x2076b3eb = 0; _0x2076b3eb < this._0xf4e164a4.Length; _0x2076b3eb++)
        {
            if (this._0xf4e164a4[_0x2076b3eb] != null)
            {
                this._0xf4e164a4[_0x2076b3eb].sprite = this._0xfc197b79._0x7e4623dc(_0x0f949501[_0x2076b3eb]);
                this._0xf4e164a4[_0x2076b3eb].color = Color.white;
                this._0xf4e164a4[_0x2076b3eb].rectTransform.localScale = Vector3.one;
            }
        }
    }

    private readonly RectTransform[] _0x04c2af0d = new RectTransform[_0xaa4ac3fa.Columns];
    /// <summary>World position of one cell, used as the start of a coin trail.</summary>
    public Vector3 _0x704c3508(int _0x775f2ac9)
    {
        if (_0x775f2ac9 < 0 || _0x775f2ac9 >= this._0xf4e164a4.Length || this._0xf4e164a4[_0x775f2ac9] == null)
        {
            return this.transform.position;
        }

        return this._0xf4e164a4[_0x775f2ac9].rectTransform.position;
    }

    /// <summary>Runs the three columns and lands them on `grid`. Columns start staggered.</summary>
    public void _0x7b01e40b(int[] _0x82862e52, System.Random _0xa7dae2e1)
    {
        this._0x2e595d44 = true;
        this._0x2170d6c7();
        for (int _0xf697aeb9 = 0; _0xf697aeb9 < _0xaa4ac3fa.Columns; _0xf697aeb9++)
        {
            this.StartCoroutine(this._0x9850738d(_0xf697aeb9, _0x82862e52, _0xa7dae2e1));
        }
    }

    private _0x9a4ef192 _0xfc197b79;
    public const int Frame = 56;
    public void _0x92898050(_0x9a4ef192 _0xa72fd6b2)
    {
        this._0xfc197b79 = _0xa72fd6b2;
        RectTransform _0x7e71e0e7 = this.GetComponent<RectTransform>();
        RectTransform _0x6dcdff74 = _0xaefb2489.Node(_0x7e71e0e7, _0xfb8f259e._0xf05b9511(new byte[10] { 175, 152, 152, 145, 186, 156, 147, 137, 143, 132 }, 253), 0.5f, 0.565f, BoardSize, BoardSize);
        _0xaefb2489.Plate(_0x6dcdff74, _0xfb8f259e._0xf05b9511(new byte[12] { 217, 238, 238, 231, 201, 234, 232, 224, 239, 249, 228, 251 }, 139), 0.5f, 0.5f, BoardSize, BoardSize, _0xa72fd6b2.Plate, _0x662d66c6.Fade(_0x662d66c6.Asphalt, 0.94f), 2.2f);
        // The frame is deliberately created BEFORE the window it frames.
        _0xaefb2489.Plate(_0x6dcdff74, _0xfb8f259e._0xf05b9511(new byte[9] { 108, 91, 91, 82, 120, 76, 95, 83, 91 }, 62), 0.5f, 0.5f, BoardSize, BoardSize, _0xa72fd6b2.Plate, _0x662d66c6.Fade(_0x662d66c6.Gold, 0.28f), 1.6f);
        RectTransform _0x4760ccca = _0xaefb2489.Node(_0x6dcdff74, _0xfb8f259e._0xf05b9511(new byte[10] { 99, 84, 84, 93, 102, 88, 95, 85, 94, 70 }, 49), 0.5f, 0.5f, WindowSize, WindowSize);
        for (int _0xa29934c0 = 0; _0xa29934c0 < _0xaa4ac3fa.Columns; _0xa29934c0++)
        {
            float _0xb7b942d3 = (_0xa29934c0 + 0.5f) / _0xaa4ac3fa.Columns;
            RectTransform _0xfbe3e0b4 = _0xaefb2489.Node(_0x4760ccca, _0xfb8f259e._0xf05b9511(new byte[10] { 208, 231, 231, 238, 193, 237, 238, 247, 239, 236 }, 130), _0xb7b942d3, 0.5f, Cell, WindowSize);
            this._0x04c2af0d[_0xa29934c0] = _0xfbe3e0b4;
            for (int _0xa84094f4 = 0; _0xa84094f4 < _0xaa4ac3fa.Rows; _0xa84094f4++)
            {
                float _0xb7140eec = 1f - (_0xa84094f4 + 0.5f) / _0xaa4ac3fa.Rows;
                Image _0xc6e1d89c = _0xaefb2489.Plate(_0xfbe3e0b4, _0xfb8f259e._0xf05b9511(new byte[8] { 217, 238, 238, 231, 200, 238, 231, 231 }, 139), 0.5f, _0xb7140eec, Cell - 14f, Cell - 14f, _0xa72fd6b2.Plate, _0x662d66c6.Fade(_0x662d66c6.AsphaltRaised, 0.9f), 2.2f);
                this._0xf4e164a4[_0xa84094f4 * _0xaa4ac3fa.Columns + _0xa29934c0] = _0xaefb2489.Picture(_0xc6e1d89c.rectTransform, _0xfb8f259e._0xf05b9511(new byte[10] { 74, 125, 125, 116, 75, 97, 117, 122, 119, 116 }, 24), 0.5f, 0.5f, 274f, 274f, _0xa72fd6b2._0x7e4623dc(0), Color.white);
            }
        }

        this._0x183bfa9b = _0xaefb2489.Node(_0x6dcdff74, _0xfb8f259e._0xf05b9511(new byte[14] { 51, 2, 26, 15, 10, 13, 6, 44, 21, 6, 17, 15, 2, 26 }, 99), 0.5f, 0.5f, WindowSize, WindowSize);
        this._0x2cbb9263(_0xaa4ac3fa.Spin(new System.Random(7919), 1));
    }

    private readonly Image[] _0xf4e164a4 = new Image[_0xaa4ac3fa.Columns * _0xaa4ac3fa.Rows];
    public const int WindowSize = Cell * _0xaa4ac3fa.Columns;
    private IEnumerator _0x9850738d(int _0x5f6efc8d, int[] _0x79c152a5, System.Random _0x19729704)
    {
        float _0x11bd6645 = _0x7d178cbc.Scaled(_0x7d178cbc.ReelStagger) * _0x5f6efc8d;
        if (_0x11bd6645 > 0f)
        {
            yield return new WaitForSeconds(_0x11bd6645);
        }

        RectTransform _0x74c50747 = this._0x04c2af0d[_0x5f6efc8d];
        float _0xb9ace8b1 = _0x7d178cbc.Scaled(_0x7d178cbc.ReelColumn);
        float _0x7a976fd8 = 0f;
        while (_0x7a976fd8 < _0xb9ace8b1)
        {
            for (int _0x8b67a31b = 0; _0x8b67a31b < _0xaa4ac3fa.Rows; _0x8b67a31b++)
            {
                Image _0xd03afff3 = this._0xf4e164a4[_0x8b67a31b * _0xaa4ac3fa.Columns + _0x5f6efc8d];
                if (_0xd03afff3 != null)
                {
                    _0xd03afff3.sprite = this._0xfc197b79._0x7e4623dc(_0x19729704.Next(0, _0xaa4ac3fa.SymbolCount));
                    _0xd03afff3.preserveAspect = true;
                }
            }

            if (_0x74c50747 != null)
            {
                _0x74c50747.anchoredPosition = new Vector2(0f, _0x7a976fd8 % 0.14f < 0.07f ? -18f : 18f);
            }

            _0x7a976fd8 += 0.07f;
            yield return new WaitForSeconds(0.07f);
        }

        for (int _0xd91a6e12 = 0; _0xd91a6e12 < _0xaa4ac3fa.Rows; _0xd91a6e12++)
        {
            int _0x04067691 = _0xd91a6e12 * _0xaa4ac3fa.Columns + _0x5f6efc8d;
            Image _0x0d6da661 = this._0xf4e164a4[_0x04067691];
            if (_0x0d6da661 != null)
            {
                _0x0d6da661.sprite = this._0xfc197b79._0x7e4623dc(_0x79c152a5[_0x04067691]);
                _0x0d6da661.preserveAspect = true;
            }
        }

        if (_0x74c50747 != null)
        {
            _0x74c50747.anchoredPosition = new Vector2(0f, -40f);
            _0x74c50747.DOAnchorPosY(0f, 0.3f).SetEase(Ease.OutBack, 1f + _0x7d178cbc.ReelOvershoot).SetLink(_0x74c50747.gameObject);
        }

        if (_0x5f6efc8d == _0xaa4ac3fa.Columns - 1)
        {
            this._0x87532d9a = _0x79c152a5;
            this._0x2e595d44 = false;
        }
    }

    private int[] _0x87532d9a = new int[_0xaa4ac3fa.Columns * _0xaa4ac3fa.Rows];
    public float _0x99d8bf06()
    {
        return _0x7d178cbc.Scaled(_0x7d178cbc.ReelStagger * (_0xaa4ac3fa.Columns - 1) + _0x7d178cbc.ReelColumn + 0.2f);
    }

    public int[] _0x3194be3e
    {
        get
        {
            return this._0x87532d9a;
        }
    }
}

internal static class _0xfb8f259e
{
    internal static string _0xf05b9511(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}