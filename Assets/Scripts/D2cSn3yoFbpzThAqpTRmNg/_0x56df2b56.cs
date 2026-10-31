using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x56df2b56 : MonoBehaviour
{
    private readonly HashSet<TMP_Text> _0x8b9819c0 = new HashSet<TMP_Text>();
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x1425e6da;
    private const float MinOutlineWidth = 0.01f;
    private readonly List<TMP_Text> _0x1ea7797d = new List<TMP_Text>();
    private const float MinRatio = 4.5f;
    private static float Ratio(Color _0xb6117b35, Color _0xa4a334a2)
    {
        float _0xf087f1ab = Luminance(_0xb6117b35);
        float _0x9d94fcab = Luminance(_0xa4a334a2);
        return (Mathf.Max(_0xf087f1ab, _0x9d94fcab) + 0.05f) / (Mathf.Min(_0xf087f1ab, _0x9d94fcab) + 0.05f);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xbd8ca7bd)
    {
        return 0.2126f * Linear(_0xbd8ca7bd.r) + 0.7152f * Linear(_0xbd8ca7bd.g) + 0.0722f * Linear(_0xbd8ca7bd.b);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xc979323a != null)
            return;
        GameObject _0x89404839 = new GameObject(_0xb36f8899._0x9ec0d3af(new byte[16] { 217, 224, 253, 206, 226, 227, 249, 255, 236, 254, 249, 202, 248, 236, 255, 233 }, 141));
        _0x89404839.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x89404839);
        _0xc979323a = _0x89404839.AddComponent<_0x56df2b56>();
    }

    private static void Fix(TMP_Text _0x3aeedef2)
    {
        if (_0x3aeedef2 == null || !_0x3aeedef2.isActiveAndEnabled)
            return;
        Material _0x5078f3e6 = _0x3aeedef2.fontSharedMaterial;
        if (_0x5078f3e6 == null || !_0x5078f3e6.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x5078f3e6.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x5078f3e6.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xbccec515 = _0x3aeedef2.color;
        if (_0xbccec515.a <= 0f)
            return;
        Color _0xbdbb8316 = _0x5078f3e6.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xbccec515, _0xbdbb8316) >= MinRatio)
            return;
        Color _0x0e05ab2b = Luminance(_0xbdbb8316) < 0.5f ? Color.white : Color.black;
        Color _0x45702fe6;
        if (Ratio(_0x0e05ab2b, _0xbdbb8316) < TargetRatio)
        {
            _0x45702fe6 = _0x0e05ab2b;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xc5344cb8 = 0f;
            float _0x32c9bd3b = 1f;
            for (int _0x8b2bc159 = 0; _0x8b2bc159 < 20; _0x8b2bc159++)
            {
                float _0x3a218ac5 = (_0xc5344cb8 + _0x32c9bd3b) * 0.5f;
                if (Ratio(Color.Lerp(_0xbccec515, _0x0e05ab2b, _0x3a218ac5), _0xbdbb8316) >= TargetRatio)
                    _0x32c9bd3b = _0x3a218ac5;
                else
                    _0xc5344cb8 = _0x3a218ac5;
            }

            _0x45702fe6 = Color.Lerp(_0xbccec515, _0x0e05ab2b, _0x32c9bd3b);
        }

        _0x45702fe6.a = _0xbccec515.a;
        _0x3aeedef2.color = _0x45702fe6;
    }

    private static float Linear(float _0xb2c2929f)
    {
        _0xb2c2929f = Mathf.Clamp01(_0xb2c2929f);
        return _0xb2c2929f <= 0.03928f ? _0xb2c2929f / 12.92f : Mathf.Pow((_0xb2c2929f + 0.055f) / 1.055f, 2.4f);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xbf7110dd(Object _0x352a6df6)
    {
        TMP_Text _0xf9e260e2 = _0x352a6df6 as TMP_Text;
        if (_0xf9e260e2 != null)
            this._0x8b9819c0.Add(_0xf9e260e2);
    }

    private void LateUpdate()
    {
        if (this._0x8b9819c0.Count == 0)
            return;
        this._0x1ea7797d.Clear();
        this._0x1ea7797d.AddRange(this._0x8b9819c0);
        this._0x8b9819c0.Clear();
        for (int _0x0f2467fd = 0; _0x0f2467fd < this._0x1ea7797d.Count; _0x0f2467fd++)
            Fix(this._0x1ea7797d[_0x0f2467fd]);
    }

    private void OnDisable()
    {
        if (this._0x1425e6da != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x1425e6da);
    }

    private static _0x56df2b56 _0xc979323a;
    private const float TargetRatio = 7f;
    private void OnEnable()
    {
        if (this._0x1425e6da == null)
            this._0x1425e6da = _0xa091c0ee => this._0xbf7110dd(_0xa091c0ee);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x1425e6da);
    }
}

internal static class _0xb36f8899
{
    internal static string _0x9ec0d3af(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}