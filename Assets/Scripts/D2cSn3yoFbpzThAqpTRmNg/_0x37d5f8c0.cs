using TMPro;
using UnityEngine;

/// <summary>
/// Every TMP label this game creates goes through here.
///
/// Three rules live in one place so they cannot drift apart:
///  * C.10 - word wrapping OFF, line breaks only where the author put them, autosize ALWAYS
///    on with the readability floor as its minimum. Autosize stays on for counters and
///    timers too: predictable layout outranks the CPU note in the TMP skill.
///  * C.65 - a label created under an INACTIVE parent has not run Awake, so reading
///    fontMaterial THROWS instead of returning null. The font and shared material are given
///    to the label before anything asks it for a material instance.
///  * C.14 - the shared outline is dark, so every face colour callers pass is light.
/// </summary>
public static class _0x37d5f8c0
{
    public static void Apply(TMP_Text _0x94f62935, TMP_FontAsset _0x59ed169f, float _0xa8de7a38)
    {
        if (_0x94f62935 == null)
        {
            return;
        }

        if (_0x94f62935.font == null)
        {
            _0x94f62935.font = _0x59ed169f != null ? _0x59ed169f : TMP_Settings.defaultFontAsset;
        }

        if (_0x94f62935.font != null && _0x94f62935.fontSharedMaterial == null)
        {
            _0x94f62935.fontSharedMaterial = _0x94f62935.font.material;
        }

        _0x94f62935.textWrappingMode = TextWrappingModes.NoWrap;
        _0x94f62935.overflowMode = TextOverflowModes.Overflow;
        _0x94f62935.enableAutoSizing = true;
        _0x94f62935.fontSizeMin = 24f;
        _0x94f62935.fontSizeMax = _0xa8de7a38 < 24f ? 24f : _0xa8de7a38;
        _0x94f62935.fontSize = _0x94f62935.fontSizeMax;
        _0x94f62935.richText = false;
    }

    /// <summary>
    /// Sets a multi-line string. A real newline cannot be AUTHORED into a scene m_text
    /// value (it ends the YAML scalar and corrupts the document), so every line break in
    /// this game is placed from code, here.
    /// </summary>
    public static void SetLines(TMP_Text _0x7a6c1178, string _0x1af2b5f2)
    {
        if (_0x7a6c1178 != null)
        {
            _0x7a6c1178.text = _0x1af2b5f2;
        }
    }
}