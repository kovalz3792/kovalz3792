using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x93fe1b10 : MonoBehaviour
{
    private void _0xc36332a8()
    {
        this.AnimationSlider.value = 0.05f;
        _0xb0247bd5 = !_0xb0247bd5;
        this._0xc618de1a = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xaee54441 => this.AnimationSlider.value = _0xaee54441, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x7f26eae8._0x26e216a3?._0x416dba4b();
        });
    }

    public void _0x63d2be60()
    {
        this._0xc618de1a?.Pause();
    }

    public GameObject Error;
    public float SecondPassSliderValue = 0.5f;
    public void _0x862d9306()
    {
        this._0x82b17b2d();
        bool _0x0829fa30 = _0xb0247bd5;
        this._0xc618de1a = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xaee54441 => this.AnimationSlider.value = _0xaee54441, _0x0829fa30 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xb0247bd5 = !_0xb0247bd5;
    }

    private Sequence _0xc618de1a;
    public float FirstAnimationTime = 10.0f;
    public Slider AnimationSlider;
    public static _0x93fe1b10 Instance;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x93fe1b10>();
    }

    public void _0x915756ff()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xc618de1a?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xb0247bd5 = false;
    }

    public void _0x82b17b2d()
    {
        this._0xc618de1a?.Kill();
        this.AnimationSlider.value = _0xb0247bd5 ? this.SecondPassSliderValue : 0.05f;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x7d9c5f21._0x4c653446.SCENE_0 && !_0xb0247bd5)
        {
            this._0xc36332a8();
        }
        else
        {
            this._0x862d9306();
        }
    }

    public GameObject Background;
    public GameObject Content;
    public float DefaultAnimationTime = 0.4f;
    private static bool _0xb0247bd5 = false;
    public void _0x0c15cfc9()
    {
        this._0xc618de1a?.Play();
    }
}