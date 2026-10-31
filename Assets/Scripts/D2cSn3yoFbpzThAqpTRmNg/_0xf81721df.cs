using TMPro;
using UnityEngine;

/// <summary>
/// Remembers the palette colour a label was created with, so the HIGH CONTRAST TEXT
/// setting can be applied and UNapplied without the colour drifting a little further
/// towards white every time it is toggled.
///
/// Nothing is ever darkened: the single font material outlines every glyph in Asphalt, so
/// a dark face would be painted over by its own outline (rule C.14).
/// </summary>
public sealed class _0xf81721df : MonoBehaviour
{
    private Color _0xf05492a9 = Color.white;
    public void _0xd23d0f94()
    {
        if (this._0x9f493e16 == null)
        {
            return;
        }

        if (!_0xf4914d3b._0x646fff08)
        {
            this._0x9f493e16.color = this._0xf05492a9;
            return;
        }

        this._0x9f493e16.color = new Color(this._0xf05492a9.r + (1f - this._0xf05492a9.r) * Lift, this._0xf05492a9.g + (1f - this._0xf05492a9.g) * Lift, this._0xf05492a9.b + (1f - this._0xf05492a9.b) * Lift, this._0xf05492a9.a);
    }

    public const float Lift = 0.55f;
    public _0xf81721df _0x52b80235(TMP_Text _0x47934e3a, Color _0x5f56c159)
    {
        this._0x9f493e16 = _0x47934e3a;
        this._0xf05492a9 = _0x5f56c159;
        this._0xd23d0f94();
        return this;
    }

    private TMP_Text _0x9f493e16;
}