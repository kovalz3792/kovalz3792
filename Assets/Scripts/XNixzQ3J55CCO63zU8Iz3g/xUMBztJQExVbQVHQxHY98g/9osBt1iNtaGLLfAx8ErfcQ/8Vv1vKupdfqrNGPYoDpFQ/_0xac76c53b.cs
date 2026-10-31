using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xac76c53b : MonoBehaviour
{
    public GameObject Content;
    public Image ContentImage;
    public bool IsScaledDownOnAwake = true;
    private bool _0x36ff0e2b => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentHeaderText;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public static void HideAllPops()
    {
        _0xbbace369.Instance._0xd6d594b0();
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xd9f21e67();
    }

    public TMP_Text ContentAdditionalText;
    public float scaleDuration = 0.4f;
    public bool IsOnlyYScale;
    private void _0xd9f21e67()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public void _0x6297d54a()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public Ease ease = Ease.OutSine;
    public TMP_Text ContentMainText;
}