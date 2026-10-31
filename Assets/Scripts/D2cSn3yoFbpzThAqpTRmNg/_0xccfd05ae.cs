using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// The press feedback every button in this game carries: a short scale dip on press and a
/// spring back on release, so a tap is visibly acknowledged (rule C.7).
///
/// Both tweens are linked to this object, so a scene change kills them instead of leaving
/// DOTween animating a destroyed RectTransform on the next scene's first frame (rule C.56).
/// </summary>
public sealed class _0xccfd05ae : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private RectTransform _0xeef875ad;
    private void OnDestroy()
    {
        DOTween.Kill(this._0xeef875ad);
    }

    public void OnPointerDown(PointerEventData _0xf88fb2dd)
    {
        if (this._0xeef875ad == null)
        {
            return;
        }

        this._0xeef875ad.DOScale(0.94f, _0x7d178cbc.PressIn).SetEase(Ease.OutQuad).SetLink(this.gameObject);
    }

    public void _0x606fe1eb(RectTransform _0x28710431)
    {
        this._0xeef875ad = _0x28710431;
    }

    public void OnPointerUp(PointerEventData _0x82a0703a)
    {
        if (this._0xeef875ad == null)
        {
            return;
        }

        this._0xeef875ad.DOScale(1f, _0x7d178cbc.PressOut).SetEase(Ease.OutBack).SetLink(this.gameObject);
    }
}