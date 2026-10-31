using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xdf9b617c : MonoBehaviour
{
    private void _0x5b548535(Touch? _0x305a97f9)
    {
        if (!_0x5b07c2df.Instance._0xc6e40adc)
        {
            _0x305a97f9 = null;
            return;
        }

        int _0x46e2d172 = _0x305a97f9.Value.touchId;
        _0x305a97f9 = Touch.activeTouches.FirstOrDefault(_0xcca619c2 => _0xcca619c2.touchId == _0x46e2d172);
        if (!this._0x688ec8ae(_0x305a97f9.Value))
            _0x305a97f9 = null;
    }

    private bool _0xdcc8cf24(Touch? _0x7d5ca191, Bounds _0x073b5236, TouchPhase _0xecf4d838)
    {
        if (!_0x5b07c2df.Instance._0xc6e40adc)
        {
            _0x7d5ca191 = null;
            return false;
        }

        if (_0x7d5ca191 != null)
            if (_0x7d5ca191.Value.phase == _0xecf4d838)
            {
                Vector3 _0x82c23740 = Camera.main.ScreenToWorldPoint(_0x7d5ca191.Value.screenPosition);
                Vector3 _0xa9a335f1 = new(_0x82c23740.x, _0x82c23740.y, _0x073b5236.center.z);
                if (_0x073b5236.Contains(_0xa9a335f1) && this._0x688ec8ae(_0x7d5ca191.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0xebb9ea88(Bounds _0x266f9c12, TouchPhase _0xfe7d8325)
    {
        if (!_0x5b07c2df.Instance._0xc6e40adc)
            return null;
        foreach (Touch _0x3bd40819 in Touch.activeTouches)
            if (_0x3bd40819.phase == _0xfe7d8325)
            {
                Vector3 _0x9d7d592c = Camera.main.ScreenToWorldPoint(_0x3bd40819.screenPosition);
                Vector3 _0x4347b53f = new(_0x9d7d592c.x, _0x9d7d592c.y, _0x266f9c12.center.z);
                if (_0x266f9c12.Contains(_0x4347b53f) && this._0x688ec8ae(_0x3bd40819))
                    return _0x3bd40819;
            }

        return null;
    }

    private bool _0x688ec8ae(Touch? _0x809ec41c)
    {
        if (!_0x809ec41c.HasValue)
            return false;
        Vector3 _0x3b9616cd = Camera.main.ScreenToWorldPoint(_0x809ec41c.Value.screenPosition);
        Vector3 _0xee1547e3 = _0x3b9616cd;
        _0xee1547e3.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xee1547e3))
            return true;
        _0x809ec41c = null;
        return false;
    }

    public BoxCollider2D CameraTouchBounds;
    private static _0xdf9b617c _0xc329a77b;
    private Touch? _0xec5f3f00(Bounds _0xba2df7ab)
    {
        if (!_0x5b07c2df.Instance._0xc6e40adc)
            return null;
        foreach (Touch _0x05705667 in Touch.activeTouches)
            if (!_0x05705667.ended)
            {
                Vector3 _0x52487f70 = Camera.main.ScreenToWorldPoint(_0x05705667.screenPosition);
                Vector3 _0x852c216f = new(_0x52487f70.x, _0x52487f70.y, _0xba2df7ab.center.z);
                if (_0xba2df7ab.Contains(_0x852c216f) && this._0x688ec8ae(_0x05705667))
                    return _0x05705667;
            }

        return null;
    }

    private Touch? _0x24461cfe()
    {
        if (!_0x5b07c2df.Instance._0xc6e40adc)
            return null;
        foreach (Touch _0x82eaf695 in Touch.activeTouches)
            if (!_0x82eaf695.ended)
                if (this._0x688ec8ae(_0x82eaf695))
                    return _0x82eaf695;
        return null;
    }

    private Touch? _0xfeb2bda4(Bounds _0x3f0c6e24)
    {
        if (!_0x5b07c2df.Instance._0xc6e40adc)
            return null;
        foreach (Touch _0xd605fe7f in Touch.activeTouches)
            if (_0xd605fe7f.ended)
            {
                Vector3 _0x543d8537 = Camera.main.ScreenToWorldPoint(_0xd605fe7f.screenPosition);
                Vector3 _0x28fc7874 = new(_0x543d8537.x, _0x543d8537.y, _0x3f0c6e24.center.z);
                if (_0x3f0c6e24.Contains(_0x28fc7874) && this._0x688ec8ae(_0xd605fe7f))
                    return _0xd605fe7f;
            }

        return null;
    }

    private Touch? _0xe22e37b3()
    {
        if (!_0x5b07c2df.Instance._0xc6e40adc)
            return null;
        foreach (Touch _0x26506929 in Touch.activeTouches)
            if (_0x26506929.ended)
                if (this._0x688ec8ae(_0x26506929))
                    return _0x26506929;
        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xc329a77b = this.gameObject.GetComponent<_0xdf9b617c>();
    }
}