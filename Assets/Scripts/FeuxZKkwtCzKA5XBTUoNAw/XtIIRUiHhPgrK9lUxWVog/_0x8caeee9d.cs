using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8caeee9d : MonoBehaviour
{
    private void _0xbe969d10()
    {
        if (this._0x911bee80.canvasRenderer.GetColor() != this._0xf58e20aa.canvasRenderer.GetColor())
            this._0xf58e20aa.canvasRenderer.SetColor(this._0x911bee80.canvasRenderer.GetColor());
    }

    private Image _0x911bee80;
    private void Update()
    {
        this._0xbe969d10();
    }

    private TMP_Text _0xf58e20aa;
}