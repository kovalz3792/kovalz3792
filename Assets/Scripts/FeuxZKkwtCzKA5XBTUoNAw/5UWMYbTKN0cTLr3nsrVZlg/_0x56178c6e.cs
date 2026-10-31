using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x56178c6e : MonoBehaviour
{
    private void _0xd61084d1()
    {
        if (this._0xa4db7efb == null)
            return;
        Rect _0xf016d05e = Screen.safeArea;
        Vector2 _0x31cd7f97 = _0xf016d05e.position;
        Vector2 _0xb68881a0 = _0xf016d05e.position + _0xf016d05e.size;
        _0x31cd7f97.x /= this._0xbae58cd3.pixelRect.width;
        _0x31cd7f97.y /= this._0xbae58cd3.pixelRect.height;
        _0xb68881a0.x /= this._0xbae58cd3.pixelRect.width;
        _0xb68881a0.y /= this._0xbae58cd3.pixelRect.height;
        this._0xa4db7efb.anchorMin = _0x31cd7f97;
        this._0xa4db7efb.anchorMax = _0xb68881a0;
    }

    private static Vector2 _0xec48a922 = Vector2.zero;
    private void OnDestroy()
    {
        if (_0xfa2d29b1 != null && _0xfa2d29b1.Contains(this))
            _0xfa2d29b1.Remove(this);
    }

    private static Rect _0x0fec4c75 = Rect.zero;
    private RectTransform _0xa4db7efb;
    private static UnityEvent _0xc982d1bf = new();
    private static readonly List<_0x56178c6e> _0xfa2d29b1 = new();
    private RectTransform _0x39da75c6;
    private static void ResolutionChanged()
    {
        _0xec48a922.x = Screen.width;
        _0xec48a922.y = Screen.height;
        _0xc982d1bf.Invoke();
    }

    private static void OrientationChanged()
    {
        _0x91b0ff9d = Screen.orientation;
        _0xec48a922.x = Screen.width;
        _0xec48a922.y = Screen.height;
        _0xc982d1bf.Invoke();
    }

    private static ScreenOrientation _0x91b0ff9d = ScreenOrientation.LandscapeLeft;
    private static bool _0xa6602502;
    private void Awake()
    {
        if (!_0xfa2d29b1.Contains(this))
            _0xfa2d29b1.Add(this);
        this._0xbae58cd3 = this.GetComponent<Canvas>();
        this._0x39da75c6 = this.GetComponent<RectTransform>();
        this._0xa4db7efb = this.transform.Find(_0xc6a00551._0x2c2f9a3c(new byte[8] { 9, 59, 60, 63, 27, 40, 63, 59 }, 90)) as RectTransform;
        if (!_0xa6602502)
        {
            _0x91b0ff9d = Screen.orientation;
            _0xec48a922.x = Screen.width;
            _0xec48a922.y = Screen.height;
            _0x0fec4c75 = Screen.safeArea;
            _0xa6602502 = true;
        }

        this._0xd61084d1();
    }

    private void Update()
    {
        if (_0xfa2d29b1[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x91b0ff9d)
            OrientationChanged();
        if (Screen.safeArea != _0x0fec4c75)
            SafeAreaChanged();
        if (Screen.width != _0xec48a922.x || Screen.height != _0xec48a922.y)
            ResolutionChanged();
    }

    private Canvas _0xbae58cd3;
    private static void SafeAreaChanged()
    {
        _0x0fec4c75 = Screen.safeArea;
        for (int _0x073eaa6c = 0; _0x073eaa6c < _0xfa2d29b1.Count; _0x073eaa6c++)
            _0xfa2d29b1[_0x073eaa6c]._0xd61084d1();
    }
}

internal static class _0xc6a00551
{
    internal static string _0x2c2f9a3c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}