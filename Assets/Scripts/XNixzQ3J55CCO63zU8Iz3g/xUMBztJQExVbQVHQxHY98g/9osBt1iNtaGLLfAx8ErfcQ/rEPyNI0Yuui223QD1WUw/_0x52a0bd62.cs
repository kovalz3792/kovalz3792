using UnityEngine;
using UnityEngine.UI;

public class _0x52a0bd62 : MonoBehaviour
{
    private Button _0x69eb01ca;
    private bool _0xf5ec1d91;
    private void Start()
    {
        if (this._0xf5ec1d91)
            this._0x69eb01ca.onClick.AddListener(() => _0xeeea9c75.Instance._0x83c33371());
        else
            this._0x69eb01ca.onClick.AddListener(() => _0xeeea9c75.Instance._0xf35c50bd(this._0xc6d8b318));
    }

    private void Awake()
    {
        if (this._0x69eb01ca == null)
            if (!this.TryGetComponent(out this._0x69eb01ca))
                this._0x69eb01ca = this.GetComponentInChildren<Button>();
    }

    private int _0xc6d8b318;
}