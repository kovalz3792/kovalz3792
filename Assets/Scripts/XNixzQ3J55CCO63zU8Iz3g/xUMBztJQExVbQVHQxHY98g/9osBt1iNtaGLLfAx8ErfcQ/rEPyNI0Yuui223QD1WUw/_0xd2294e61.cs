using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xd2294e61 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x5b07c2df.Instance._0xac2de253(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x5b07c2df.Instance._0xac2de253(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}