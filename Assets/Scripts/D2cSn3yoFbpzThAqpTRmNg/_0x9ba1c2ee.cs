using UnityEngine;

/// <summary>
/// What the HIGH CONTRAST TEXT setting actually does: it re-applies every label's tint from
/// the palette colour that label was created with, so the whole screen visibly brightens -
/// or goes back - the instant the row is tapped. Without this the toggle would only move a
/// knob, which rule C.7 counts as a dead control.
/// </summary>
public static class _0x9ba1c2ee
{
    public static void Apply(Transform _0x61e9c7c1)
    {
        if (_0x61e9c7c1 == null)
        {
            return;
        }

        _0xf81721df[] _0xb20099f5 = _0x61e9c7c1.GetComponentsInChildren<_0xf81721df>(true);
        for (int _0x6ff527c5 = 0; _0x6ff527c5 < _0xb20099f5.Length; _0x6ff527c5++)
        {
            _0xb20099f5[_0x6ff527c5]._0xd23d0f94();
        }
    }
}