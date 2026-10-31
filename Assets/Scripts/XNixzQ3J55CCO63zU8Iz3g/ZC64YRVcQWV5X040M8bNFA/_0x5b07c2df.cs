using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x7d9c5f21;

public class _0x5b07c2df : MonoBehaviour
{
    private IEnumerator _0x8e51c1e9(int _0xb4d1e457)
    {
        _0xeeea9c75.Instance._0xf35c50bd(_0x491f71dc.SPLASH);
        AsyncOperation _0xc258ef1e = SceneManager.LoadSceneAsync(_0xb4d1e457);
        while (!_0xc258ef1e.isDone)
            yield return null;
    }

    public static _0x4e89534f _0x359d8dc0 => _0x4e89534f.ALL_SCENES_SETTING_SINGLETONS[Instance._0x536f9aeb];

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private void _0xcb0d502e()
    {
        IsAfterLevelComplete = true;
        Instance._0xac2de253(_0x4c653446.SCENE_0);
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0xf8c3fe7a(bool _0xc8442f1f)
    {
        this._0xc6e40adc = _0xc8442f1f;
        this._0xf706eee0(!this._0xc6e40adc);
        Physics2D.simulationMode = this._0xc6e40adc ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xfbda294a(this.EnvironmentWithTweensToToggle);
    }

    private void Start()
    {
        if (this._0x536f9aeb != _0x4c653446.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0xac2de253(_0x4c653446.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x359d8dc0._0x9ce278e8 = false;
            _0xbbace369.Instance._0xd6d594b0();
            _0xeeea9c75.Instance._0xf35c50bd(_0x491f71dc.TUTORIAL0);
        });
    }

    public Button DeleteProgressDataButton;
    public Transform Environment;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5b07c2df>();
        this.RootGameObject = GameObject.FindWithTag(_0x7a9f8703._0x2f4d2f87(new byte[4] { 143, 178, 178, 169 }, 221));
        if (this._0x536f9aeb == _0x4c653446.SCENE_0)
            this._0xf8c3fe7a(true);
        else
            this._0xf8c3fe7a(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xc0aaf887>(true).ToList();
    }

    [HideInInspector]
    public List<_0xc0aaf887> MoneyCountContainers = new();
    private static _0x4e89534f _0x343ebd68 => _0x4e89534f.ALL_SCENES_SETTING_SINGLETONS[0];

    public Button ShowResetTutorialButton;
    public void _0x96c682d5()
    {
        _0x359d8dc0._0x9ce278e8 = true;
    }

    public static bool IsAfterLevelFailed = false;
    public bool _0xc6e40adc { get; private set; }

    public void _0x35c4d9fc()
    {
        foreach (_0xc0aaf887 _0x7f1203f0 in this.MoneyCountContainers)
            _0x7f1203f0._0xa1e5e93a();
    }

    private void _0xfbda294a(Transform _0x580c0b4c)
    {
        Transform[] _0x8e360a92 = _0x580c0b4c.GetComponentsInChildren<Transform>();
        foreach (Transform _0xd04d7474 in _0x8e360a92)
            if (_0xd04d7474 != null && DOTween.IsTweening(_0xd04d7474))
            {
                if (this._0xc6e40adc)
                    DOTween.Play(_0xd04d7474);
                else
                    DOTween.Pause(_0xd04d7474);
            }
    }

    public static bool IsAfterLevelComplete;
    private static _0x4e89534f GAME_INDEX_SETTINGS(int _0x8c511bb8)
    {
        return _0x4e89534f.ALL_SCENES_SETTING_SINGLETONS[_0x8c511bb8];
    }

    public static _0x5b07c2df Instance;
    public Canvas MainCanvas;
    public Transform EnvironmentWithTweensToToggle;
    private static void MakeGrid(List<RectTransform> _0x2237bd03, AspectRatioFitter _0x51faa9e4, float _0xcb711a2e, int _0xe3a87872, int _0x595e75bf)
    {
        _0x51faa9e4.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x51faa9e4.aspectRatio = _0xcb711a2e;
        foreach (RectTransform _0xf3963fc8 in _0x2237bd03)
        {
            int _0xb70f5892 = _0xf3963fc8.transform.GetSiblingIndex();
            _0xf3963fc8.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xb70f5892 % _0xe3a87872) * (1f / _0xe3a87872), (_0x595e75bf - (Mathf.FloorToInt((float)_0xb70f5892 / _0xe3a87872) % _0x595e75bf + 1f)) * (1f / _0x595e75bf));
            _0xf3963fc8.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xb70f5892 % _0xe3a87872 + 1f) * (1f / _0xe3a87872), (_0x595e75bf - Mathf.FloorToInt((float)_0xb70f5892 / _0xe3a87872) % _0x595e75bf) * (1f / _0x595e75bf));
            _0xf3963fc8.offsetMin = Vector2.zero;
            _0xf3963fc8.offsetMax = Vector2.zero;
        }
    }

    public void _0xac2de253(int _0x63af8284)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x8e51c1e9(_0x63af8284));
    }

    private void _0xf706eee0(bool _0xdc71753b)
    {
        Rigidbody2D[] _0xd25f648d = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xb66cd0cb in _0xd25f648d)
            if (_0xdc71753b)
                _0xb66cd0cb.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xb66cd0cb.constraints = RigidbodyConstraints2D.None;
    }

    public void _0xb6734784()
    {
        this._0xac2de253(SceneManager.GetActiveScene().buildIndex);
    }

    private IEnumerator _0xa6fa8901(string _0x3ad3c4a3)
    {
        _0xeeea9c75.Instance._0xf35c50bd(_0x491f71dc.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xaef507c3 = SceneManager.LoadSceneAsync(_0x3ad3c4a3);
        while (!_0xaef507c3.isDone)
            yield return null;
    }

    public int _0x536f9aeb => SceneManager.GetActiveScene().buildIndex;
}

internal static class _0x7a9f8703
{
    internal static string _0x2f4d2f87(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}