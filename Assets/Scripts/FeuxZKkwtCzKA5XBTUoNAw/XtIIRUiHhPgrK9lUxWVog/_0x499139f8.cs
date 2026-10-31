using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x499139f8 : MonoBehaviour
{
    private List<string> _0x1ef7497a = new();
    private float _0x9606c011 = 4;
    private TMP_Text _0x5665ffac;
    private void Update()
    {
        int _0xcd4170f5 = 1;
        if (this._0x1ef7497a.Count > 0)
        {
            string _0xee623e16 = this._0x5665ffac.text;
            foreach (string _0xdedeee2f in this._0x1ef7497a)
                while (_0xee623e16.Contains(_0xdedeee2f))
                    _0xee623e16 = _0xee623e16.Replace(_0xdedeee2f, "");
            _0xcd4170f5 = _0xee623e16.Length;
        }
        else
        {
            _0xcd4170f5 = this._0x5665ffac.text.Length;
        }

        float _0x85f36a36 = Mathf.Clamp(this._0x1089d3b2 + this._0x47b898ec * _0xcd4170f5, this._0xff79fe2f, this._0x9606c011);
        if (!Mathf.Approximately(this._0xeeebeab1.aspectRatio, _0x85f36a36))
            this._0xeeebeab1.aspectRatio = _0x85f36a36;
    }

    private float _0x47b898ec = 0.6f;
    private AspectRatioFitter _0xeeebeab1;
    private float _0x1089d3b2;
    private float _0xff79fe2f = 1.5f;
}