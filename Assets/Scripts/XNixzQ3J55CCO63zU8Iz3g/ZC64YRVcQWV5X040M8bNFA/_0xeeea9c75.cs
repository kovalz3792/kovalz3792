using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x7d9c5f21;

public class _0xeeea9c75 : MonoBehaviour
{
    private void _0xeea2cd62(int _0x79a65627)
    {
        this.LastPanelIndexes.Add(_0x79a65627);
        this.CurrentPanelIndex = _0x79a65627;
        for (int _0xcefdb8d0 = 0; _0xcefdb8d0 < this.Panels.Count; _0xcefdb8d0++)
            if (_0xcefdb8d0 != _0x79a65627 && this.Panels[_0xcefdb8d0] != null)
                this.Panels[_0xcefdb8d0]._0x98a5d067();
    }

    private void _0x81b1d7ff(int _0x6b6eb8ff)
    {
        this._0xeea2cd62(_0x6b6eb8ff);
        this._0x44326f5b(_0x6b6eb8ff);
        this.CurrentPanelIndex = _0x6b6eb8ff;
        this.Panels[_0x6b6eb8ff]._0x378db10d();
    }

    private void Start()
    {
        this._0x694824f2();
    }

    private void _0x694824f2()
    {
        this._0x81b1d7ff(_0x491f71dc.SPLASH);
        if (_0x5b07c2df.Instance._0x536f9aeb == _0x4c653446.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x93fe1b10.Instance.DefaultAnimationTime);
        }
    }

    public float ScaleDuration = 0.4f;
    private void SwitchSplash()
    {
        if (_0x63cd2872.Instance.IsTutorialEnabled && !_0x5b07c2df._0x359d8dc0._0x9ce278e8)
            this._0xf35c50bd(_0x491f71dc.TUTORIAL0);
        else
            this._0xf35c50bd(_0x491f71dc.DEFAULT);
    }

    public List<_0x5902b324> Panels;
    public int CurrentPanelIndex;
    private _0x5902b324 _0xdff338e6(int _0xf785fe7f)
    {
        return this.Panels[_0xf785fe7f];
    }

    public void _0x13deed89(int _0x2d4666fc)
    {
        if (_0x2d4666fc == _0x491f71dc.SPLASH && _0x5b07c2df.Instance._0x536f9aeb != _0x4c653446.SCENE_0)
            _0x93fe1b10.Instance._0x862d9306();
        if (_0x5b07c2df.Instance._0x536f9aeb != _0x4c653446.SCENE_0)
        {
            if (_0x2d4666fc == _0x491f71dc.SPLASH || _0x2d4666fc == _0x491f71dc.TUTORIAL0)
                _0x5b07c2df.Instance._0xf8c3fe7a(false);
            else if (_0x2d4666fc == _0x491f71dc.DEFAULT)
                _0x5b07c2df.Instance._0xf8c3fe7a(true);
        }
    }

    public void _0x83c33371()
    {
        this.LastPanelIndexes.RemoveAll(_0x75ba3525 => _0x75ba3525 == this.CurrentPanelIndex);
        int _0x080467c2 = this.LastPanelIndexes.Last();
        this._0x44326f5b(_0x080467c2);
        this._0x58c0a0a9(_0x080467c2);
        this.CurrentPanelIndex = _0x080467c2;
        this.Panels[_0x080467c2].Show();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xeeea9c75>();
    }

    public bool IsShowSplashOnStart = true;
    private void _0x58c0a0a9(int _0x54a90f3a)
    {
        this.LastPanelIndexes.Add(_0x54a90f3a);
        this.CurrentPanelIndex = _0x54a90f3a;
        for (int _0xcf9900e1 = 0; _0xcf9900e1 < this.Panels.Count; _0xcf9900e1++)
            if (_0xcf9900e1 != _0x54a90f3a && this.Panels[_0xcf9900e1] != null)
                this.Panels[_0xcf9900e1]._0x98a5d067();
    }

    public void _0xf35c50bd(int _0x55e7f170)
    {
        this._0xeea2cd62(_0x55e7f170);
        this._0x44326f5b(_0x55e7f170);
        this.CurrentPanelIndex = _0x55e7f170;
        this.Panels[_0x55e7f170].Show();
    }

    public float StaticBlurMaterialInitialValue;
    private void _0x44326f5b(int _0x3b6c152b)
    {
        if (_0x3b6c152b == _0x491f71dc.SPLASH)
            _0x93fe1b10.Instance._0x82b17b2d();
        if (_0x5b07c2df.Instance._0x536f9aeb == _0x4c653446.SCENE_0)
        {
        }
    }

    public static _0xeeea9c75 Instance;
}