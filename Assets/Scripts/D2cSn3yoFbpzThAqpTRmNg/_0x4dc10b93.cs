using UnityEngine;

/// <summary>
/// Shows or hides ONE view object. The only sanctioned way this game toggles visibility:
/// a scene m_IsActive modification aimed at a template object is silently discarded
/// (rule C.2), and a name lookup does not survive obfuscation, so every gate holds a direct
/// reference to an object the generated code created itself.
/// </summary>
public sealed class _0x4dc10b93
{
    public bool _0x310a8df3
    {
        get
        {
            return this._0x4035e0ad != null && this._0x4035e0ad.activeSelf;
        }
    }

    public _0x4dc10b93 _0x10cb5862(GameObject _0x8e43b1fe)
    {
        this._0x4035e0ad = _0x8e43b1fe;
        return this;
    }

    public void Show()
    {
        if (this._0x4035e0ad != null)
        {
            this._0x4035e0ad.SetActive(true);
        }
    }

    private GameObject _0x4035e0ad;
    public GameObject _0xab14d376
    {
        get
        {
            return this._0x4035e0ad;
        }
    }

    public void _0x908a647b()
    {
        if (this._0x4035e0ad != null)
        {
            this._0x4035e0ad.SetActive(false);
        }
    }
}