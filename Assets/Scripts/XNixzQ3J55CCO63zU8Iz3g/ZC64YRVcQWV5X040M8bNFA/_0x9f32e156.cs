using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x9f32e156 : MonoBehaviour
{
    public List<Button> HomeButtons = new();
    private int _0xda4a31a3 => this.CustomTimeInitial + _0x5b07c2df._0x359d8dc0._0xf29f4f7a * 10;

    private IEnumerator _0xaed1b3c7()
    {
        this._0x7cb7ab4b();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x5b07c2df.Instance._0x536f9aeb == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x5b07c2df.Instance._0xc6e40adc)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x7cb7ab4b();
            }
        }

        if (!this.IsGameEnd)
            this._0x8974b404();
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xda4a31a3;
        this.CurrentGameIndex = _0x5b07c2df.Instance._0x536f9aeb;
        foreach (Button _0x46dae971 in this.HomeButtons)
            _0x46dae971.onClick.AddListener(() =>
            {
                this._0x1493b3a8();
            });
        foreach (Button _0x91b7a638 in this.PauseButtons)
            _0x91b7a638.onClick.AddListener(() =>
            {
                _0x5b07c2df.Instance._0xf8c3fe7a(false);
                _0xbbace369.Instance._0xa4023dd4(_0x7d9c5f21._0x991ac867.PAUSE);
            });
        this._0xa90e7b1c();
        this.LevelNumberText.ForEach(_0x0c692177 => _0x0c692177.text = $"LVL {_0x5b07c2df._0x359d8dc0._0xf29f4f7a + 1}");
        if (_0x63cd2872.Instance.IsTimerEnabled)
        {
            this._0x7cb7ab4b();
            this.StartCoroutine(this._0xaed1b3c7());
        }
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x653a65af()
    {
        if (!this.IsGameEnd)
        {
            this._0x5b512acb();
            _0x5b07c2df.IsAfterLevelComplete = true;
            _0x5b07c2df.IsAfterLevelFailed = false;
            _0xac76c53b _0x0ad4487f = _0xbbace369.Instance._0xf40baff2(_0x7d9c5f21._0x991ac867.WIN).GetComponent<_0xac76c53b>();
            if (_0x63cd2872.Instance.IsCheckScoreEnabled)
                _0x0ad4487f.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xe801bc88}";
            else
                _0x0ad4487f.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x63cd2872.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x7d9c5f21._0x2ad08372._0xa3be3a7a)
                    _0x7d9c5f21._0x2ad08372._0xa3be3a7a = this.ScoreCurrent;
                _0x0ad4487f.ContentAdditionalText.text = $"{_0x7d9c5f21._0x2ad08372._0xa3be3a7a}";
            }
            else
            {
                _0x0ad4487f.ContentAdditionalText.text = $"{this._0x8b8ef961}";
                _0x7d9c5f21._0x2ad08372._0xa3be3a7a += this._0x8b8ef961;
            }

            if (_0x63cd2872.Instance.IsLevelIncrementOnWin)
                ++_0x5b07c2df._0x359d8dc0._0xf29f4f7a;
            _0xbbace369.Instance._0xa4023dd4(_0x7d9c5f21._0x991ac867.WIN);
        }
    }

    public void _0x1493b3a8()
    {
        _0x5b07c2df.Instance._0xf8c3fe7a(true);
        _0x5b07c2df.Instance._0xac2de253(_0x7d9c5f21._0x4c653446.SCENE_0);
    }

    public void _0x64bb56dc(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xa90e7b1c();
            this._0xfe98467f();
        }
    }

    public List<Button> PauseButtons = new();
    [HideInInspector]
    public int ScoreCurrent;
    private void _0xa8948ee7()
    {
        if (this.ScoreCurrent >= this._0xe801bc88)
            this._0x653a65af();
        else
            this._0x8974b404();
    }

    [HideInInspector]
    public int TimeLeft;
    private void _0x7cb7ab4b()
    {
        this.TimerText.ForEach(_0x0c692177 => _0x0c692177.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x6b25af61._0x28e8e460(new byte[6] { 120, 120, 73, 47, 102, 102 }, 21)));
    }

    public void _0x8974b404()
    {
        if (_0x63cd2872.Instance.IsOnlyWinGameEndEnabled)
            this._0x653a65af();
        if (!this.IsGameEnd)
        {
            this._0x5b512acb();
            _0x5b07c2df.IsAfterLevelComplete = false;
            _0x5b07c2df.IsAfterLevelFailed = true;
            _0xac76c53b _0x4a73b32a = _0xbbace369.Instance._0xf40baff2(_0x7d9c5f21._0x991ac867.LOSE).GetComponent<_0xac76c53b>();
            if (_0x63cd2872.Instance.IsCheckScoreEnabled)
                _0x4a73b32a.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xe801bc88}";
            else
                _0x4a73b32a.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x4a73b32a.ContentAdditionalText.text = $"{0}";
            _0x7d9c5f21._0x2ad08372._0xa3be3a7a += 0;
            _0xbbace369.Instance._0xa4023dd4(_0x7d9c5f21._0x991ac867.LOSE);
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    private void Awake()
    {
        _0x1adaacdc = this.gameObject.GetComponent<_0x9f32e156>();
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> SubtitleText = new();
    public int CustomTimeInitial = 30;
    private int _0xe801bc88 => this.CustomTargetScore + _0x5b07c2df._0x359d8dc0._0xf29f4f7a * 10;

    private static _0x9f32e156 _0x1adaacdc;
    private void _0xfe98467f()
    {
        if (this.ScoreCurrent > _0x5b07c2df._0x359d8dc0._0x30a3ef7d)
            _0x5b07c2df._0x359d8dc0._0x30a3ef7d = this.ScoreCurrent;
        if (_0x63cd2872.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xe801bc88)
                this._0x653a65af();
    }

    public List<TMP_Text> TimerText = new();
    private void _0x5b512acb()
    {
        this.IsGameEnd = true;
        _0x5b07c2df.IsAfterLevelComplete = true;
    }

    private int _0x8b8ef961 => this.ScoreCurrent;

    public int CustomTargetScore = 10;
    private void _0xa90e7b1c()
    {
        if (_0x63cd2872.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x0c692177 => _0x0c692177.text = $"{this.ScoreCurrent}/{this._0xe801bc88}");
        else
            this.ScoreText.ForEach(_0x0c692177 => _0x0c692177.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> ScoreText = new();
}

internal static class _0x6b25af61
{
    internal static string _0x28e8e460(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}