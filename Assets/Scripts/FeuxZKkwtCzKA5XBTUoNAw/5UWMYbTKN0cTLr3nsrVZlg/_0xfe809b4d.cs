using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xfe809b4d : MonoBehaviour
{
    private static Vector2 _0xc0ba7578 = Vector2.zero;
    private Canvas _0xdee68d04;
    private static void OrientationChanged()
    {
        _0xed9e2e87 = Screen.orientation;
        _0xc0ba7578.x = Screen.width;
        _0xc0ba7578.y = Screen.height;
        _0x8ada4255 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xb1010746.Invoke();
    }

    private static UnityEvent _0xb1010746 = new();
    private void Update()
    {
        if (_0x5b24cabf.Count == 0 || _0x5b24cabf[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xed9e2e87)
            OrientationChanged();
        if (Screen.safeArea != _0x8ada4255)
            SafeAreaChanged();
        if (Screen.width != _0xc0ba7578.x || Screen.height != _0xc0ba7578.y)
            ResolutionChanged();
    }

    private static void SafeAreaChanged()
    {
        _0x8ada4255 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private CanvasScaler _0x3dbcc899;
    private RectTransform _0x999ecedd;
    private RectTransform _0x203a5577;
    private void OnDestroy()
    {
        if (_0x5b24cabf != null && _0x5b24cabf.Contains(this))
            _0x5b24cabf.Remove(this);
    }

    private static readonly List<_0xfe809b4d> _0x5b24cabf = new();
    private static void ApplySafeAreaToAll()
    {
        for (int _0x419ea56a = 0; _0x419ea56a < _0x5b24cabf.Count; _0x419ea56a++)
            _0x5b24cabf[_0x419ea56a]._0xaed1a1f8();
    }

    private void Start()
    {
    }

    private static bool _0x40fdcefa;
    private static void ResolutionChanged()
    {
        _0xc0ba7578.x = Screen.width;
        _0xc0ba7578.y = Screen.height;
        _0x8ada4255 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xb1010746.Invoke();
    }

    private void Awake()
    {
        if (!_0x5b24cabf.Contains(this))
            _0x5b24cabf.Add(this);
        this._0xdee68d04 = this.GetComponent<Canvas>();
        this._0x3dbcc899 = this.GetComponent<CanvasScaler>();
        if (this._0x3dbcc899 != null)
            this._0x6f531a90 = this._0x3dbcc899.referenceResolution;
        this._0x203a5577 = this.GetComponent<RectTransform>();
        this._0x999ecedd = this.transform.Find(_0xaae85c51._0x93189d9a(new byte[8] { 66, 112, 119, 116, 80, 99, 116, 112 }, 17)) as RectTransform;
        if (!_0x40fdcefa)
        {
            _0xed9e2e87 = Screen.orientation;
            _0xc0ba7578.x = Screen.width;
            _0xc0ba7578.y = Screen.height;
            _0x8ada4255 = Screen.safeArea;
            _0x40fdcefa = true;
        }

        this._0xaed1a1f8();
    }

    private void _0xaed1a1f8()
    {
        if (this._0x999ecedd == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x5a84138a = Screen.safeArea;
        Vector2 _0xb375c308 = _0x5a84138a.position;
        Vector2 _0x14016409 = _0x5a84138a.position + _0x5a84138a.size;
        _0xb375c308.x /= screenWidth;
        _0xb375c308.y /= screenHeight;
        _0x14016409.x /= screenWidth;
        _0x14016409.y /= screenHeight;
        this._0x999ecedd.anchorMin = _0xb375c308;
        this._0x999ecedd.anchorMax = _0x14016409;
        this._0x999ecedd.offsetMin = Vector2.zero;
        this._0x999ecedd.offsetMax = Vector2.zero;
        if (this._0x3dbcc899 == null)
            return;
        Vector2 _0x4a984e03 = _0x14016409 - _0xb375c308;
        float _0xa559351e = 2f - _0x4a984e03.x;
        float _0x5dac2756 = 2f - _0x4a984e03.y;
        this._0x3dbcc899.referenceResolution = this._0x6f531a90 * new Vector2(_0xa559351e, _0x5dac2756);
    }

    private Vector2 _0x6f531a90;
    private static Rect _0x8ada4255 = Rect.zero;
    private static ScreenOrientation _0xed9e2e87 = ScreenOrientation.LandscapeLeft;
}

internal static class _0xaae85c51
{
    internal static string _0x93189d9a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}