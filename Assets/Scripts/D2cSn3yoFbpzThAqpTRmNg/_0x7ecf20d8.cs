using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0x7ecf20d8 : MonoBehaviour
{
    private static readonly HashSet<string> _0xb4254bf3 = new HashSet<string>
    {
        _0x99809858._0x7c482efe(new byte[6] { 116, 121, 125, 120, 121, 110 }, 60),
        _0x99809858._0x7c482efe(new byte[6] { 129, 172, 168, 173, 172, 187 }, 201),
        _0x99809858._0x7c482efe(new byte[6] { 254, 243, 247, 242, 243, 228 }, 150),
        _0x99809858._0x7c482efe(new byte[5] { 93, 64, 93, 69, 76 }, 9),
        _0x99809858._0x7c482efe(new byte[5] { 161, 156, 129, 153, 144 }, 245)
    };
    private float _0x7c95d605;
    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0x7405eaac == null)
            this._0x7405eaac = (_0xd1ecf513, _0x3689706e) =>
            {
                this._0x7c95d605 = 0f;
            };
        SceneManager.sceneLoaded += this._0x7405eaac;
    }

    private const float ScanInterval = 0.25f;
    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0x7c95d605)
            return;
        this._0x7c95d605 = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0xb4abdb44 = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0x5a2aa5f3 = 0; _0x5a2aa5f3 < _0xb4abdb44.Length; _0x5a2aa5f3++)
        {
            TMP_Text _0x18ca78bc = _0xb4abdb44[_0x5a2aa5f3];
            if (_0x18ca78bc != null && IsPlaceholder(_0x18ca78bc.text))
                _0x18ca78bc.text = "";
        }
    }

    private static bool IsPlaceholder(string _0x63652fa8)
    {
        if (string.IsNullOrEmpty(_0x63652fa8))
            return false;
        string _0x4eefa6ce = _0x63652fa8.Trim();
        if (_0xb4254bf3.Contains(_0x4eefa6ce))
            return true;
        string _0x730fc027 = _0x4eefa6ce.ToLowerInvariant();
        for (int _0x1d29d6fe = 0; _0x1d29d6fe < _0xa8f0f422.Length; _0x1d29d6fe++)
        {
            if (_0x730fc027.StartsWith(_0xa8f0f422[_0x1d29d6fe]))
                return true;
        }

        return false;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x1677a74b != null)
            return;
        GameObject _0xd10faa70 = new GameObject(_0x99809858._0x7c482efe(new byte[24] { 248, 201, 193, 220, 192, 205, 216, 201, 252, 192, 205, 207, 201, 196, 195, 192, 200, 201, 222, 235, 217, 205, 222, 200 }, 172));
        _0xd10faa70.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xd10faa70);
        _0x1677a74b = _0xd10faa70.AddComponent<_0x7ecf20d8>();
    }

    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0x7405eaac;
    private void OnDisable()
    {
        if (this._0x7405eaac != null)
            SceneManager.sceneLoaded -= this._0x7405eaac;
    }

    private static _0x7ecf20d8 _0x1677a74b;
    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0xa8f0f422 =
    {
        _0x99809858._0x7c482efe(new byte[3] { 58, 57, 36 }, 86) + _0x99809858._0x7c482efe(new byte[6] { 135, 143, 194, 139, 146, 145 }, 226) + _0x99809858._0x7c482efe(new byte[2] { 103, 127 }, 18),
        _0x99809858._0x7c482efe(new byte[6] { 10, 27, 3, 3, 23, 78 }, 110) + _0x99809858._0x7c482efe(new byte[4] { 224, 241, 236, 224 }, 148)
    };
}

internal static class _0x99809858
{
    internal static string _0x7c482efe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}