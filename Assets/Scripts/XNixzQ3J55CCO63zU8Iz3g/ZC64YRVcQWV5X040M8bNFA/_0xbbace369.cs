using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x7d9c5f21;

public class _0xbbace369 : MonoBehaviour
{
    public static _0xbbace369 Instance;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
    public _0xac76c53b _0xf40baff2(int _0xb9ac6d3a)
    {
        return this.Pops[_0xb9ac6d3a];
    }

    public void _0xa4023dd4(int _0x9c429898)
    {
        this.CurrentPopIndex = _0x9c429898;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x63b05088(true);
        this._0xa3bb54f8();
        this.Pops[_0x9c429898].Show();
        foreach (GameObject _0x8083acbd in this.GameObjectsToHide)
            _0x8083acbd.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    private void _0x2b5b53b4()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public int CurrentPopIndex;
    public float ScaleDuration = 0.4f;
    private void _0x63b05088(bool _0x7f39d162 = false)
    {
        for (int _0x991914e0 = 0; _0x991914e0 < this.Pops.Count; ++_0x991914e0)
            if (this.Pops[_0x991914e0] != null && !(_0x991914e0 == this.CurrentPopIndex && _0x7f39d162))
                this.Pops[_0x991914e0]._0x6297d54a();
    }

    public void _0x71242dfb()
    {
        this.LastPopIndexes.RemoveAll(_0x75ba3525 => _0x75ba3525 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xd6d594b0();
        else
            this._0xa4023dd4(this.LastPopIndexes.Last());
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xac76c53b _0x3d91caf4 in this.Pops)
            if (_0x3d91caf4 != null)
                _0x3d91caf4.gameObject.SetActive(true);
    }

    public void _0xd6d594b0()
    {
        this.LastPopIndexes.Clear();
        this._0x63b05088();
        foreach (GameObject _0x64a149d7 in this.GameObjectsToHide)
            if (_0x64a149d7 != null)
                _0x64a149d7.SetActive(true);
        this._0x2b5b53b4();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xbbace369>();
    }

    private void _0xa3bb54f8()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public List<_0xac76c53b> Pops;
    public GameObject BlurBackground;
}