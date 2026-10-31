using UnityEngine;
using UnityEngine.UI;

public class _0x2bce9c01 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xbbace369.Instance._0x71242dfb();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xbbace369.Instance._0xd6d594b0());
        else
            this.Button.onClick.AddListener(() => _0xbbace369.Instance._0xa4023dd4(this.PopToShowIndex));
    }

    public Button Button;
    public int PopToShowIndex;
}