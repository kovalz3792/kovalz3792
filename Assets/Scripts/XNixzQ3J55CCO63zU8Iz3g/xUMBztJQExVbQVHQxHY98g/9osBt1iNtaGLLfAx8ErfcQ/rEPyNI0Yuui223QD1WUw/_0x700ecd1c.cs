using UnityEngine;
using UnityEngine.UI;

public class _0x700ecd1c : MonoBehaviour
{
    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x5b07c2df.Instance._0xf8c3fe7a(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}