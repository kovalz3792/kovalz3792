using UnityEngine;

/// <summary>
/// The night-highway palette. Preset CASINO_GOLD with the brief's two accent overrides
/// (sunset orange, cobalt blue).
///
/// EVERY colour that ever reaches a TMP face is LIGHT on purpose: there is ONE font
/// material for the whole app and its outline is Asphalt, so a dark face would be painted
/// over by its own outline (rule C.14). Asphalt / AsphaltRaised / AsphaltCard / TarWarm are
/// SURFACE colours and must never be passed as a text colour.
///
/// Every value is a literal: a static field that reads another static field is reordered by
/// the obfuscator and can initialise to black (rule C.52).
/// </summary>
public static class _0x662d66c6
{
    // surfaces
    public static readonly Color Asphalt = new Color(0.043137f, 0.043137f, 0.058824f, 1f);
    public static readonly Color TextMuted = new Color(0.650980f, 0.635294f, 0.690196f, 1f);
    public static readonly Color SignRed = new Color(0.784314f, 0.270588f, 0.184314f, 1f);
    // accents
    public static readonly Color Gold = new Color(0.831373f, 0.686275f, 0.215686f, 1f);
    public static readonly Color SunsetOrange = new Color(0.949020f, 0.462745f, 0.168627f, 1f);
    public static readonly Color Cobalt = new Color(0.117647f, 0.309804f, 0.839216f, 1f);
    // text (all light - see the class note)
    public static readonly Color Cream = new Color(0.964706f, 0.933333f, 0.862745f, 1f);
    public static readonly Color TarWarm = new Color(0.117647f, 0.101961f, 0.078431f, 1f);
    public static readonly Color AsphaltRaised = new Color(0.078431f, 0.078431f, 0.094118f, 1f);
    public static readonly Color AsphaltCard = new Color(0.109804f, 0.109804f, 0.141176f, 1f);
    public static readonly Color GoldLight = new Color(0.960784f, 0.843137f, 0.478431f, 1f);
    public static readonly Color SignGreen = new Color(0.184314f, 0.627451f, 0.415686f, 1f);
    /// <summary>The same colour at another alpha. Used for scrims, washes and disabled states.</summary>
    public static Color Fade(Color _0x7ecc45b7, float _0x666c09bc)
    {
        return new Color(_0x7ecc45b7.r, _0x7ecc45b7.g, _0x7ecc45b7.b, _0x666c09bc);
    }

    public static readonly Color CobaltGlow = new Color(0.298039f, 0.525490f, 1f, 1f);
}