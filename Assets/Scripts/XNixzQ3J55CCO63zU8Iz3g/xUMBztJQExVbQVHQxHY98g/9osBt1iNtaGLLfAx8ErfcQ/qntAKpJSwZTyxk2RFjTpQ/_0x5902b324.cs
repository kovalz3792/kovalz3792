using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x5902b324 : MonoBehaviour
{
    private void _0x5fbac2a5()
    {
        if (this.OuterBackground != null)
        {
            Image _0xad731b4e = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xad731b4e, true);
            _0xad731b4e.DOFade(0f, this.ScaleDuration);
        }
    }

    public void _0x98a5d067()
    {
        this._0x5fbac2a5();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0x1830dd79()
    {
        if (this.OuterBackground != null)
        {
            Image _0xb2544ead = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xb2544ead, true);
            _0xb2544ead.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public TMP_Text HeaderText;
    public GameObject OuterBackground;
    private void _0x4e7baa9c()
    {
        if (this.OuterBackground != null)
        {
            Image _0x41c195dc = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x41c195dc, true);
            _0x41c195dc.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private bool _0x776db8e8 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void Show()
    {
        this._0x4e7baa9c();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xeeea9c75.Instance._0x13deed89(_0xeeea9c75.Instance.CurrentPanelIndex);
            });
        }
    }

    public TMP_Text MainText;
    public GameObject Content;
    public bool IsScaledDownOnAwake = true;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x1830dd79();
    }

    public float ScaleDuration = 0.4f;
    private void _0x79df1f59()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1365f504 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1365f504, true);
            _0x1365f504.DOFade(1f, 0f);
        }
    }

    public Ease Ease = Ease.OutSine;
    public void _0x378db10d()
    {
        this._0x79df1f59();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xeeea9c75.Instance._0x13deed89(_0xeeea9c75.Instance.CurrentPanelIndex);
    }
}