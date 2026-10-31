using TMPro;
using UnityEngine;
using static _0x7d9c5f21;

public class _0xc0aaf887 : MonoBehaviour
{
    public void _0xa1e5e93a()
    {
        this.MoneyCountText.text = _0x2ad08372._0xa3be3a7a.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x2ad53f04;
            if (this.gameObject.TryGetComponent(out _0x2ad53f04))
                this.MoneyCountText = _0x2ad53f04;
        }

        this._0xa1e5e93a();
    }
}