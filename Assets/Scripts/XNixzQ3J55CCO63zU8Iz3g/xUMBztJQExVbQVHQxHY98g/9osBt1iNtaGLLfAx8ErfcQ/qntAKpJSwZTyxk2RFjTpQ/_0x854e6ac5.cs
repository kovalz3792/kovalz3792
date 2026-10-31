using UnityEngine;
using UnityEngine.UI;

public class _0x854e6ac5 : MonoBehaviour
{
    public int EndTutorialPanelIndex = 1;
    public bool IsTutorialEndPanel;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xeeea9c75.Instance._0xf35c50bd(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x5b07c2df.Instance._0x96c682d5());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xeeea9c75.Instance._0xf35c50bd(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xeeea9c75.Instance._0xf35c50bd(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x5b07c2df.Instance._0x96c682d5());
        }
    }

    public Button NextTutorialButton;
    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
}