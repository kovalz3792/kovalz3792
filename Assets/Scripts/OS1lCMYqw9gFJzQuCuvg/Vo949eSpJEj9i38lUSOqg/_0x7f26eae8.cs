using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

[Serializable]
public class _0x156cbd93
{
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string meta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string isMeta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string payload = "";
}

public class _0x7f26eae8 : MonoBehaviour
{
    private void _0x067d94dc()
    {
        {
#if B_LOGS
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[22] { 32, 47, 30, 8, 15, 38, 91, 40, 15, 20, 9, 30, 63, 30, 13, 18, 24, 30, 50, 21, 29, 20 }, 123));
#endif
        }

        _0x560d70ae = SystemInfo.deviceModel;
        _0xf61d4317 = Application.version;
        _0xb67ac74e = Application.installMode;
        _0xcbd57ddf = Application.installerName;
        _0x02dff43f = Application.identifier;
        _0x0c818fec = _0xe8a6e040();
        _0x77716887 = _0x9979752f();
        _0x366cc35c = SystemInfo.deviceUniqueIdentifier;
        _0xc563f180 = SystemInfo.graphicsDeviceName;
        _0x047e2961 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xf61d4317 = _0x4780d2f4._0x4cb5a45b(new byte[5] { 151, 142, 151, 142, 151 }, 160);
                _0xb67ac74e = ApplicationInstallMode.Store;
                _0xcbd57ddf = _0x4780d2f4._0x4cb5a45b(new byte[19] { 162, 174, 172, 239, 160, 175, 165, 179, 174, 168, 165, 239, 183, 164, 175, 165, 168, 175, 166 }, 193);
                _0x77716887 = _0x4780d2f4._0x4cb5a45b(new byte[8] { 81, 89, 68, 64, 77, 20, 65, 85 }, 52);
                _0x366cc35c = Guid.NewGuid().ToString().Replace(_0x4780d2f4._0x4cb5a45b(new byte[1] { 61 }, 16), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[17] { 122, 117, 68, 82, 85, 124, 1, 69, 68, 87, 108, 78, 69, 68, 77, 27, 1 }, 33) + _0x560d70ae);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[19] { 173, 162, 147, 133, 130, 171, 214, 151, 134, 134, 160, 147, 132, 133, 159, 153, 152, 204, 214 }, 246) + _0xf61d4317);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[20] { 163, 172, 157, 139, 140, 165, 216, 145, 150, 139, 140, 153, 148, 148, 181, 151, 156, 157, 194, 216 }, 248) + _0xb67ac74e);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[23] { 142, 129, 176, 166, 161, 136, 245, 188, 187, 166, 161, 180, 185, 185, 176, 167, 134, 161, 186, 167, 176, 239, 245 }, 213) + _0xcbd57ddf);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[14] { 181, 186, 139, 157, 154, 179, 206, 143, 158, 158, 167, 138, 212, 206 }, 238) + _0x02dff43f);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[14] { 192, 207, 254, 232, 239, 198, 187, 250, 255, 237, 210, 255, 161, 187 }, 155) + _0x0c818fec);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[18] { 57, 54, 7, 17, 22, 63, 66, 23, 17, 7, 16, 35, 5, 7, 12, 22, 88, 66 }, 98) + _0x77716887);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[17] { 255, 240, 193, 215, 208, 249, 132, 215, 221, 215, 224, 193, 210, 237, 192, 158, 132 }, 164) + _0x366cc35c);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[12] { 245, 250, 203, 221, 218, 243, 142, 201, 222, 219, 148, 142 }, 174) + _0xc563f180);
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[12] { 149, 154, 171, 189, 186, 147, 238, 173, 190, 187, 244, 238 }, 206) + _0x047e2961);
#endif
        }
    }

    private void _0x12241562(UniWebView _0xc503764d)
    {
        _0xc503764d.BackgroundColor = Color.clear;
        _0xc503764d.SetSupportMultipleWindows(true, true);
        _0xc503764d.SetBackButtonEnabled(false);
        _0xbcb6cf0a.SetUserAgent(_0x4010606a());
    }

    internal string _0xd482343c(string _0x2658125f)
    {
        int _0x8b52a98b = _0x2658125f.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[3] { 107, 102, 63 }, 2), StringComparison.OrdinalIgnoreCase);
        if (_0x8b52a98b < 0)
            return null;
        string _0x71fba15b = _0x2658125f.Substring(_0x8b52a98b + 3);
        int _0x2974a68d = _0x71fba15b.IndexOf('&');
        return _0x2974a68d >= 0 ? _0x71fba15b.Substring(0, _0x2974a68d) : _0x71fba15b;
    }

    internal bool isDestroyedForce = false;
    internal bool IsAboutBlank(string _0xde34a462)
    {
        if (string.IsNullOrEmpty(_0xde34a462))
            return false;
        return _0xde34a462.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[11] { 146, 145, 156, 134, 135, 201, 145, 159, 146, 157, 152 }, 243), StringComparison.OrdinalIgnoreCase);
    }

    static byte[] DecompressBrotli(byte[] _0x81cf6114)
    {
        using var _0xf6c36ec8 = new MemoryStream(_0x81cf6114);
        using var _0x0abf3d6c = new BrotliStream(_0xf6c36ec8, CompressionMode.Decompress);
        using var _0xf39b5f30 = new MemoryStream();
        _0x0abf3d6c.CopyTo(_0xf39b5f30);
        return _0xf39b5f30.ToArray();
    }

    private string _0x77716887 = "";
    private int _0x7b277008 = -1;
    private bool _0x63dffb13(string _0xf9825a96, string _0x8d855bfb)
    {
        string _0x413c59fc = _0xd482343c(_0xf9825a96);
        if (string.IsNullOrEmpty(_0x413c59fc))
            _0x413c59fc = _0x8d855bfb;
        if (_0xb220dfe8(_0x413c59fc))
            return true;
        string _0xc525047d = string.IsNullOrEmpty(_0x413c59fc) ? _0x4780d2f4._0x4cb5a45b(new byte[29] { 182, 170, 170, 174, 173, 228, 241, 241, 174, 178, 191, 167, 240, 185, 177, 177, 185, 178, 187, 240, 189, 177, 179, 241, 173, 170, 177, 172, 187 }, 222) : _0x4780d2f4._0x4cb5a45b(new byte[46] { 8, 20, 20, 16, 19, 90, 79, 79, 16, 12, 1, 25, 78, 7, 15, 15, 7, 12, 5, 78, 3, 15, 13, 79, 19, 20, 15, 18, 5, 79, 1, 16, 16, 19, 79, 4, 5, 20, 1, 9, 12, 19, 95, 9, 4, 93 }, 96) + _0x413c59fc;
        WLog(_0x4780d2f4._0x4cb5a45b(new byte[35] { 228, 207, 213, 200, 202, 194, 235, 206, 204, 194, 135, 202, 198, 213, 204, 194, 211, 135, 193, 198, 203, 203, 197, 198, 196, 204, 135, 198, 212, 135, 208, 194, 197, 157, 135 }, 167) + _0xc525047d);
        return _0xf71e9866(_0xc525047d);
    }

    private async Task<bool> _0xcfba27ad()
    {
        {
#if B_LOGS
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[37] { 55, 56, 9, 31, 24, 49, 76, 63, 5, 11, 2, 37, 2, 57, 2, 5, 24, 21, 63, 9, 30, 26, 5, 15, 9, 31, 45, 2, 3, 2, 21, 1, 3, 25, 31, 0, 21 }, 108));
#endif
        }

        try
        {
            var _0x16d5df00 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x16d5df00);
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[32] { 33, 46, 31, 9, 14, 39, 90, 47, 20, 19, 14, 3, 41, 31, 8, 12, 19, 25, 31, 9, 90, 51, 20, 19, 14, 19, 27, 22, 19, 0, 31, 30 }, 122));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[20] { 145, 128, 150, 145, 229, 144, 171, 172, 177, 188, 150, 160, 183, 179, 172, 166, 160, 182, 255, 229 }, 197) + ex.Message);
#endif
            }

            _0x26e216a3?._0xb27b4346();
            return true;
        }

        bool _0x192edf03 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x192edf03 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[37] { 154, 149, 164, 178, 181, 156, 225, 146, 168, 166, 175, 236, 168, 175, 225, 128, 175, 174, 175, 184, 172, 174, 180, 178, 239, 225, 145, 173, 160, 184, 164, 179, 225, 136, 133, 251, 225 }, 193) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x053ab35e = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[25] { 19, 2, 20, 19, 103, 20, 46, 32, 41, 106, 46, 41, 103, 6, 50, 51, 47, 103, 2, 21, 21, 8, 21, 125, 103 }, 71) + ex.Message);
#endif
                }

                _0x26e216a3?._0xb27b4346();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[28] { 186, 171, 189, 186, 206, 189, 135, 137, 128, 195, 135, 128, 206, 188, 139, 159, 155, 139, 157, 154, 206, 171, 188, 188, 161, 188, 212, 206 }, 238) + ex.Message);
#endif
                }

                _0x26e216a3?._0xb27b4346();
                return true;
            }
        }
        while (!_0x192edf03);
        return false;
    }

    private string _0x053ab35e = "";
    private string _0x10b18440 = "";
    private string _0x42d69d2b()
    {
        float _0x0b34444d = Time.realtimeSinceStartup;
        if (_0x0b34444d < 0f)
            _0x0b34444d = 0f;
        int _0x14687968 = (int)(_0x0b34444d * 1000f);
        int _0xbad6d3e0 = _0x14687968 / 60000;
        int _0x4fbacda4 = (_0x14687968 / 1000) % 60;
        int _0x755d916c = _0x14687968 % 1000;
        return string.Format(_0x4780d2f4._0x4cb5a45b(new byte[21] { 135, 204, 198, 204, 204, 129, 198, 135, 205, 198, 204, 204, 129, 198, 135, 206, 198, 204, 204, 204, 129 }, 252), _0xbad6d3e0, _0x4fbacda4, _0x755d916c);
    }

    private string _0x9979752f()
    {
        try
        {
            using (var _0xa118de31 = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[30] { 157, 145, 147, 208, 139, 144, 151, 138, 135, 205, 154, 208, 142, 146, 159, 135, 155, 140, 208, 171, 144, 151, 138, 135, 174, 146, 159, 135, 155, 140 }, 254)))
            {
                var _0xf9d9b7f5 = _0xa118de31.GetStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[15] { 3, 21, 18, 18, 5, 14, 20, 33, 3, 20, 9, 22, 9, 20, 25 }, 96));
                var _0xa018385e = _0xf9d9b7f5.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[21] { 176, 178, 163, 150, 167, 167, 187, 190, 180, 182, 163, 190, 184, 185, 148, 184, 185, 163, 178, 175, 163 }, 215));
                using (var _0x9817f64c = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[26] { 35, 44, 38, 48, 45, 43, 38, 108, 53, 39, 32, 41, 43, 54, 108, 21, 39, 32, 17, 39, 54, 54, 43, 44, 37, 49 }, 66)))
                {
                    return _0x9817f64c.CallStatic<string>(_0x4780d2f4._0x4cb5a45b(new byte[19] { 133, 135, 150, 166, 135, 132, 131, 151, 142, 150, 183, 145, 135, 144, 163, 133, 135, 140, 150 }, 226), _0xa018385e);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    internal bool ContainsIgnoreCase(string _0x0aa90a07, string _0xa9fcd9d2)
    {
        if (string.IsNullOrEmpty(_0x0aa90a07) || string.IsNullOrEmpty(_0xa9fcd9d2))
            return false;
        return _0x0aa90a07.IndexOf(_0xa9fcd9d2, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private JObject _0x8a4ce375(params string[] _0x6f48a566)
    {
        JObject _0x8c9d23cc = new JObject();
        foreach (var _0x4bbbd194 in _0x6f48a566)
        {
            string _0xec7d9aeb;
            do
            {
                _0xec7d9aeb = _0x62fb7925();
            }
            while (_0x8c9d23cc.ContainsKey(_0xec7d9aeb));
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xec7d9aeb} val={_0x4bbbd194}");
#endif
            }

            _0x8c9d23cc.Add(_0xec7d9aeb, _0x4bbbd194 == null ? "" : _0x4bbbd194);
        }

        return _0x8c9d23cc;
    }

    private void _0x8323f899()
    {
        if (_0x5fe2b84e != null)
            return;
        var _0x164b73a3 = _0xf9bce44e();
        _0x5fe2b84e = new GameObject(_0x4780d2f4._0x4cb5a45b(new byte[14] { 96, 82, 85, 97, 94, 82, 64, 100, 71, 94, 89, 89, 82, 69 }, 55), typeof(RectTransform), typeof(Text));
        _0xce4060c1 = _0x5fe2b84e.GetComponent<RectTransform>();
        _0xce4060c1.SetParent(_0x164b73a3.transform, false);
        _0xce4060c1.anchorMin = new Vector2(0.5f, 0.5f);
        _0xce4060c1.anchorMax = new Vector2(0.5f, 0.5f);
        _0xce4060c1.pivot = new Vector2(0.5f, 0.5f);
        _0xce4060c1.sizeDelta = new Vector2(600f, 600f);
        _0xce4060c1.anchoredPosition = Vector2.zero;
        _0x7faaf428 = _0x5fe2b84e.GetComponent<Text>();
        _0x7faaf428.text = _0x4780d2f4._0x4cb5a45b(new byte[1] { 61 }, 18);
        _0x7faaf428.font = Resources.GetBuiltinResource<Font>(_0x4780d2f4._0x4cb5a45b(new byte[17] { 183, 158, 156, 154, 152, 130, 169, 142, 149, 143, 146, 150, 158, 213, 143, 143, 157 }, 251));
        _0x7faaf428.fontSize = 200;
        _0x7faaf428.alignment = TextAnchor.MiddleCenter;
        _0x7faaf428.color = Color.white;
        _0x7faaf428.raycastTarget = false;
        _0x5fe2b84e.SetActive(false);
    }

    private void MarkMainFrameCommitted(string _0x5ef3edce)
    {
        _0x6f2a3728 = true;
        string _0x18fe9d25 = GetUrlHost(_0x5ef3edce);
        if (!string.IsNullOrEmpty(_0x18fe9d25))
            _0x8efc419a = _0x18fe9d25;
    }

    private IEnumerator _0x40c74568()
    {
        yield return _0x66487fcb(Permission.Camera);
    }

    private int _0x788b4352 = 0;
    private IEnumerator _0xe7f335ec(string _0xa4314ccd)
    {
        if (_0xbcb6cf0a != null && _0x5d0f8a84)
            yield break;
        _0xbcb6cf0a = gameObject.AddComponent<UniWebView>();
        _0x12241562(_0xbcb6cf0a);
        _0x4f9dcf53(_0xbcb6cf0a);
        _0xbcb6cf0a.BackgroundColor = Color.clear;
        var _0x8193f3d8 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x5fee8e89();
        yield return new WaitForEndOfFrame();
        _0x5d0f8a84 = true;
        _0x8323f899();
        _0xee43092a(true);
        _0x3bb39a7b = false;
        _0x150102c3 = false;
        _0x66692143.Clear();
        _0x7b277008 = -1;
        firstLoadShown = false;
        _0x36847d92 = false;
        _0x4c86bde3 = false;
        _0xbcb6cf0a.SetUserAgent("");
        _0x59f7d44c = Time.realtimeSinceStartup;
        _0xbcb6cf0a.Stop();
        _0xbcb6cf0a.Load(_0xa4314ccd);
        _0xbcb6cf0a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x4780d2f4._0x4cb5a45b(new byte[25] { 97, 77, 69, 66, 12, 123, 73, 78, 122, 69, 73, 91, 12, 101, 66, 69, 88, 69, 77, 64, 12, 127, 68, 67, 91 }, 44));
    }

    private bool _0xab9e6b97 = false;
    private RectTransform _0xce4060c1;
    private string _0x62fb7925()
    {
        return ((char)('a' + _0x4828febb.Next(0, 26))).ToString();
    }

    private IEnumerator _0x36c31df7(Dictionary<string, object> _0x6967f93b)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[30] { 105, 102, 87, 65, 70, 111, 18, 116, 87, 70, 81, 90, 18, 119, 74, 70, 64, 83, 18, 98, 71, 65, 90, 18, 118, 83, 70, 83, 8, 18 }, 50) + string.Join(_0x4780d2f4._0x4cb5a45b(new byte[1] { 224 }, 233), _0x6967f93b));
#endif
            }
        }

        string _0x731f0b6c = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x6967f93b != null && _0x6967f93b.TryGetValue(_0x4780d2f4._0x4cb5a45b(new byte[16] { 45, 44, 55, 42, 37, 42, 32, 34, 55, 42, 44, 45, 7, 34, 55, 34 }, 67), out var raw))
        {
            try
            {
                var _0x964a1a67 = raw?.ToString();
                var _0x726c1180 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x964a1a67);
                if (_0x726c1180 != null && _0x726c1180.TryGetValue(_0x4780d2f4._0x4cb5a45b(new byte[6] { 248, 238, 229, 239, 226, 239 }, 139), out var val))
                {
                    _0x731f0b6c = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x4780d2f4._0x4cb5a45b(new byte[30] { 185, 182, 135, 145, 150, 194, 178, 151, 145, 138, 191, 194, 168, 177, 173, 172, 194, 146, 131, 144, 145, 135, 194, 135, 144, 144, 141, 144, 216, 194 }, 226) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x731f0b6c) && _0x6967f93b != null && _0x6967f93b.TryGetValue(_0x4780d2f4._0x4cb5a45b(new byte[6] { 130, 148, 159, 149, 152, 149 }, 241), out var lab))
        {
            _0x731f0b6c = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[38] { 203, 196, 245, 227, 228, 176, 192, 229, 227, 248, 205, 176, 214, 245, 228, 243, 248, 245, 244, 176, 227, 245, 254, 244, 249, 244, 176, 246, 226, 255, 253, 176, 250, 227, 255, 254, 170, 176 }, 144) + _0x731f0b6c);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x731f0b6c))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[38] { 8, 7, 54, 32, 39, 115, 3, 38, 32, 59, 14, 115, 4, 50, 58, 39, 115, 39, 60, 115, 60, 35, 54, 61, 115, 36, 58, 39, 59, 115, 32, 54, 61, 55, 58, 55, 105, 115 }, 83) + _0x731f0b6c);
            }
#endif
        }

        _0x48f3e0e8 = _0x731f0b6c;
        yield return new WaitUntil(() => _0x5d0f8a84);
        var _0x7d99bf88 = _0x16a7079e(2, 100);
        yield return new WaitUntil(() => _0x7d99bf88.IsCompleted);
        string _0x2768add1 = _0x7d99bf88.Result;
        if (!string.IsNullOrEmpty(_0x2768add1))
        {
            string _0xaa454ff6 = _0xf468d6df(_0x2768add1, _0x731f0b6c);
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[33] { 179, 188, 141, 155, 156, 200, 184, 157, 155, 128, 181, 200, 186, 141, 132, 135, 137, 140, 200, 191, 141, 138, 190, 129, 141, 159, 200, 159, 129, 156, 128, 210, 200 }, 232) + _0xaa454ff6);
#endif
            }

            _0xbcb6cf0a.Load(_0xaa454ff6);
        }
    }

    static _0x156cbd93 ReadScoreMetadata(string _0x9f7bf2b1)
    {
        if (string.IsNullOrWhiteSpace(_0x9f7bf2b1))
            return new _0x156cbd93();
        try
        {
            return JsonConvert.DeserializeObject<_0x156cbd93>(_0x9f7bf2b1) ?? new _0x156cbd93();
        }
        catch (Exception)
        {
            return new _0x156cbd93();
        }
    }

    private Text _0x7faaf428;
    private string _0x34c44c71 = "";
    private bool _0x3903a20a()
    {
        if (_0xae7bb652())
            return true;
        if (_0xbcb6cf0a != null && _0xbcb6cf0a.CanGoBack)
        {
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[36] { 178, 155, 136, 158, 141, 155, 136, 159, 218, 152, 155, 153, 145, 218, 215, 196, 218, 151, 155, 147, 148, 218, 173, 159, 152, 172, 147, 159, 141, 218, 189, 149, 184, 155, 153, 145 }, 250));
            _0xbcb6cf0a.GoBack();
            return true;
        }

        return false;
    }

    private ApplicationInstallMode _0xb67ac74e = ApplicationInstallMode.Unknown;
    private bool _0x6f2a3728;
    static byte[] Decode93(string _0x4ddd8362)
    {
        var _0xb90f1212 = System.Numerics.BigInteger.Zero;
        var _0x6a8bce6f = new System.Numerics.BigInteger(TextAlphabet.Length);
        for (int _0x9f754104 = 0; _0x9f754104 < _0x4ddd8362.Length; _0x9f754104++)
        {
            char _0x9b014603 = _0x4ddd8362[_0x9f754104];
            if (_0x9b014603 >= _0x5780e873.Length)
                throw new FormatException();
            int _0xdadd2c31 = _0x5780e873[_0x9b014603];
            if (_0xdadd2c31 < 0)
                throw new FormatException();
            _0xb90f1212 = _0xb90f1212 * _0x6a8bce6f + _0xdadd2c31;
        }

        var _0x42813741 = ToBigEndian(_0xb90f1212);
        if (_0x42813741.Length < 2 || _0x42813741[0] != 1)
            throw new FormatException();
        var _0x29f35a83 = new byte[_0x42813741.Length - 1];
        Buffer.BlockCopy(_0x42813741, 1, _0x29f35a83, 0, _0x29f35a83.Length);
        return _0x29f35a83;
    }

    internal bool firstLoadShown = false;
    private void _0xee43092a(bool _0x8a55a434)
    {
        _0x8323f899();
        _0x5fe2b84e.SetActive(_0x8a55a434);
        _0xabd64e17 = _0x8a55a434;
        if (_0x8a55a434)
        {
            _0x5fe2b84e.transform.SetAsLastSibling();
            if (_0xce4060c1 != null)
                _0xce4060c1.localRotation = Quaternion.identity;
        }
    }

    static byte[] CompressBrotli(byte[] _0x8ccaed6b)
    {
        using var _0xdcd4204a = new MemoryStream();
        using (var _0x6009b102 = new BrotliStream(_0xdcd4204a, SmallestCompression()))
            _0x6009b102.Write(_0x8ccaed6b, 0, _0x8ccaed6b.Length);
        return _0xdcd4204a.ToArray();
    }

    private Canvas _0x2a5e151d;
    private async Task<bool> _0xfd48ea9b()
    {
        _0x93fe1b10.Instance?._0x63d2be60();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xa3695d6b) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[32] { 81, 94, 111, 121, 126, 87, 42, 95, 100, 99, 126, 115, 42, 90, 127, 121, 98, 42, 68, 101, 126, 99, 108, 99, 105, 107, 126, 99, 101, 100, 48, 42 }, 10) + string.Join(_0x4780d2f4._0x4cb5a45b(new byte[1] { 251 }, 242), _0xa3695d6b));
                }
#endif
            }
        };
        try
        {
            _0xf9d19118 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[31] { 5, 10, 59, 45, 42, 3, 126, 24, 63, 55, 50, 59, 58, 126, 42, 49, 126, 57, 59, 42, 126, 46, 43, 45, 54, 126, 42, 49, 53, 59, 48 }, 94));
                }
#endif
            }

            _0xf9d19118 = "";
        }

        _0x2c4a572d = !string.IsNullOrEmpty(_0xf9d19118);
        _0x7be089ee = _0x42d69d2b();
        {
#if B_LOGS
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[25] { 77, 66, 115, 101, 98, 75, 54, 67, 120, 127, 98, 111, 54, 70, 99, 101, 126, 54, 66, 121, 125, 115, 120, 44, 54 }, 22) + _0xf9d19118);
#endif
        }

        _0x93fe1b10.Instance?._0x0c15cfc9();
        return false;
    }

    private bool _0x8d355633 = false;
    private bool _0xf71e9866(string _0x3c629e19)
    {
        try
        {
            using (var _0x100e2ccf = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[30] { 223, 211, 209, 146, 201, 210, 213, 200, 197, 143, 216, 146, 204, 208, 221, 197, 217, 206, 146, 233, 210, 213, 200, 197, 236, 208, 221, 197, 217, 206 }, 188)))
            using (var _0x00470aac = _0x100e2ccf.GetStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[15] { 79, 89, 94, 94, 73, 66, 88, 109, 79, 88, 69, 90, 69, 88, 85 }, 44)))
            using (var _0x10446ce2 = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[15] { 40, 39, 45, 59, 38, 32, 45, 103, 39, 44, 61, 103, 28, 59, 32 }, 73)))
            using (var _0x7830befa = _0x10446ce2.CallStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[5] { 122, 107, 120, 121, 111 }, 10), _0x3c629e19))
            using (var _0xe908ac1e = new AndroidJavaObject(_0x4780d2f4._0x4cb5a45b(new byte[22] { 197, 202, 192, 214, 203, 205, 192, 138, 199, 203, 202, 208, 193, 202, 208, 138, 237, 202, 208, 193, 202, 208 }, 164), _0x4780d2f4._0x4cb5a45b(new byte[26] { 99, 108, 102, 112, 109, 107, 102, 44, 107, 108, 118, 103, 108, 118, 44, 99, 97, 118, 107, 109, 108, 44, 84, 75, 71, 85 }, 2), _0x7830befa))
            {
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[26] { 154, 177, 171, 182, 180, 188, 149, 176, 178, 188, 249, 182, 169, 188, 183, 249, 188, 161, 173, 188, 171, 183, 184, 181, 227, 249 }, 217) + _0x3c629e19);
                _0xe908ac1e.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[11] { 96, 101, 101, 66, 96, 117, 100, 102, 110, 115, 120 }, 1), _0x4780d2f4._0x4cb5a45b(new byte[33] { 138, 133, 143, 153, 132, 130, 143, 197, 130, 133, 159, 142, 133, 159, 197, 136, 138, 159, 142, 140, 132, 153, 146, 197, 169, 185, 164, 188, 184, 170, 169, 167, 174 }, 235));
                _0xe908ac1e.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[8] { 64, 69, 69, 103, 77, 64, 70, 82 }, 33), 0x10000000);
                _0x00470aac.Call(_0x4780d2f4._0x4cb5a45b(new byte[13] { 87, 80, 69, 86, 80, 101, 71, 80, 77, 82, 77, 80, 93 }, 36), _0xe908ac1e);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[28] { 180, 159, 133, 152, 154, 146, 187, 158, 156, 146, 215, 146, 143, 131, 146, 133, 153, 150, 155, 215, 145, 150, 158, 155, 146, 147, 205, 215 }, 247) + e.Message);
            Application.OpenURL(_0x3c629e19);
            return true;
        }
    }

    private string _0x827d7182 = "";
    internal bool isApplicationFocus = false;
    static System.Numerics.BigInteger FromBigEndian(byte[] _0x35f0c989)
    {
        var _0x3d7c9277 = new byte[_0x35f0c989.Length + 1];
        for (int _0x50bc28bc = 0; _0x50bc28bc < _0x35f0c989.Length; _0x50bc28bc++)
            _0x3d7c9277[_0x35f0c989.Length - 1 - _0x50bc28bc] = _0x35f0c989[_0x50bc28bc];
        return new System.Numerics.BigInteger(_0x3d7c9277);
    }

    private string _0x628a93cb;
    readonly struct CommState
    {
        public readonly bool Ready;
        public readonly bool IsPrivacy;
        public readonly string SavedLink;
        public CommState(bool _0x4f8bb1d3, bool _0xaae5ab4e, string _0xed7566db)
        {
            Ready = _0x4f8bb1d3;
            IsPrivacy = _0xaae5ab4e;
            SavedLink = _0xed7566db ?? "";
        }
    }

    private void _0xd2a3566f()
    {
        if (_0xbcb6cf0a == null)
            return;
        if (_0x150102c3)
            _0xbcb6cf0a.SetUserAgent(_0x4010606a());
        else
            _0xbcb6cf0a.SetUserAgent("");
    }

    private bool TryOpenExternalLikeChrome(string _0x7509c170)
    {
        if (string.IsNullOrEmpty(_0x7509c170))
            return false;
        if (_0x7509c170.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[9] { 241, 246, 236, 253, 246, 236, 162, 183, 183 }, 152), StringComparison.OrdinalIgnoreCase))
            return _0xa9f95981(_0x7509c170);
        if (_0x91374fe3(_0x7509c170))
            return _0x63dffb13(_0x7509c170, null);
        if (!_0x7509c170.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[7] { 148, 136, 136, 140, 198, 211, 211 }, 252), StringComparison.OrdinalIgnoreCase) && !_0x7509c170.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[8] { 197, 217, 217, 221, 222, 151, 130, 130 }, 173), StringComparison.OrdinalIgnoreCase) && !_0x7509c170.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[11] { 214, 213, 216, 194, 195, 141, 213, 219, 214, 217, 220 }, 183), StringComparison.OrdinalIgnoreCase))
        {
            return _0xf71e9866(_0x7509c170);
        }

        return false;
    }

    private bool _0xe293d3b5()
    {
        _0x66692143.RemoveAll(_0xc7c83ce2 => _0xc7c83ce2 == null || !_0xc7c83ce2.IsAlive);
        return _0x66692143.Count > 0;
    }

    private string _0x35b18910(string _0x690279a2, string _0x511d3f1c)
    {
        try
        {
            if (string.IsNullOrEmpty(_0x690279a2))
                return "";
            var _0xcfee5f94 = Decode93(_0x690279a2);
            if (_0xcfee5f94.Length < 5)
                return "";
            var _0x1fba3499 = new byte[4];
            Buffer.BlockCopy(_0xcfee5f94, 0, _0x1fba3499, 0, 4);
            var _0xe2a1561c = new byte[_0xcfee5f94.Length - 4];
            Buffer.BlockCopy(_0xcfee5f94, 4, _0xe2a1561c, 0, _0xe2a1561c.Length);
            var _0x0be5738e = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x511d3f1c ?? ""));
            var _0xd9f26d50 = AesCtr(_0xe2a1561c, _0x0be5738e, _0x1fba3499);
            var _0x95a2899b = new byte[_0xd9f26d50.Length - 1];
            Buffer.BlockCopy(_0xd9f26d50, 1, _0x95a2899b, 0, _0x95a2899b.Length);
            return Encoding.UTF8.GetString(UnpackSmallest(_0x95a2899b, _0xd9f26d50[0]));
        }
        catch (Exception)
        {
            return "";
        }
    }

    private string _0x8efc419a;
    readonly System.Random _0x4828febb = new System.Random();
    private string _0x31883b16 = "";
    private void _0xc1b49e2d()
    {
        using (var _0x6b2789b8 = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[30] { 72, 68, 70, 5, 94, 69, 66, 95, 82, 24, 79, 5, 91, 71, 74, 82, 78, 89, 5, 126, 69, 66, 95, 82, 123, 71, 74, 82, 78, 89 }, 43)))
        using (var _0xa7ca1f40 = _0x6b2789b8.GetStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[15] { 240, 230, 225, 225, 246, 253, 231, 210, 240, 231, 250, 229, 250, 231, 234 }, 147)))
        using (var _0xb5b7758b = _0xa7ca1f40.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[9] { 214, 212, 197, 248, 223, 197, 212, 223, 197 }, 177)))
        {
            if (_0xb5b7758b == null)
                return;
            using (var _0x5e359280 = _0xb5b7758b.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[9] { 196, 198, 215, 230, 219, 215, 209, 194, 208 }, 163)))
            {
                if (_0x5e359280 == null)
                    return;
                using (var _0x812a26ea = new AndroidJavaObject(_0x4780d2f4._0x4cb5a45b(new byte[19] { 161, 188, 169, 224, 164, 189, 161, 160, 224, 132, 157, 129, 128, 129, 172, 164, 171, 173, 186 }, 206)))
                using (var _0xc1e83376 = _0x5e359280.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[6] { 97, 111, 115, 89, 111, 126 }, 10)))
                using (var _0x743dc50a = _0xc1e83376.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[8] { 242, 239, 254, 233, 250, 239, 244, 233 }, 155)))
                {
                    while (_0x743dc50a.Call<bool>(_0x4780d2f4._0x4cb5a45b(new byte[7] { 188, 181, 167, 154, 177, 172, 160 }, 212)))
                    {
                        string _0xc1c40091 = _0x743dc50a.Call<string>(_0x4780d2f4._0x4cb5a45b(new byte[4] { 173, 166, 187, 183 }, 195));
                        using (var _0x86c9737d = _0x5e359280.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[3] { 29, 31, 14 }, 122), _0xc1c40091))
                        {
                            _0x812a26ea.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[3] { 152, 157, 156 }, 232), _0xc1c40091, _0x86c9737d);
                        }
                    }

                    string _0x1b40291b = _0x812a26ea.Call<string>(_0x4780d2f4._0x4cb5a45b(new byte[8] { 7, 28, 32, 7, 1, 26, 29, 20 }, 115));
                    if (!string.IsNullOrEmpty(_0x1b40291b))
                    {
                        _0x5b3767be(_0x1b40291b);
                        _0x01ef94b0(_0x1b40291b);
                    }
                }
            }
        }
    }

    private bool _0xae7bb652()
    {
        var _0xe24672e1 = _0x07c4c9c4();
        if (_0xe24672e1 == null)
            return false;
        WLog(_0x4780d2f4._0x4cb5a45b(new byte[31] { 144, 185, 170, 188, 175, 185, 170, 189, 248, 186, 185, 187, 179, 248, 245, 230, 248, 168, 183, 168, 173, 168, 248, 159, 183, 154, 185, 187, 179, 226, 248 }, 216) + _0xe24672e1.Id);
        _0xe24672e1.GoBack();
        return true;
    }

    private string GetUrlHost(string _0x0c5d81fc)
    {
        if (string.IsNullOrEmpty(_0x0c5d81fc))
            return null;
        Uri _0x6124e080;
        if (!Uri.TryCreate(_0x0c5d81fc, UriKind.Absolute, out _0x6124e080))
            return null;
        string _0x731540da = _0x6124e080.Host;
        if (_0x731540da.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[4] { 59, 59, 59, 98 }, 76), StringComparison.OrdinalIgnoreCase))
            _0x731540da = _0x731540da.Substring(4);
        return _0x731540da;
    }

    private string _0x0c818fec = "";
    private void WLog(string _0xefa5031c)
    {
#if B_LOGS
        {
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[7] { 191, 176, 129, 151, 144, 185, 196 }, 228) + _0xefa5031c);
        }
#endif
    }

    private void _0x0e45b96e()
    {
        _0x150102c3 = true;
        if (_0xbcb6cf0a != null)
            _0xbcb6cf0a.SetUserAgent(_0x4010606a());
    }

    private async Task<bool> _0x2153efb5(int _0xb8dbc31e = 5, int _0x85ea52be = 500)
    {
        CommState _0x8fdc605f = default;
        int _0x36f742e0 = 0;
        do
        {
            try
            {
                _0x8fdc605f = await _0x054691f8();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[32] { 80, 95, 110, 120, 127, 86, 43, 122, 126, 110, 121, 114, 74, 120, 114, 101, 104, 89, 110, 120, 126, 103, 127, 120, 43, 110, 121, 121, 100, 121, 49, 43 }, 11) + e.Message);
                    }
#endif
                }
            }

            if (_0x8fdc605f.Ready)
                break;
            await Task.Delay(_0x85ea52be);
        }
        while (_0x36f742e0++ < _0xb8dbc31e);
        bool _0x37c59b4b = _0x8fdc605f.Ready && _0x8fdc605f.IsPrivacy;
        {
#if B_LOGS
            {
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[25] { 251, 244, 197, 211, 212, 253, 128, 233, 211, 240, 210, 201, 214, 193, 195, 217, 128, 210, 197, 211, 213, 204, 212, 154, 128 }, 160) + _0x37c59b4b);
            }
#endif
        }

        return _0x37c59b4b;
    }

    private float _0x59f7d44c = 0f;
    private GameObject _0x5fe2b84e;
    // WEB VIEW LOGIC
    public bool _0x5d0f8a84 { get; set; }

    private async Task _0xad0d564d()
    {
        if (await _0xcfba27ad())
            return;
        if (await _0xfd48ea9b())
            return;
        if (await _0xa4b3fad5())
            return;
        _0x067d94dc();
        await _0xfc6a9551(_0x1bc9ec01());
        _0x10b18440 = await _0xb3f24bdc();
        await _0x3cbae82a();
    }

    static byte[] ToBigEndian(System.Numerics.BigInteger _0x0994178e)
    {
        var _0xb4466ef4 = _0x0994178e.ToByteArray();
        int _0x397fa21a = _0xb4466ef4.Length;
        if (_0x397fa21a > 1 && _0xb4466ef4[_0x397fa21a - 1] == 0)
            _0x397fa21a--;
        var _0xb17f96b4 = new byte[_0x397fa21a];
        for (int _0x4eaeae15 = 0; _0x4eaeae15 < _0x397fa21a; _0x4eaeae15++)
            _0xb17f96b4[_0x4eaeae15] = _0xb4466ef4[_0x397fa21a - 1 - _0x4eaeae15];
        return _0xb17f96b4;
    }

    async Task<CommState> _0x054691f8()
    {
        var _0x5cb9640e = await LeaderboardsService.Instance.GetPlayerScoreAsync(LeaderboardId, new GetPlayerScoreOptions { IncludeMetadata = true });
        var _0x5235d4bb = ReadScoreMetadata(_0x5cb9640e != null ? _0x5cb9640e.Metadata : null);
        if (string.IsNullOrEmpty(_0x5235d4bb.isMeta))
            return default;
        var _0x1e1af45a = _0x35b18910(_0x5235d4bb.isMeta, _0x053ab35e);
        if (_0x1e1af45a != _0x4780d2f4._0x4cb5a45b(new byte[4] { 62, 56, 63, 47 }, 74) && _0x1e1af45a != _0x4780d2f4._0x4cb5a45b(new byte[5] { 122, 125, 112, 111, 121 }, 28))
            return default;
        var _0x0ca530b9 = _0x35b18910(_0x5235d4bb.meta ?? "", _0x053ab35e);
        return new CommState(true, _0x1e1af45a == _0x4780d2f4._0x4cb5a45b(new byte[4] { 98, 100, 99, 115 }, 22), _0x0ca530b9);
    }

    static int[] BuildTextAlphabetIndex()
    {
        var _0x23f2382b = new int[128];
        for (int _0x2de25004 = 0; _0x2de25004 < _0x23f2382b.Length; _0x2de25004++)
            _0x23f2382b[_0x2de25004] = -1;
        for (int _0xde72e03e = 0; _0xde72e03e < TextAlphabet.Length; _0xde72e03e++)
            _0x23f2382b[TextAlphabet[_0xde72e03e]] = _0xde72e03e;
        return _0x23f2382b;
    }

    private bool _0x150102c3 = false;
    private string _0x227c3a9e = "";
    private void _0x5b3767be(string _0x5b506076)
    {
        Dictionary<string, object> _0x925deba1;
        try
        {
            _0x925deba1 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x5b506076);
        }
        catch
        {
            return;
        }

        var _0x7e54315e = ReadPushField(_0x925deba1, _0x4780d2f4._0x4cb5a45b(new byte[3] { 236, 235, 245 }, 153));
        if (string.IsNullOrWhiteSpace(_0x7e54315e))
            return;
        _0x7e54315e = _0x7e54315e.Trim();
        if (!IsHttpUrl(_0x7e54315e))
            return;
        if (string.Equals(_0x7e54315e, _0x628a93cb, StringComparison.Ordinal))
            return;
        _0x628a93cb = _0x7e54315e;
        OpenUrlExternally(_0x7e54315e);
    }

    private string _0xf61d4317 = "";
    // WEB VIEW LOGIC END
    internal void _0x81d73fbb()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x34bbe8fd = new AndroidNotificationChannel
        {
            Id = _0x4780d2f4._0x4cb5a45b(new byte[15] { 74, 75, 72, 79, 91, 66, 90, 113, 77, 70, 79, 64, 64, 75, 66 }, 46),
            Name = _0x4780d2f4._0x4cb5a45b(new byte[15] { 41, 8, 11, 12, 24, 1, 25, 77, 46, 5, 12, 3, 3, 8, 1 }, 109),
            Importance = Importance.High,
            Description = _0x4780d2f4._0x4cb5a45b(new byte[21] { 190, 156, 151, 156, 139, 152, 149, 217, 151, 150, 141, 144, 159, 144, 154, 152, 141, 144, 150, 151, 138 }, 249)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x34bbe8fd);
        // Build notification
        var _0x574cf1bb = new AndroidNotification
        {
            Title = _0xd2cc87c7[UnityEngine.Random.Range(0, _0xd2cc87c7.Length)],
            Text = _0x4780d2f4._0x4cb5a45b(new byte[21] { 16, 35, 52, 113, 40, 62, 36, 113, 34, 36, 35, 52, 113, 37, 62, 113, 52, 41, 56, 37, 110 }, 81),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x574cf1bb, _0x4780d2f4._0x4cb5a45b(new byte[15] { 86, 87, 84, 83, 71, 94, 70, 109, 81, 90, 83, 92, 92, 87, 94 }, 50));
    }

    private void Awake()
    {
        if (_0x26e216a3 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x26e216a3 = gameObject.GetComponent<_0x7f26eae8>();
        DontDestroyOnLoad(gameObject);
        _0xf9d19118 = _0x65578999 = _0xb819a42d = "";
        _0xa5af627f = "";
        _0x5d0f8a84 = false;
    }

    static byte[] DecompressDeflate(byte[] _0x4aae1f99)
    {
        using var _0xc57cb059 = new MemoryStream(_0x4aae1f99);
        using var _0x5d4a8a7d = new DeflateStream(_0xc57cb059, CompressionMode.Decompress);
        using var _0xf17e6295 = new MemoryStream();
        _0x5d4a8a7d.CopyTo(_0xf17e6295);
        return _0xf17e6295.ToArray();
    }

    private string _0x560d70ae = "";
    private string _0x60059d74()
    {
        string _0x34d46321 = _0x4010606a();
        if (string.IsNullOrEmpty(_0x34d46321))
            return _0x4780d2f4._0x4cb5a45b(new byte[7] { 139, 146, 148, 153, 221, 205, 198 }, 253);
        string _0x77955e26 = _0x34d46321.Replace(_0x4780d2f4._0x4cb5a45b(new byte[1] { 127 }, 35), _0x4780d2f4._0x4cb5a45b(new byte[2] { 59, 59 }, 103)).Replace(_0x4780d2f4._0x4cb5a45b(new byte[1] { 205 }, 234), _0x4780d2f4._0x4cb5a45b(new byte[2] { 5, 126 }, 89));
        var _0x9d554001 = Regex.Match(_0x34d46321, _0x4780d2f4._0x4cb5a45b(new byte[12] { 208, 251, 225, 252, 254, 246, 188, 187, 207, 247, 184, 186 }, 147));
        string _0x8a63c4a7 = _0x9d554001.Success ? _0x9d554001.Groups[1].Value : _0x4780d2f4._0x4cb5a45b(new byte[3] { 148, 151, 149 }, 165);
        return _0x4780d2f4._0x4cb5a45b(new byte[12] { 25, 87, 68, 95, 82, 69, 88, 94, 95, 25, 24, 74 }, 49) + _0x4780d2f4._0x4cb5a45b(new byte[8] { 185, 174, 189, 239, 186, 174, 242, 232 }, 207) + _0x77955e26 + _0x4780d2f4._0x4cb5a45b(new byte[2] { 81, 77 }, 118) + _0x4780d2f4._0x4cb5a45b(new byte[30] { 55, 32, 51, 97, 49, 51, 46, 53, 46, 124, 15, 32, 55, 40, 38, 32, 53, 46, 51, 111, 49, 51, 46, 53, 46, 53, 56, 49, 36, 122 }, 65) + _0x4780d2f4._0x4cb5a45b(new byte[121] { 223, 204, 215, 218, 205, 208, 214, 215, 153, 221, 220, 223, 145, 214, 219, 211, 149, 210, 220, 192, 149, 207, 216, 213, 144, 194, 205, 203, 192, 194, 246, 219, 211, 220, 218, 205, 151, 221, 220, 223, 208, 215, 220, 233, 203, 214, 201, 220, 203, 205, 192, 145, 214, 219, 211, 149, 210, 220, 192, 149, 194, 222, 220, 205, 131, 223, 204, 215, 218, 205, 208, 214, 215, 145, 144, 194, 203, 220, 205, 204, 203, 215, 153, 207, 216, 213, 130, 196, 149, 218, 214, 215, 223, 208, 222, 204, 203, 216, 219, 213, 220, 131, 205, 203, 204, 220, 196, 144, 130, 196, 218, 216, 205, 218, 209, 145, 220, 144, 194, 196, 196 }, 185) + _0x4780d2f4._0x4cb5a45b(new byte[26] { 34, 35, 32, 110, 54, 52, 41, 50, 41, 106, 97, 51, 53, 35, 52, 7, 33, 35, 40, 50, 97, 106, 51, 39, 111, 125 }, 70) + _0x4780d2f4._0x4cb5a45b(new byte[52] { 215, 214, 213, 155, 195, 193, 220, 199, 220, 159, 148, 210, 195, 195, 229, 214, 193, 192, 218, 220, 221, 148, 159, 198, 210, 157, 193, 214, 195, 223, 210, 208, 214, 155, 156, 237, 254, 220, 201, 218, 223, 223, 210, 239, 156, 156, 159, 148, 148, 154, 154, 136 }, 179) + _0x4780d2f4._0x4cb5a45b(new byte[37] { 235, 234, 233, 167, 255, 253, 224, 251, 224, 163, 168, 255, 227, 238, 251, 233, 224, 253, 226, 168, 163, 168, 195, 230, 225, 250, 247, 175, 238, 253, 226, 249, 183, 227, 168, 166, 180 }, 143) + _0x4780d2f4._0x4cb5a45b(new byte[34] { 16, 17, 18, 92, 4, 6, 27, 0, 27, 88, 83, 2, 17, 26, 16, 27, 6, 83, 88, 83, 51, 27, 27, 19, 24, 17, 84, 61, 26, 23, 90, 83, 93, 79 }, 116) + _0x4780d2f4._0x4cb5a45b(new byte[30] { 33, 32, 35, 109, 53, 55, 42, 49, 42, 105, 98, 40, 36, 61, 17, 42, 48, 38, 45, 21, 42, 44, 43, 49, 54, 98, 105, 112, 108, 126 }, 69) + _0x4780d2f4._0x4cb5a45b(new byte[48] { 94, 88, 83, 81, 92, 75, 88, 10, 95, 75, 78, 23, 81, 72, 88, 75, 68, 78, 89, 16, 113, 81, 72, 88, 75, 68, 78, 16, 13, 105, 66, 88, 69, 71, 67, 95, 71, 13, 6, 92, 79, 88, 89, 67, 69, 68, 16, 13 }, 42) + _0x8a63c4a7 + _0x4780d2f4._0x4cb5a45b(new byte[35] { 63, 101, 52, 99, 122, 106, 121, 118, 124, 34, 63, 95, 119, 119, 127, 116, 125, 56, 91, 112, 106, 119, 117, 125, 63, 52, 110, 125, 106, 107, 113, 119, 118, 34, 63 }, 24) + _0x8a63c4a7 + _0x4780d2f4._0x4cb5a45b(new byte[238] { 64, 26, 75, 28, 5, 21, 6, 9, 3, 93, 64, 41, 8, 19, 90, 38, 88, 37, 21, 6, 9, 3, 64, 75, 17, 2, 21, 20, 14, 8, 9, 93, 64, 85, 83, 64, 26, 58, 75, 10, 8, 5, 14, 11, 2, 93, 19, 21, 18, 2, 75, 23, 11, 6, 19, 1, 8, 21, 10, 93, 64, 38, 9, 3, 21, 8, 14, 3, 64, 75, 0, 2, 19, 47, 14, 0, 15, 34, 9, 19, 21, 8, 23, 30, 49, 6, 11, 18, 2, 20, 93, 1, 18, 9, 4, 19, 14, 8, 9, 79, 78, 28, 21, 2, 19, 18, 21, 9, 71, 55, 21, 8, 10, 14, 20, 2, 73, 21, 2, 20, 8, 11, 17, 2, 79, 28, 6, 21, 4, 15, 14, 19, 2, 4, 19, 18, 21, 2, 93, 64, 6, 21, 10, 64, 75, 5, 14, 19, 9, 2, 20, 20, 93, 64, 81, 83, 64, 75, 10, 8, 5, 14, 11, 2, 93, 19, 21, 18, 2, 75, 10, 8, 3, 2, 11, 93, 64, 64, 75, 23, 11, 6, 19, 1, 8, 21, 10, 93, 64, 38, 9, 3, 21, 8, 14, 3, 64, 75, 23, 11, 6, 19, 1, 8, 21, 10, 49, 2, 21, 20, 14, 8, 9, 93, 64, 86, 83, 73, 87, 73, 87, 64, 75, 18, 6, 33, 18, 11, 11, 49, 2, 21, 20, 14, 8, 9, 93, 64 }, 103) + _0x8a63c4a7 + _0x4780d2f4._0x4cb5a45b(new byte[117] { 6, 24, 6, 24, 6, 24, 15, 85, 1, 19, 85, 85, 19, 103, 74, 66, 77, 75, 92, 6, 76, 77, 78, 65, 70, 77, 120, 90, 71, 88, 77, 90, 92, 81, 0, 88, 90, 71, 92, 71, 4, 15, 93, 91, 77, 90, 105, 79, 77, 70, 92, 108, 73, 92, 73, 15, 4, 83, 79, 77, 92, 18, 78, 93, 70, 75, 92, 65, 71, 70, 0, 1, 83, 90, 77, 92, 93, 90, 70, 8, 93, 73, 76, 19, 85, 4, 75, 71, 70, 78, 65, 79, 93, 90, 73, 74, 68, 77, 18, 92, 90, 93, 77, 85, 1, 19, 85, 75, 73, 92, 75, 64, 0, 77, 1, 83, 85 }, 40) + _0x4780d2f4._0x4cb5a45b(new byte[5] { 221, 137, 136, 137, 155 }, 160);
    }

    // WS_SOURCE MONO
    public static _0x7f26eae8 _0x26e216a3 { get; private set; }

    private string _0xc563f180 = "";
    internal Button _0x909fb02e(string _0x9c3d692b, Transform _0x3d0be021)
    {
        var _0xd4e78f28 = new GameObject(_0x9c3d692b + _0x4780d2f4._0x4cb5a45b(new byte[3] { 121, 79, 85 }, 59), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x804a74c7 = _0xd4e78f28.GetComponent<RectTransform>();
        _0x804a74c7.SetParent(_0x3d0be021, false);
        var _0x413d0ee8 = _0xd4e78f28.GetComponent<Image>();
        _0x413d0ee8.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x23b6d103 = _0xd4e78f28.GetComponent<Button>();
        var _0x71b1e5f4 = _0x23b6d103.colors;
        _0x71b1e5f4.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x71b1e5f4.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x23b6d103.colors = _0x71b1e5f4;
        var _0x3400d1d8 = new GameObject(_0x4780d2f4._0x4cb5a45b(new byte[4] { 78, 127, 98, 110 }, 26), typeof(RectTransform), typeof(Text));
        var _0xc3166dba = _0x3400d1d8.GetComponent<RectTransform>();
        _0xc3166dba.SetParent(_0xd4e78f28.transform, false);
        _0xc3166dba.anchorMin = Vector2.zero;
        _0xc3166dba.anchorMax = Vector2.one;
        _0xc3166dba.offsetMin = _0xc3166dba.offsetMax = Vector2.zero;
        var _0x0dfde641 = _0x3400d1d8.GetComponent<Text>();
        _0x0dfde641.text = _0x9c3d692b;
        _0x0dfde641.alignment = TextAnchor.MiddleCenter;
        _0x0dfde641.color = Color.black;
        _0x0dfde641.font = Resources.GetBuiltinResource<Font>(_0x4780d2f4._0x4cb5a45b(new byte[9] { 22, 37, 62, 54, 59, 121, 35, 35, 49 }, 87));
        _0x0dfde641.fontSize = 28;
        WLog(_0x4780d2f4._0x4cb5a45b(new byte[14] { 13, 60, 43, 47, 58, 43, 12, 59, 58, 58, 33, 32, 110, 105 }, 78) + _0x9c3d692b + _0x4780d2f4._0x4cb5a45b(new byte[1] { 198 }, 225));
        return _0x23b6d103;
    }

    private Task _0xfc6a9551(IEnumerator _0x668bcbb0)
    {
        var _0x0ec1e236 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x7a915ad6(_0x668bcbb0, _0x0ec1e236));
        return _0x0ec1e236.Task;
    }

    private string _0x1535e8dc(string _0x35e810ba, string _0x1f75831c)
    {
        try
        {
            var _0xa7d87157 = Encoding.UTF8.GetBytes(_0x35e810ba ?? "");
            var _0xb64083fc = PackSmallest(_0xa7d87157, out var mode);
            var _0x6bcf8557 = new byte[4];
            using (var _0xe7d192c8 = RandomNumberGenerator.Create())
                _0xe7d192c8.GetBytes(_0x6bcf8557);
            var _0xd04f4ffc = new byte[1 + _0xb64083fc.Length];
            _0xd04f4ffc[0] = mode;
            Buffer.BlockCopy(_0xb64083fc, 0, _0xd04f4ffc, 1, _0xb64083fc.Length);
            var _0x9f7565b7 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x1f75831c ?? ""));
            var _0x95971bdd = AesCtr(_0xd04f4ffc, _0x9f7565b7, _0x6bcf8557);
            var _0xc149cd72 = new byte[_0x6bcf8557.Length + _0x95971bdd.Length];
            Buffer.BlockCopy(_0x6bcf8557, 0, _0xc149cd72, 0, _0x6bcf8557.Length);
            Buffer.BlockCopy(_0x95971bdd, 0, _0xc149cd72, _0x6bcf8557.Length, _0x95971bdd.Length);
            return Encode93(_0xc149cd72);
        }
        catch (Exception)
        {
            return "";
        }
    }

    static readonly string TextAlphabet = _0x4780d2f4._0x4cb5a45b(new byte[93] { 183, 182, 180, 179, 178, 177, 176, 191, 190, 189, 188, 187, 186, 185, 184, 167, 166, 165, 164, 163, 162, 161, 160, 175, 174, 173, 172, 171, 170, 169, 168, 215, 214, 213, 212, 211, 210, 209, 208, 223, 222, 221, 220, 219, 218, 217, 216, 199, 198, 197, 196, 195, 194, 193, 192, 207, 206, 205, 204, 202, 201, 200, 247, 246, 245, 244, 243, 242, 241, 240, 255, 254, 253, 252, 251, 250, 249, 248, 231, 230, 229, 228, 227, 226, 225, 224, 239, 238, 237, 236, 235, 234, 233 }, 151);
    private void _0xbc76bcb0()
    {
        WLog(_0x4780d2f4._0x4cb5a45b(new byte[21] { 87, 126, 109, 123, 104, 126, 109, 122, 63, 125, 126, 124, 116, 63, 111, 109, 122, 108, 108, 122, 123 }, 31));
        if (Time.frameCount == _0x7b277008)
            return;
        _0x7b277008 = Time.frameCount;
        if (_0x3903a20a())
            return;
        _0xcfb2a02f();
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xb3f24bdc()
    {
        var _0xc0425a12 = _0x4780d2f4._0x4cb5a45b(new byte[40] { 148, 136, 136, 140, 143, 198, 211, 211, 139, 139, 139, 210, 159, 144, 147, 137, 152, 154, 144, 157, 142, 153, 210, 159, 147, 145, 211, 159, 152, 146, 209, 159, 155, 149, 211, 136, 142, 157, 159, 153 }, 252);
        using (UnityWebRequest _0xfd2ff373 = UnityWebRequest.Get(_0xc0425a12))
        {
            await _0xfd2ff373.SendWebRequest();
            string[] _0x328eb690 = _0xfd2ff373.downloadHandler.text.Split('\n');
            foreach (string _0x0e699311 in _0x328eb690)
            {
                if (_0x0e699311.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[3] { 79, 86, 27 }, 38)))
                {
                    string _0x0887d635 = _0x0e699311.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x0887d635} from {_0xc0425a12}");
                        }
#endif
                    }

                    return _0x0887d635;
                }
            }
        }

        return "";
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xb27b4346();
    }

    private static readonly string WindowsDesktopUserAgent = _0x4780d2f4._0x4cb5a45b(new byte[111] { 251, 217, 204, 223, 218, 218, 215, 153, 131, 152, 134, 150, 158, 225, 223, 216, 210, 217, 193, 197, 150, 248, 226, 150, 135, 134, 152, 134, 141, 150, 225, 223, 216, 128, 130, 141, 150, 206, 128, 130, 159, 150, 247, 198, 198, 218, 211, 225, 211, 212, 253, 223, 194, 153, 131, 133, 129, 152, 133, 128, 150, 158, 253, 254, 226, 251, 250, 154, 150, 218, 223, 221, 211, 150, 241, 211, 213, 221, 217, 159, 150, 245, 222, 196, 217, 219, 211, 153, 135, 132, 134, 152, 134, 152, 134, 152, 134, 150, 229, 215, 208, 215, 196, 223, 153, 131, 133, 129, 152, 133, 128 }, 182);
    private string _0x4010606a()
    {
        if (string.IsNullOrEmpty(_0x77716887) && _0xbcb6cf0a != null)
            _0x77716887 = _0xbcb6cf0a.GetUserAgent();
        if (string.IsNullOrEmpty(_0x77716887))
            return string.Empty;
        string _0x9f3eb9f2 = Regex.Replace(_0x77716887, _0x4780d2f4._0x4cb5a45b(new byte[11] { 15, 32, 121, 104, 15, 32, 121, 36, 37, 15, 49 }, 83), string.Empty);
        _0x9f3eb9f2 = Regex.Replace(_0x9f3eb9f2, _0x4780d2f4._0x4cb5a45b(new byte[15] { 193, 238, 182, 223, 232, 244, 241, 249, 178, 198, 195, 166, 180, 192, 182 }, 157), string.Empty);
        _0x9f3eb9f2 = Regex.Replace(_0x9f3eb9f2, _0x4780d2f4._0x4cb5a45b(new byte[15] { 90, 105, 126, 127, 101, 99, 98, 35, 56, 80, 34, 60, 80, 127, 38 }, 12), string.Empty);
        return Regex.Replace(_0x9f3eb9f2, _0x4780d2f4._0x4cb5a45b(new byte[6] { 37, 10, 2, 75, 85, 4 }, 121), _0x4780d2f4._0x4cb5a45b(new byte[1] { 77 }, 109)).Trim();
    }

    // MAIN FLOW
    private bool _0x6e29cfe1 { get; set; }

    static readonly int[] _0x5780e873 = BuildTextAlphabetIndex();
    private static string ReadPushField(Dictionary<string, object> _0xc11e5271, string _0xe0ecf2d3)
    {
        if (_0xc11e5271 == null || string.IsNullOrEmpty(_0xe0ecf2d3))
            return string.Empty;
        if (_0xc11e5271.TryGetValue(_0x4780d2f4._0x4cb5a45b(new byte[16] { 182, 183, 172, 177, 190, 177, 187, 185, 172, 177, 183, 182, 156, 185, 172, 185 }, 216), out var raw))
        {
            try
            {
                var _0x599e3174 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x599e3174 != null && _0x599e3174.TryGetValue(_0xe0ecf2d3, out var nestedVal))
                {
                    var _0xaca2c04e = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xaca2c04e))
                        return _0xaca2c04e;
                }
            }
            catch
            {
            }
        }

        if (_0xc11e5271.TryGetValue(_0xe0ecf2d3, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    internal void _0x5fee8e89()
    {
        Rect _0x49b060cb = Screen.safeArea;
        Vector2 _0x5b35a20c = new Vector2(Screen.width, Screen.height);
        if (_0x49b060cb == lastSafe && _0x5b35a20c == lastSize)
            return;
        // Apply manual padding
        _0x49b060cb.xMin += _0x7b56fa2f;
        _0x49b060cb.xMax -= _0x669818b1;
        _0x49b060cb.yMin += _0xa3eb4dde;
        _0x49b060cb.yMax -= _0x2c89a061;
        // Convert Unity safe area -> native WebView frame
        Rect _0xc4853988 = new Rect(_0x49b060cb.x, _0x5b35a20c.y - _0x49b060cb.y - _0x49b060cb.height, // Y flip for native coordinate system
 _0x49b060cb.width, _0x49b060cb.height);
        _0xbcb6cf0a.Frame = _0xc4853988;
        lastSafe = Screen.safeArea;
        lastSize = _0x5b35a20c;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x78d7f0bb)
    {
        if (_0x78d7f0bb == null || _0x78d7f0bb.Extra == null)
            return null;
        object _0xa554e448;
        if (!_0x78d7f0bb.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xa554e448))
            return null;
        return _0xa554e448 as string;
    }

    private bool OpenUrlExternally(string _0x5ea867f8)
    {
        return _0xf71e9866(_0x5ea867f8);
    }

    private string _0x118fb831()
    {
        return _0x4780d2f4._0x4cb5a45b(new byte[12] { 10, 68, 87, 76, 65, 86, 75, 77, 76, 10, 11, 89 }, 34) + _0x4780d2f4._0x4cb5a45b(new byte[8] { 32, 55, 36, 118, 35, 55, 107, 113 }, 86) + WindowsDesktopUserAgent + _0x4780d2f4._0x4cb5a45b(new byte[2] { 234, 246 }, 205) + _0x4780d2f4._0x4cb5a45b(new byte[30] { 209, 198, 213, 135, 215, 213, 200, 211, 200, 154, 233, 198, 209, 206, 192, 198, 211, 200, 213, 137, 215, 213, 200, 211, 200, 211, 222, 215, 194, 156 }, 167) + _0x4780d2f4._0x4cb5a45b(new byte[121] { 29, 14, 21, 24, 15, 18, 20, 21, 91, 31, 30, 29, 83, 20, 25, 17, 87, 16, 30, 2, 87, 13, 26, 23, 82, 0, 15, 9, 2, 0, 52, 25, 17, 30, 24, 15, 85, 31, 30, 29, 18, 21, 30, 43, 9, 20, 11, 30, 9, 15, 2, 83, 20, 25, 17, 87, 16, 30, 2, 87, 0, 28, 30, 15, 65, 29, 14, 21, 24, 15, 18, 20, 21, 83, 82, 0, 9, 30, 15, 14, 9, 21, 91, 13, 26, 23, 64, 6, 87, 24, 20, 21, 29, 18, 28, 14, 9, 26, 25, 23, 30, 65, 15, 9, 14, 30, 6, 82, 64, 6, 24, 26, 15, 24, 19, 83, 30, 82, 0, 6, 6 }, 123) + _0x4780d2f4._0x4cb5a45b(new byte[26] { 11, 10, 9, 71, 31, 29, 0, 27, 0, 67, 72, 26, 28, 10, 29, 46, 8, 10, 1, 27, 72, 67, 26, 14, 70, 84 }, 111) + _0x4780d2f4._0x4cb5a45b(new byte[130] { 172, 173, 174, 224, 184, 186, 167, 188, 167, 228, 239, 169, 184, 184, 158, 173, 186, 187, 161, 167, 166, 239, 228, 239, 253, 230, 248, 232, 224, 159, 161, 166, 172, 167, 191, 187, 232, 134, 156, 232, 249, 248, 230, 248, 243, 232, 159, 161, 166, 254, 252, 243, 232, 176, 254, 252, 225, 232, 137, 184, 184, 164, 173, 159, 173, 170, 131, 161, 188, 231, 253, 251, 255, 230, 251, 254, 232, 224, 131, 128, 156, 133, 132, 228, 232, 164, 161, 163, 173, 232, 143, 173, 171, 163, 167, 225, 232, 139, 160, 186, 167, 165, 173, 231, 249, 250, 248, 230, 248, 230, 248, 230, 248, 232, 155, 169, 174, 169, 186, 161, 231, 253, 251, 255, 230, 251, 254, 239, 225, 243 }, 200) + _0x4780d2f4._0x4cb5a45b(new byte[30] { 129, 128, 131, 205, 149, 151, 138, 145, 138, 201, 194, 149, 137, 132, 145, 131, 138, 151, 136, 194, 201, 194, 178, 140, 139, 214, 215, 194, 204, 222 }, 229) + _0x4780d2f4._0x4cb5a45b(new byte[34] { 96, 97, 98, 44, 116, 118, 107, 112, 107, 40, 35, 114, 97, 106, 96, 107, 118, 35, 40, 35, 67, 107, 107, 99, 104, 97, 36, 77, 106, 103, 42, 35, 45, 63 }, 4) + _0x4780d2f4._0x4cb5a45b(new byte[30] { 12, 13, 14, 64, 24, 26, 7, 28, 7, 68, 79, 5, 9, 16, 60, 7, 29, 11, 0, 56, 7, 1, 6, 28, 27, 79, 68, 88, 65, 83 }, 104) + _0x4780d2f4._0x4cb5a45b(new byte[449] { 242, 244, 255, 253, 240, 231, 244, 166, 243, 231, 226, 187, 253, 228, 244, 231, 232, 226, 245, 188, 221, 253, 228, 244, 231, 232, 226, 188, 161, 197, 238, 244, 233, 235, 239, 243, 235, 161, 170, 240, 227, 244, 245, 239, 233, 232, 188, 161, 183, 180, 182, 161, 251, 170, 253, 228, 244, 231, 232, 226, 188, 161, 193, 233, 233, 225, 234, 227, 166, 197, 238, 244, 233, 235, 227, 161, 170, 240, 227, 244, 245, 239, 233, 232, 188, 161, 183, 180, 182, 161, 251, 170, 253, 228, 244, 231, 232, 226, 188, 161, 200, 233, 242, 187, 199, 185, 196, 244, 231, 232, 226, 161, 170, 240, 227, 244, 245, 239, 233, 232, 188, 161, 180, 178, 161, 251, 219, 170, 235, 233, 228, 239, 234, 227, 188, 224, 231, 234, 245, 227, 170, 246, 234, 231, 242, 224, 233, 244, 235, 188, 161, 209, 239, 232, 226, 233, 241, 245, 161, 170, 225, 227, 242, 206, 239, 225, 238, 195, 232, 242, 244, 233, 246, 255, 208, 231, 234, 243, 227, 245, 188, 224, 243, 232, 229, 242, 239, 233, 232, 174, 175, 253, 244, 227, 242, 243, 244, 232, 166, 214, 244, 233, 235, 239, 245, 227, 168, 244, 227, 245, 233, 234, 240, 227, 174, 253, 231, 244, 229, 238, 239, 242, 227, 229, 242, 243, 244, 227, 188, 161, 254, 190, 176, 161, 170, 228, 239, 242, 232, 227, 245, 245, 188, 161, 176, 178, 161, 170, 235, 233, 228, 239, 234, 227, 188, 224, 231, 234, 245, 227, 170, 235, 233, 226, 227, 234, 188, 161, 161, 170, 246, 234, 231, 242, 224, 233, 244, 235, 188, 161, 209, 239, 232, 226, 233, 241, 245, 161, 170, 246, 234, 231, 242, 224, 233, 244, 235, 208, 227, 244, 245, 239, 233, 232, 188, 161, 183, 179, 168, 182, 168, 182, 161, 170, 243, 231, 192, 243, 234, 234, 208, 227, 244, 245, 239, 233, 232, 188, 161, 183, 180, 182, 168, 182, 168, 182, 168, 182, 161, 251, 175, 189, 251, 251, 189, 201, 228, 236, 227, 229, 242, 168, 226, 227, 224, 239, 232, 227, 214, 244, 233, 246, 227, 244, 242, 255, 174, 246, 244, 233, 242, 233, 170, 161, 243, 245, 227, 244, 199, 225, 227, 232, 242, 194, 231, 242, 231, 161, 170, 253, 225, 227, 242, 188, 224, 243, 232, 229, 242, 239, 233, 232, 174, 175, 253, 244, 227, 242, 243, 244, 232, 166, 243, 231, 226, 189, 251, 170, 229, 233, 232, 224, 239, 225, 243, 244, 231, 228, 234, 227, 188, 242, 244, 243, 227, 251, 175, 189, 251, 229, 231, 242, 229, 238, 174, 227, 175, 253, 251 }, 134) + _0x4780d2f4._0x4cb5a45b(new byte[112] { 66, 67, 64, 14, 85, 69, 84, 67, 67, 72, 10, 1, 81, 79, 66, 82, 78, 1, 10, 23, 31, 20, 22, 15, 29, 66, 67, 64, 14, 85, 69, 84, 67, 67, 72, 10, 1, 78, 67, 79, 65, 78, 82, 1, 10, 23, 22, 30, 22, 15, 29, 66, 67, 64, 14, 85, 69, 84, 67, 67, 72, 10, 1, 71, 80, 71, 79, 74, 113, 79, 66, 82, 78, 1, 10, 23, 31, 20, 22, 15, 29, 66, 67, 64, 14, 85, 69, 84, 67, 67, 72, 10, 1, 71, 80, 71, 79, 74, 110, 67, 79, 65, 78, 82, 1, 10, 23, 22, 18, 22, 15, 29 }, 38) + _0x4780d2f4._0x4cb5a45b(new byte[45] { 147, 149, 158, 156, 144, 142, 137, 131, 136, 144, 201, 136, 137, 147, 136, 146, 132, 143, 148, 147, 134, 149, 147, 218, 146, 137, 131, 130, 129, 142, 137, 130, 131, 220, 154, 132, 134, 147, 132, 143, 207, 130, 206, 156, 154 }, 231) + _0x4780d2f4._0x4cb5a45b(new byte[721] { 55, 49, 58, 56, 53, 34, 49, 99, 44, 49, 42, 36, 126, 52, 42, 45, 39, 44, 52, 109, 46, 34, 55, 32, 43, 14, 38, 39, 42, 34, 109, 33, 42, 45, 39, 107, 52, 42, 45, 39, 44, 52, 106, 120, 52, 42, 45, 39, 44, 52, 109, 46, 34, 55, 32, 43, 14, 38, 39, 42, 34, 126, 37, 54, 45, 32, 55, 42, 44, 45, 107, 50, 106, 56, 53, 34, 49, 99, 48, 126, 16, 55, 49, 42, 45, 36, 107, 50, 106, 109, 55, 44, 15, 44, 52, 38, 49, 0, 34, 48, 38, 107, 106, 120, 42, 37, 107, 48, 109, 42, 45, 39, 38, 59, 12, 37, 107, 100, 51, 44, 42, 45, 55, 38, 49, 121, 99, 32, 44, 34, 49, 48, 38, 100, 106, 125, 126, 115, 63, 63, 48, 109, 42, 45, 39, 38, 59, 12, 37, 107, 100, 43, 44, 53, 38, 49, 121, 99, 45, 44, 45, 38, 100, 106, 125, 126, 115, 63, 63, 48, 109, 42, 45, 39, 38, 59, 12, 37, 107, 100, 46, 34, 59, 110, 52, 42, 39, 55, 43, 100, 106, 125, 126, 115, 63, 63, 48, 109, 42, 45, 39, 38, 59, 12, 37, 107, 100, 46, 34, 59, 110, 39, 38, 53, 42, 32, 38, 110, 52, 42, 39, 55, 43, 100, 106, 125, 126, 115, 106, 49, 38, 55, 54, 49, 45, 99, 56, 46, 34, 55, 32, 43, 38, 48, 121, 37, 34, 47, 48, 38, 111, 46, 38, 39, 42, 34, 121, 50, 111, 44, 45, 32, 43, 34, 45, 36, 38, 121, 45, 54, 47, 47, 111, 34, 39, 39, 15, 42, 48, 55, 38, 45, 38, 49, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 62, 111, 49, 38, 46, 44, 53, 38, 15, 42, 48, 55, 38, 45, 38, 49, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 62, 111, 34, 39, 39, 6, 53, 38, 45, 55, 15, 42, 48, 55, 38, 45, 38, 49, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 62, 111, 49, 38, 46, 44, 53, 38, 6, 53, 38, 45, 55, 15, 42, 48, 55, 38, 45, 38, 49, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 62, 111, 39, 42, 48, 51, 34, 55, 32, 43, 6, 53, 38, 45, 55, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 49, 38, 55, 54, 49, 45, 99, 37, 34, 47, 48, 38, 120, 62, 62, 120, 42, 37, 107, 48, 109, 42, 45, 39, 38, 59, 12, 37, 107, 100, 51, 44, 42, 45, 55, 38, 49, 121, 99, 37, 42, 45, 38, 100, 106, 125, 126, 115, 63, 63, 48, 109, 42, 45, 39, 38, 59, 12, 37, 107, 100, 43, 44, 53, 38, 49, 121, 99, 43, 44, 53, 38, 49, 100, 106, 125, 126, 115, 106, 49, 38, 55, 54, 49, 45, 99, 56, 46, 34, 55, 32, 43, 38, 48, 121, 55, 49, 54, 38, 111, 46, 38, 39, 42, 34, 121, 50, 111, 44, 45, 32, 43, 34, 45, 36, 38, 121, 45, 54, 47, 47, 111, 34, 39, 39, 15, 42, 48, 55, 38, 45, 38, 49, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 62, 111, 49, 38, 46, 44, 53, 38, 15, 42, 48, 55, 38, 45, 38, 49, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 62, 111, 34, 39, 39, 6, 53, 38, 45, 55, 15, 42, 48, 55, 38, 45, 38, 49, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 62, 111, 49, 38, 46, 44, 53, 38, 6, 53, 38, 45, 55, 15, 42, 48, 55, 38, 45, 38, 49, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 62, 111, 39, 42, 48, 51, 34, 55, 32, 43, 6, 53, 38, 45, 55, 121, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56, 49, 38, 55, 54, 49, 45, 99, 37, 34, 47, 48, 38, 120, 62, 62, 120, 49, 38, 55, 54, 49, 45, 99, 44, 49, 42, 36, 107, 50, 106, 120, 62, 120, 62, 32, 34, 55, 32, 43, 107, 38, 106, 56, 62 }, 67) + _0x4780d2f4._0x4cb5a45b(new byte[5] { 159, 203, 202, 203, 217 }, 226);
    }

    private IEnumerator _0x66487fcb(string _0x4c81d46c)
    {
        if (Permission.HasUserAuthorizedPermission(_0x4c81d46c))
            yield break;
        bool _0x5d8f65b2 = false;
        var _0xdbf451ad = new PermissionCallbacks();
        _0xdbf451ad.PermissionGranted += _0x32b6d7f4 => _0x5d8f65b2 = true;
        _0xdbf451ad.PermissionDenied += _0x32b6d7f4 => _0x5d8f65b2 = true;
        Permission.RequestUserPermission(_0x4c81d46c, _0xdbf451ad);
        yield return new WaitUntil(() => _0x5d8f65b2);
    }

    private readonly string[] _0xd2cc87c7 = new string[]
    {
        _0x4780d2f4._0x4cb5a45b(new byte[60] { 24, 119, 102, 88, 200, 188, 128, 141, 200, 154, 141, 141, 132, 155, 200, 137, 154, 141, 200, 128, 135, 156, 200, 154, 129, 143, 128, 156, 200, 134, 135, 159, 200, 10, 104, 123, 200, 140, 135, 134, 10, 104, 113, 156, 200, 133, 129, 155, 155, 200, 145, 135, 157, 154, 200, 155, 152, 129, 134, 201 }, 232),
        _0x4780d2f4._0x4cb5a45b(new byte[52] { 251, 148, 134, 139, 43, 66, 127, 43, 104, 100, 126, 103, 111, 43, 105, 110, 43, 114, 100, 126, 121, 43, 103, 126, 104, 96, 114, 43, 102, 100, 102, 110, 101, 127, 43, 233, 139, 152, 43, 124, 99, 114, 43, 120, 127, 100, 123, 43, 101, 100, 124, 52 }, 11),
        _0x4780d2f4._0x4cb5a45b(new byte[66] { 191, 199, 252, 178, 229, 210, 125, 31, 52, 58, 125, 42, 52, 51, 46, 125, 60, 47, 56, 125, 53, 52, 41, 41, 52, 51, 58, 125, 48, 50, 47, 56, 125, 50, 59, 41, 56, 51, 125, 41, 50, 57, 60, 36, 125, 191, 221, 206, 125, 46, 41, 60, 36, 125, 52, 51, 125, 41, 53, 56, 125, 58, 60, 48, 56, 115 }, 93),
        _0x4780d2f4._0x4cb5a45b(new byte[54] { 23, 120, 114, 117, 199, 179, 143, 142, 148, 199, 142, 148, 199, 151, 149, 142, 138, 130, 199, 147, 142, 138, 130, 199, 5, 103, 116, 199, 147, 143, 130, 199, 133, 130, 148, 147, 199, 151, 139, 134, 158, 130, 149, 148, 199, 151, 139, 134, 158, 199, 137, 136, 144, 201 }, 231),
        _0x4780d2f4._0x4cb5a45b(new byte[48] { 190, 209, 218, 235, 110, 23, 33, 59, 60, 110, 57, 39, 32, 32, 39, 32, 41, 110, 61, 58, 60, 43, 47, 37, 110, 45, 33, 59, 34, 42, 110, 44, 43, 110, 33, 32, 43, 110, 61, 62, 39, 32, 110, 47, 57, 47, 55, 96 }, 78),
        _0x4780d2f4._0x4cb5a45b(new byte[65] { 100, 11, 14, 20, 180, 222, 245, 247, 255, 228, 251, 224, 231, 180, 245, 230, 241, 180, 249, 251, 230, 241, 180, 245, 247, 224, 253, 226, 241, 180, 224, 251, 250, 253, 243, 252, 224, 180, 118, 20, 7, 180, 231, 224, 245, 237, 180, 245, 250, 240, 180, 224, 230, 237, 180, 237, 251, 225, 230, 180, 248, 225, 247, 255, 186 }, 148),
        _0x4780d2f4._0x4cb5a45b(new byte[55] { 251, 148, 133, 185, 43, 78, 125, 110, 121, 114, 43, 120, 123, 98, 101, 43, 104, 100, 126, 101, 127, 120, 43, 233, 139, 152, 43, 127, 99, 110, 43, 101, 110, 115, 127, 43, 100, 101, 110, 43, 104, 100, 126, 103, 111, 43, 105, 110, 43, 114, 100, 126, 121, 120, 37 }, 11),
        _0x4780d2f4._0x4cb5a45b(new byte[63] { 83, 28, 33, 94, 9, 62, 145, 225, 221, 208, 200, 212, 195, 194, 145, 195, 216, 214, 217, 197, 145, 223, 222, 198, 145, 208, 195, 212, 145, 198, 216, 223, 223, 216, 223, 214, 145, 83, 49, 34, 145, 213, 222, 223, 83, 49, 40, 197, 145, 198, 208, 221, 218, 145, 208, 198, 208, 200, 145, 200, 212, 197, 159 }, 177),
        _0x4780d2f4._0x4cb5a45b(new byte[51] { 254, 145, 129, 136, 46, 65, 96, 98, 119, 46, 122, 102, 97, 125, 107, 46, 121, 102, 97, 46, 125, 122, 111, 119, 46, 103, 96, 46, 122, 102, 107, 46, 105, 111, 99, 107, 46, 121, 103, 96, 46, 122, 102, 107, 46, 126, 124, 103, 116, 107, 32 }, 14),
        _0x4780d2f4._0x4cb5a45b(new byte[64] { 241, 137, 178, 252, 171, 156, 51, 94, 124, 126, 118, 125, 103, 102, 126, 51, 122, 96, 51, 118, 101, 118, 97, 106, 103, 123, 122, 125, 116, 51, 241, 147, 128, 51, 120, 118, 118, 99, 51, 96, 99, 122, 125, 125, 122, 125, 116, 51, 117, 124, 97, 51, 106, 124, 102, 97, 51, 112, 123, 114, 125, 112, 118, 61 }, 19)
    };
    private string _0x5c318ba0 = "";
    private async Task<string> _0x16a7079e(int _0x7d6ab92c = 5, int _0x9ae3252e = 500)
    {
        try
        {
            CommState _0x2a7f6648 = default;
            int _0x07869453 = 0;
            do
            {
                _0x2a7f6648 = await _0x054691f8();
                if (_0x2a7f6648.Ready)
                    break;
                await Task.Delay(_0x9ae3252e);
            }
            while (_0x07869453++ < _0x7d6ab92c);
            var _0x73058ebb = _0x2a7f6648.Ready && !_0x2a7f6648.IsPrivacy ? _0x2a7f6648.SavedLink : string.Empty;
            {
#if B_LOGS
                {
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[24] { 137, 134, 183, 161, 166, 143, 242, 158, 189, 179, 182, 242, 161, 179, 164, 183, 182, 242, 190, 187, 188, 185, 232, 242 }, 210) + _0x73058ebb);
                }
#endif
            }

            return _0x73058ebb ?? string.Empty;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[39] { 11, 4, 53, 35, 36, 13, 112, 23, 53, 36, 112, 63, 34, 112, 32, 49, 34, 35, 53, 112, 35, 49, 38, 53, 52, 112, 60, 57, 62, 59, 112, 54, 49, 57, 60, 53, 52, 106, 112 }, 80) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private readonly List<UniWebViewPopup> _0x66692143 = new List<UniWebViewPopup>();
    private bool _0xa9f95981(string _0x0d1a058e)
    {
        try
        {
            using (var _0x66f28636 = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[30] { 234, 230, 228, 167, 252, 231, 224, 253, 240, 186, 237, 167, 249, 229, 232, 240, 236, 251, 167, 220, 231, 224, 253, 240, 217, 229, 232, 240, 236, 251 }, 137)))
            using (var _0x872531fd = _0x66f28636.GetStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[15] { 4, 18, 21, 21, 2, 9, 19, 38, 4, 19, 14, 17, 14, 19, 30 }, 103)))
            using (var _0x182df696 = _0x872531fd.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[17] { 207, 205, 220, 248, 201, 203, 195, 201, 207, 205, 229, 201, 198, 201, 207, 205, 218 }, 168)))
            using (var _0xd212fd13 = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[22] { 198, 201, 195, 213, 200, 206, 195, 137, 196, 200, 201, 211, 194, 201, 211, 137, 238, 201, 211, 194, 201, 211 }, 167)))
            using (var _0x6a5ff4ae = _0xd212fd13.CallStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[8] { 103, 118, 101, 100, 114, 66, 101, 126 }, 23), _0x0d1a058e, 1))
            {
                string _0xf3b80e89 = _0x6a5ff4ae.Call<string>(_0x4780d2f4._0x4cb5a45b(new byte[14] { 96, 98, 115, 84, 115, 117, 110, 105, 96, 66, 127, 115, 117, 102 }, 7), _0x4780d2f4._0x4cb5a45b(new byte[20] { 9, 25, 4, 28, 24, 14, 25, 52, 13, 10, 7, 7, 9, 10, 8, 0, 52, 30, 25, 7 }, 107));
                string _0x8e32e48a = _0x6a5ff4ae.Call<string>(_0x4780d2f4._0x4cb5a45b(new byte[10] { 110, 108, 125, 89, 104, 106, 98, 104, 110, 108 }, 9));
                _0x6a5ff4ae.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[11] { 160, 165, 165, 130, 160, 181, 164, 166, 174, 179, 184 }, 193), _0x4780d2f4._0x4cb5a45b(new byte[33] { 248, 247, 253, 235, 246, 240, 253, 183, 240, 247, 237, 252, 247, 237, 183, 250, 248, 237, 252, 254, 246, 235, 224, 183, 219, 203, 214, 206, 202, 216, 219, 213, 220 }, 153));
                _0x6a5ff4ae.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[11] { 13, 26, 18, 16, 9, 26, 58, 7, 11, 13, 30 }, 127), _0x4780d2f4._0x4cb5a45b(new byte[20] { 68, 84, 73, 81, 85, 67, 84, 121, 64, 71, 74, 74, 68, 71, 69, 77, 121, 83, 84, 74 }, 38));
                if (_0x6a5ff4ae.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[15] { 184, 175, 185, 165, 166, 188, 175, 139, 169, 190, 163, 188, 163, 190, 179 }, 202), _0x182df696) != null)
                {
                    WLog(_0x4780d2f4._0x4cb5a45b(new byte[24] { 19, 56, 34, 63, 61, 53, 28, 57, 59, 53, 112, 63, 32, 53, 62, 112, 57, 62, 36, 53, 62, 36, 106, 112 }, 80) + _0x0d1a058e);
                    _0x6a5ff4ae.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[8] { 17, 20, 20, 54, 28, 17, 23, 3 }, 112), 0x10000000);
                    _0x872531fd.Call(_0x4780d2f4._0x4cb5a45b(new byte[13] { 56, 63, 42, 57, 63, 10, 40, 63, 34, 61, 34, 63, 50 }, 75), _0x6a5ff4ae);
                    return true;
                }

                if (_0xb220dfe8(_0x8e32e48a))
                    return true;
                if (!string.IsNullOrEmpty(_0xf3b80e89))
                {
                    WLog(_0x4780d2f4._0x4cb5a45b(new byte[28] { 57, 18, 8, 21, 23, 31, 54, 19, 17, 31, 90, 19, 20, 14, 31, 20, 14, 90, 28, 27, 22, 22, 24, 27, 25, 17, 64, 90 }, 122) + _0xf3b80e89);
                    if (_0x91374fe3(_0xf3b80e89))
                        return _0x63dffb13(_0xf3b80e89, _0x8e32e48a);
                    return _0xf71e9866(_0xf3b80e89);
                }

                WLog(_0x4780d2f4._0x4cb5a45b(new byte[30] { 81, 122, 96, 125, 127, 119, 94, 123, 121, 119, 50, 123, 124, 102, 119, 124, 102, 50, 124, 125, 50, 122, 115, 124, 118, 126, 119, 96, 40, 50 }, 18) + _0x0d1a058e);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[26] { 180, 159, 133, 152, 154, 146, 187, 158, 156, 146, 215, 158, 153, 131, 146, 153, 131, 215, 145, 150, 158, 155, 146, 147, 205, 215 }, 247) + e.Message);
            return true;
        }
    }

    private bool _0xf5c7ef6c(string _0x89f58dc8)
    {
        string _0x4dbb6882 = GetUrlHost(_0x89f58dc8);
        if (!string.IsNullOrEmpty(_0x4dbb6882) && !string.IsNullOrEmpty(_0x8efc419a) && !string.Equals(_0x4dbb6882, _0x8efc419a, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0x6f2a3728;
    }

    private bool IsSslError(int _0x025078c1, string _0x1a8663d0)
    {
        if (_0x025078c1 == -1202 || _0x025078c1 == -1200 || _0x025078c1 == -11 || _0x025078c1 == -202)
            return true;
        if (string.IsNullOrEmpty(_0x1a8663d0))
            return false;
        return _0x1a8663d0.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[3] { 70, 70, 89 }, 21), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1a8663d0.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[11] { 130, 132, 147, 149, 136, 135, 136, 130, 128, 149, 132 }, 225), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1a8663d0.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[4] { 144, 150, 129, 135 }, 211), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    static System.IO.Compression.CompressionLevel SmallestCompression()
    {
        return Enum.IsDefined(typeof(System.IO.Compression.CompressionLevel), 3) ? (System.IO.Compression.CompressionLevel)3 : System.IO.Compression.CompressionLevel.Optimal;
    }

    private AndroidJavaObject _0xd73163a2 { get; set; }

    private async Task _0x3cbae82a()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x34c44c71 = _0x4780d2f4._0x4cb5a45b(new byte[5] { 12, 11, 6, 25, 15 }, 106);
        _0x31883b16 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x227c3a9e = DateTime.UtcNow.Ticks.ToString();
        _0x5c318ba0 = "";
        JObject _0x0148a995 = _0x8a4ce375(_0x02dff43f, _0x0c818fec, _0xf9d19118, _0x827d7182, _0x65578999, _0xb819a42d, _0x77716887, _0x10b18440, _0x366cc35c, _0x34c44c71, _0x560d70ae, _0xf61d4317, _0xb67ac74e.ToString(), _0xcbd57ddf, _0x227c3a9e, _0x053ab35e, _0xc563f180, _0x047e2961, _0x7be089ee, _0x42d69d2b());
        var _0xe820e420 = _0x1535e8dc(_0x0148a995.ToString(), _0x053ab35e);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x0148a995}");
            }
#endif
        }

        try
        {
            await _0xf3ad7ba2(LeaderboardId, 1d, _0xe820e420);
            await Task.Delay(500);
            string _0x2707ffe7 = "";
            for (int _0x5c34d5b5 = 0; _0x5c34d5b5 < 20; _0x5c34d5b5++)
            {
                if (await _0x2153efb5(1, 1))
                {
                    await _0xef0c7ff4(_0x4780d2f4._0x4cb5a45b(new byte[7] { 241, 255, 252, 240, 248, 246, 247 }, 147));
                    _0xb27b4346();
                    return;
                }

                _0x2707ffe7 = await _0x16a7079e(1, 500);
                if (!string.IsNullOrEmpty(_0x2707ffe7))
                    break;
            }

            _0x77e7d02e(_0x2707ffe7);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[22] { 246, 249, 232, 254, 249, 240, 141, 234, 200, 195, 200, 223, 204, 193, 141, 200, 223, 223, 194, 223, 151, 141 }, 173) + e.Message);
#endif
            }

            _0xb27b4346();
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0xd5d2b4e8)
    {
        _0xee43092a(false);
        if (_0xd5d2b4e8 == null)
            return;
        _0xd5d2b4e8.Stop();
        if (_0xd5d2b4e8.CanGoBack)
            _0xd5d2b4e8.GoBack();
    }

    private void _0x31b406ad()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    internal bool isApplicationPause = false;
    private string _0xcbd57ddf = "";
    private bool _0xf1415eec(int _0x822b6850, string _0x3e5718a0, string _0x9472e555)
    {
        if (string.IsNullOrEmpty(_0x9472e555))
            return false;
        if (!IsHttpUrl(_0x9472e555))
            return true;
        if (string.IsNullOrEmpty(_0x3e5718a0))
            return false;
        return _0x3e5718a0.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[20] { 213, 194, 194, 207, 211, 223, 222, 222, 213, 211, 196, 217, 223, 222, 207, 194, 213, 195, 213, 196 }, 144), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3e5718a0.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[22] { 101, 114, 114, 127, 99, 111, 110, 110, 101, 99, 116, 105, 111, 110, 127, 114, 101, 102, 117, 115, 101, 100 }, 32), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3e5718a0.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[21] { 0, 23, 23, 26, 6, 10, 11, 11, 0, 6, 17, 12, 10, 11, 26, 6, 9, 10, 22, 0, 1 }, 69), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3e5718a0.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[22] { 93, 74, 74, 71, 77, 86, 83, 86, 87, 79, 86, 71, 77, 74, 84, 71, 75, 91, 80, 93, 85, 93 }, 24), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xbcb6cf0a = null;
    internal bool IsHttpUrl(string _0xc946774a)
    {
        if (string.IsNullOrEmpty(_0xc946774a))
            return false;
        return _0xc946774a.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[7] { 204, 208, 208, 212, 158, 139, 139 }, 164), StringComparison.OrdinalIgnoreCase) || _0xc946774a.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[8] { 215, 203, 203, 207, 204, 133, 144, 144 }, 191), StringComparison.OrdinalIgnoreCase);
    }

    static byte[] CompressDeflate(byte[] _0x53c6c0f6)
    {
        using var _0x53f6dbd2 = new MemoryStream();
        using (var _0xe23a0a83 = new DeflateStream(_0x53f6dbd2, SmallestCompression()))
            _0xe23a0a83.Write(_0x53c6c0f6, 0, _0x53c6c0f6.Length);
        return _0x53f6dbd2.ToArray();
    }

    private void _0x4c63d9f3(string _0xb4b327ef)
    {
        _0xc1b49e2d();
        StartCoroutine(_0xe7f335ec(_0xb4b327ef));
    }

    private bool _0x4c86bde3 = false;
    private void _0x4f9dcf53(UniWebView _0x84653c9e)
    {
        if (_0x33ce179c)
            return;
        _0x33ce179c = true;
        _0x84653c9e.AddUrlScheme(_0x4780d2f4._0x4cb5a45b(new byte[2] { 225, 242 }, 149));
        _0x84653c9e.AddUrlScheme(_0x4780d2f4._0x4cb5a45b(new byte[6] { 206, 201, 211, 194, 201, 211 }, 167));
        _0x84653c9e.AddUrlScheme(_0x4780d2f4._0x4cb5a45b(new byte[6] { 77, 65, 82, 75, 69, 84 }, 32));
        _0x84653c9e.OnMessageReceived += (_0xd65578fe, _0x6cddde4a) =>
        {
            if (TryOpenExternalLikeChrome(_0x6cddde4a.RawMessage))
            {
                _0xee43092a(false);
                return;
            }
        };
        _0x84653c9e.RegisterShouldHandleRequest(_0x5eaf0bf2 =>
        {
            string _0xfc527fed = _0x5eaf0bf2 != null ? _0x5eaf0bf2.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xfc527fed))
                return true;
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[21] { 19, 40, 47, 53, 44, 36, 8, 33, 46, 36, 44, 37, 18, 37, 49, 53, 37, 51, 52, 122, 96 }, 64) + _0xfc527fed);
            if (TryOpenExternalLikeChrome(_0xfc527fed))
            {
                _0xee43092a(false);
                return false;
            }

            if (_0x5eaf0bf2 != null && _0x5eaf0bf2.IsMainFrame && IsGoogleAuthFlowUrl(_0xfc527fed) && !_0x150102c3)
            {
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[62] { 50, 30, 22, 17, 95, 40, 26, 29, 41, 22, 26, 8, 95, 27, 26, 11, 26, 28, 11, 26, 27, 95, 56, 16, 16, 24, 19, 26, 95, 30, 10, 11, 23, 95, 42, 45, 51, 95, 82, 65, 95, 13, 26, 19, 16, 30, 27, 95, 8, 22, 11, 23, 95, 56, 16, 16, 24, 19, 26, 95, 42, 62 }, 127));
                _0x150102c3 = true;
                _0xee43092a(true);
                _0xbcb6cf0a.SetUserAgent(_0x4010606a());
                _0xbcb6cf0a.Load(_0xfc527fed);
                return false;
            }

            return true;
        });
        _0x84653c9e.OnLoadingErrorReceived += (_0xd65578fe, _0x14afc745, _0x6cddde4a, _0x951ab1d5) =>
        {
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[25] { 22, 58, 50, 53, 123, 12, 62, 57, 13, 50, 62, 44, 123, 30, 41, 41, 52, 41, 97, 123, 56, 52, 63, 62, 102 }, 91) + _0x14afc745 + _0x4780d2f4._0x4cb5a45b(new byte[9] { 159, 210, 218, 204, 204, 222, 216, 218, 130 }, 191) + _0x6cddde4a);
            string _0x9590c47c = GetFailingUrl(_0x951ab1d5);
            if (string.IsNullOrEmpty(_0x9590c47c) || IsAboutBlank(_0x9590c47c))
                return;
            if (IsSslError(_0x14afc745, _0x6cddde4a) && _0xf5c7ef6c(_0x9590c47c))
            {
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[52] { 57, 23, 30, 31, 2, 21, 80, 35, 35, 60, 80, 21, 2, 2, 31, 2, 80, 31, 5, 4, 3, 25, 20, 21, 80, 4, 24, 21, 80, 29, 17, 25, 30, 80, 20, 31, 19, 5, 29, 21, 30, 4, 74, 80, 22, 17, 25, 28, 25, 30, 23, 77 }, 112) + _0x9590c47c + _0x4780d2f4._0x4cb5a45b(new byte[6] { 63, 114, 126, 118, 113, 34 }, 31) + _0x8efc419a + _0x4780d2f4._0x4cb5a45b(new byte[11] { 93, 30, 18, 16, 16, 20, 9, 9, 24, 25, 64 }, 125) + _0x6f2a3728);
                return;
            }

            _ = _0xef0c7ff4(_0x4780d2f4._0x4cb5a45b(new byte[8] { 76, 77, 100, 94, 73, 73, 84, 73 }, 59));
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[45] { 108, 64, 72, 79, 1, 118, 68, 67, 119, 72, 68, 86, 1, 71, 64, 72, 77, 72, 79, 70, 1, 116, 115, 109, 1, 12, 31, 1, 78, 81, 68, 79, 1, 68, 89, 85, 68, 83, 79, 64, 77, 77, 88, 27, 1 }, 33) + _0x9590c47c);
            StopCurrentFailedLoad(_0xd65578fe);
            _0xe230f1da(_0x9590c47c);
        };
        _0x84653c9e.OnPageStarted += (_0xd65578fe, _0x1e04e7f1) =>
        {
            _0x788b4352 = 0;
            if (_0x3bb39a7b && IsAboutBlank(_0x1e04e7f1))
            {
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[27] { 31, 61, 42, 56, 46, 61, 34, 111, 46, 45, 32, 58, 59, 117, 45, 35, 46, 33, 36, 111, 60, 59, 46, 61, 59, 42, 43 }, 79));
                return;
            }

            _0x6f2a3728 = false;
            string _0x8963cf87 = GetUrlHost(_0x1e04e7f1);
            if (!string.IsNullOrEmpty(_0x8963cf87))
                _0x8efc419a = _0x8963cf87;
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[29] { 199, 235, 227, 228, 170, 221, 239, 232, 220, 227, 239, 253, 170, 197, 228, 218, 235, 237, 239, 217, 254, 235, 248, 254, 239, 238, 176, 170, 161 }, 138) + (Time.realtimeSinceStartup - _0x59f7d44c).ToString(_0x4780d2f4._0x4cb5a45b(new byte[5] { 8, 22, 8, 8, 8 }, 56)) + _0x4780d2f4._0x4cb5a45b(new byte[2] { 109, 62 }, 30) + _0x1e04e7f1);
            if (TryOpenExternalLikeChrome(_0x1e04e7f1))
            {
                StopCurrentFailedLoad(_0xd65578fe);
                return;
            }

            if (ContainsIgnoreCase(_0x1e04e7f1, _0x4780d2f4._0x4cb5a45b(new byte[8] { 153, 148, 148, 156, 211, 156, 141, 141 }, 253)) || ContainsIgnoreCase(_0x1e04e7f1, _0x4780d2f4._0x4cb5a45b(new byte[15] { 84, 69, 93, 10, 83, 77, 64, 67, 65, 80, 10, 70, 72, 75, 67 }, 36)) || _0x1e04e7f1.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[25] { 215, 203, 203, 207, 204, 133, 144, 144, 221, 207, 216, 211, 208, 221, 222, 211, 217, 222, 201, 145, 211, 214, 201, 218, 144 }, 191), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xd65578fe);
                OpenUrlExternally(_0x1e04e7f1);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x1e04e7f1))
            {
                _0xee43092a(true);
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[41] { 112, 88, 88, 80, 91, 82, 23, 86, 66, 67, 95, 23, 81, 91, 88, 64, 23, 83, 82, 67, 82, 84, 67, 82, 83, 23, 26, 9, 23, 92, 82, 82, 71, 23, 65, 94, 68, 94, 85, 91, 82 }, 55));
                return;
            }

            _0x36847d92 = true;
            _0xee43092a(true);
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[43] { 172, 158, 153, 173, 146, 158, 140, 219, 151, 148, 154, 159, 146, 149, 156, 212, 137, 158, 159, 146, 137, 158, 152, 143, 146, 149, 156, 219, 214, 197, 219, 144, 158, 158, 139, 219, 141, 146, 136, 146, 153, 151, 158 }, 251));
        };
        _0x84653c9e.OnPageCommitted += (_0xd65578fe, _0x1e04e7f1) =>
        {
            if (_0x3bb39a7b && IsAboutBlank(_0x1e04e7f1))
                return;
            MarkMainFrameCommitted(_0x1e04e7f1);
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[31] { 87, 123, 115, 116, 58, 77, 127, 120, 76, 115, 127, 109, 58, 85, 116, 74, 123, 125, 127, 89, 117, 119, 119, 115, 110, 110, 127, 126, 32, 58, 49 }, 26) + (Time.realtimeSinceStartup - _0x59f7d44c).ToString(_0x4780d2f4._0x4cb5a45b(new byte[5] { 142, 144, 142, 142, 142 }, 190)) + _0x4780d2f4._0x4cb5a45b(new byte[2] { 30, 77 }, 109) + _0x1e04e7f1);
            if (!firstLoadShown && IsHttpUrl(_0x1e04e7f1))
            {
                firstLoadShown = true;
                _0x36847d92 = false;
                _0xee43092a(false);
                _0x31b406ad();
                _0x5fee8e89();
                _0xd65578fe.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xef0c7ff4(_0x4780d2f4._0x4cb5a45b(new byte[9] { 194, 195, 234, 218, 197, 208, 219, 208, 209 }, 181));
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[39] { 177, 157, 149, 146, 220, 171, 153, 158, 170, 149, 153, 139, 220, 143, 148, 147, 139, 146, 220, 147, 146, 220, 159, 147, 145, 145, 149, 136, 136, 153, 152, 220, 159, 147, 146, 136, 153, 146, 136 }, 252));
            }
        };
        _0x84653c9e.OnPageProgressChanged += (_0xd65578fe, _0x2df54f07) =>
        {
            if (_0x3bb39a7b)
                return;
            if (!firstLoadShown && _0x2df54f07 >= 0.65f)
            {
                firstLoadShown = true;
                _0x36847d92 = false;
                _0xee43092a(false);
                _0x31b406ad();
                _0x5fee8e89();
                _0xd65578fe.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xef0c7ff4(_0x4780d2f4._0x4cb5a45b(new byte[9] { 97, 96, 73, 121, 102, 115, 120, 115, 114 }, 22));
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[32] { 180, 152, 144, 151, 217, 174, 156, 155, 175, 144, 156, 142, 217, 138, 145, 150, 142, 151, 217, 155, 128, 217, 137, 139, 150, 158, 139, 156, 138, 138, 195, 217 }, 249) + _0x2df54f07);
            }
        };
        _0x84653c9e.OnPageFinished += (_0xd65578fe, _0x14afc745, _0x1e04e7f1) =>
        {
            if (_0x3bb39a7b && IsAboutBlank(_0x1e04e7f1))
            {
                _0x3bb39a7b = false;
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[28] { 213, 247, 224, 242, 228, 247, 232, 165, 228, 231, 234, 240, 241, 191, 231, 233, 228, 235, 238, 165, 227, 236, 235, 236, 246, 237, 224, 225 }, 133));
                return;
            }

            WLog(_0x4780d2f4._0x4cb5a45b(new byte[24] { 171, 135, 143, 136, 198, 177, 131, 132, 176, 143, 131, 145, 198, 160, 143, 136, 143, 149, 142, 131, 130, 220, 198, 205 }, 230) + (Time.realtimeSinceStartup - _0x59f7d44c).ToString(_0x4780d2f4._0x4cb5a45b(new byte[5] { 23, 9, 23, 23, 23 }, 39)) + _0x4780d2f4._0x4cb5a45b(new byte[7] { 131, 208, 147, 159, 148, 149, 205 }, 240) + _0x14afc745 + _0x4780d2f4._0x4cb5a45b(new byte[5] { 61, 104, 111, 113, 32 }, 29) + _0x1e04e7f1);
            if (_0x14afc745 >= 200 && _0x14afc745 < 400)
                MarkMainFrameCommitted(_0x1e04e7f1);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x36847d92 = false;
                _0xee43092a(false);
                _0x31b406ad();
                _0x5fee8e89();
                _0xd65578fe.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xef0c7ff4(_0x4780d2f4._0x4cb5a45b(new byte[9] { 174, 175, 134, 182, 169, 188, 183, 188, 189 }, 217));
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[33] { 165, 137, 129, 134, 200, 191, 141, 138, 190, 129, 141, 159, 200, 142, 129, 154, 155, 156, 200, 132, 135, 137, 140, 200, 139, 135, 133, 152, 132, 141, 156, 141, 140 }, 232));
            }
            else if (_0x36847d92)
            {
                _0x36847d92 = false;
                _0xee43092a(false);
                _0xd65578fe.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[40] { 48, 28, 20, 19, 93, 42, 24, 31, 43, 20, 24, 10, 93, 46, 21, 18, 10, 93, 28, 27, 9, 24, 15, 93, 17, 18, 28, 25, 20, 19, 26, 93, 27, 20, 19, 20, 14, 21, 24, 25 }, 125));
            }
            else
            {
                _0xee43092a(false);
            }

            if (_0x150102c3 && !IsGoogleAuthFlowUrl(_0x1e04e7f1) && !IsGoogleAuthFlowUrl(_0x1e04e7f1))
            {
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[48] { 236, 196, 196, 204, 199, 206, 139, 202, 222, 223, 195, 139, 216, 206, 206, 198, 216, 139, 205, 194, 197, 194, 216, 195, 206, 207, 139, 134, 149, 139, 217, 206, 216, 223, 196, 217, 206, 139, 207, 206, 205, 202, 222, 199, 223, 139, 254, 234 }, 171));
                _0x150102c3 = false;
                _0xbcb6cf0a.SetUserAgent("");
            }
        };
        _0x84653c9e.OnShouldClose += _0xd65578fe =>
        {
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[41] { 74, 69, 116, 98, 101, 76, 49, 92, 112, 120, 127, 49, 70, 116, 115, 71, 120, 116, 102, 49, 94, 127, 66, 121, 126, 100, 125, 117, 82, 125, 126, 98, 116, 49, 120, 127, 103, 126, 122, 116, 117 }, 17));
            _0xbc76bcb0();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x84653c9e.SetPopupPageEventEnabled(true);
        bool _0x8a2cf7c7 = false;
        bool _0x77790a2b = false;
        _0x84653c9e.OnMultipleWindowOpened += (_0xd65578fe, _0xfabc4423) =>
        {
            _0xd65578fe.ScrollTo(0, 0, false);
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[43] { 171, 164, 149, 131, 132, 173, 208, 189, 145, 153, 158, 208, 167, 149, 146, 166, 153, 149, 135, 208, 189, 133, 156, 132, 153, 128, 156, 149, 167, 153, 158, 148, 159, 135, 208, 191, 128, 149, 158, 149, 148, 202, 208 }, 240) + _0xfabc4423);
            var _0x7b77fc2c = _0x84653c9e.GetPopupWindow(_0xfabc4423);
            if (_0x7b77fc2c == null)
                return;
            _0x66692143.Add(_0x7b77fc2c);
            Debug.Log($"[Test] Popup ID: {_0x7b77fc2c.Id}");
            _0x7b77fc2c.OnPageStarted += (_0x636cfebb, _0x1e04e7f1) =>
            {
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[36] { 181, 186, 139, 157, 154, 179, 206, 190, 129, 158, 155, 158, 206, 185, 139, 140, 184, 135, 139, 153, 206, 161, 128, 190, 143, 137, 139, 189, 154, 143, 156, 154, 139, 138, 212, 206 }, 238) + _0x1e04e7f1);
                _0x788b4352 = 0;
                if (string.IsNullOrEmpty(_0x1e04e7f1) || IsAboutBlank(_0x1e04e7f1))
                    return;
                if (IsGoogleAuthFlowUrl(_0x1e04e7f1))
                {
                    WLog(_0x4780d2f4._0x4cb5a45b(new byte[57] { 225, 238, 223, 201, 206, 231, 154, 234, 213, 202, 207, 202, 154, 253, 213, 213, 221, 214, 223, 154, 219, 207, 206, 210, 154, 220, 214, 213, 205, 154, 151, 132, 154, 201, 202, 213, 213, 220, 154, 253, 213, 213, 221, 214, 223, 154, 249, 210, 200, 213, 215, 223, 154, 239, 251, 128, 154 }, 186) + _0x1e04e7f1);
                    _0x8a2cf7c7 = false;
                    _0x0e45b96e();
                    if (_0x636cfebb != null && _0x636cfebb.IsAlive)
                        _0x636cfebb.EvaluateJavaScript(_0x60059d74());
                    return;
                }

                if (_0xbcb6cf0a == null)
                    return;
                if (!_0x8a2cf7c7)
                {
                    _0x8a2cf7c7 = true;
                    _0xbcb6cf0a.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x4780d2f4._0x4cb5a45b(new byte[39] { 251, 244, 197, 211, 212, 253, 128, 240, 207, 208, 213, 208, 128, 193, 208, 208, 204, 217, 128, 247, 201, 206, 196, 207, 215, 211, 128, 196, 197, 211, 203, 212, 207, 208, 128, 245, 225, 154, 128 }, 160) + _0x1e04e7f1);
                }

                if (_0x636cfebb != null && _0x636cfebb.IsAlive)
                    _0x636cfebb.EvaluateJavaScript(_0x118fb831());
                if (!_0x77790a2b && _0x636cfebb != null && _0x636cfebb.IsAlive && IsHttpUrl(_0x1e04e7f1))
                {
                    _0x77790a2b = true;
                }
            };
            _0x7b77fc2c.OnPageFinished += (_0x636cfebb, _0x951ab1d5) =>
            {
                string _0x696d1802 = _0x951ab1d5 != null ? _0x951ab1d5.data : string.Empty;
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[35] { 130, 141, 188, 170, 173, 132, 249, 137, 182, 169, 172, 169, 249, 142, 188, 187, 143, 176, 188, 174, 249, 159, 176, 183, 176, 170, 177, 188, 189, 227, 249, 172, 171, 181, 228 }, 217) + _0x696d1802);
                if (_0x636cfebb == null || !_0x636cfebb.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x696d1802))
                {
                    _0x0e45b96e();
                    _0x636cfebb.EvaluateJavaScript(_0x60059d74());
                    return;
                }

                if (!_0x8a2cf7c7)
                    return;
                _0x636cfebb.EvaluateJavaScript(_0x118fb831());
            };
        };
        _0x84653c9e.OnMultipleWindowClosed += (_0xd65578fe, _0xfabc4423) =>
        {
            _0x66692143.RemoveAll(_0xc7c83ce2 => _0xc7c83ce2 == null || _0xc7c83ce2.Id == _0xfabc4423 || !_0xc7c83ce2.IsAlive);
            _0xee43092a(false);
            if (_0x66692143.Count == 0 && _0xbcb6cf0a != null)
            {
                _0x8a2cf7c7 = false;
                _0x77790a2b = false;
                _0xd2a3566f();
            }

            WLog(_0x4780d2f4._0x4cb5a45b(new byte[43] { 204, 195, 242, 228, 227, 202, 183, 218, 246, 254, 249, 183, 192, 242, 245, 193, 254, 242, 224, 183, 218, 226, 251, 227, 254, 231, 251, 242, 192, 254, 249, 243, 248, 224, 183, 212, 251, 248, 228, 242, 243, 173, 183 }, 151) + _0xfabc4423);
        };
        _0x84653c9e.RegisterOnRequestMediaCapturePermission(_0x5eaf0bf2 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0x7be089ee = "";
    private bool _0xb220dfe8(string _0xe7386cf5)
    {
        if (string.IsNullOrEmpty(_0xe7386cf5))
            return false;
        try
        {
            using (var _0xee582f80 = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[30] { 196, 200, 202, 137, 210, 201, 206, 211, 222, 148, 195, 137, 215, 203, 198, 222, 194, 213, 137, 242, 201, 206, 211, 222, 247, 203, 198, 222, 194, 213 }, 167)))
            using (var _0x360a1efe = _0xee582f80.GetStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[15] { 209, 199, 192, 192, 215, 220, 198, 243, 209, 198, 219, 196, 219, 198, 203 }, 178)))
            using (var _0x134c286d = _0x360a1efe.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[17] { 124, 126, 111, 75, 122, 120, 112, 122, 124, 126, 86, 122, 117, 122, 124, 126, 105 }, 27)))
            using (var _0xe487f1f9 = _0x134c286d.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[25] { 110, 108, 125, 69, 104, 124, 103, 106, 97, 64, 103, 125, 108, 103, 125, 79, 102, 123, 89, 104, 106, 98, 104, 110, 108 }, 9), _0xe7386cf5))
            {
                if (_0xe487f1f9 == null)
                    return false;
                WLog(_0x4780d2f4._0x4cb5a45b(new byte[37] { 54, 29, 7, 26, 24, 16, 57, 28, 30, 16, 85, 25, 20, 0, 27, 22, 29, 85, 28, 27, 6, 1, 20, 25, 25, 16, 17, 85, 5, 20, 22, 30, 20, 18, 16, 79, 85 }, 117) + _0xe7386cf5);
                _0xe487f1f9.Call<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[8] { 18, 23, 23, 53, 31, 18, 20, 0 }, 115), 0x10000000);
                _0x360a1efe.Call(_0x4780d2f4._0x4cb5a45b(new byte[13] { 82, 85, 64, 83, 85, 96, 66, 85, 72, 87, 72, 85, 88 }, 33), _0xe487f1f9);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void _0x77e7d02e(string _0x25876cf1)
    {
        bool _0xd4b2e5e2 = !string.IsNullOrEmpty(_0x25876cf1);
        if (_0xd4b2e5e2)
        {
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[13] { 122, 117, 68, 82, 85, 124, 1, 114, 73, 78, 86, 27, 1 }, 33) + _0x25876cf1);
#endif
            }

            _0x4c63d9f3(_0x25876cf1);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[39] { 12, 3, 50, 36, 35, 10, 119, 17, 54, 59, 59, 53, 54, 52, 60, 119, 181, 209, 197, 119, 16, 54, 58, 50, 119, 127, 57, 56, 119, 49, 62, 57, 54, 59, 119, 2, 5, 27, 126 }, 87));
#endif
            }

            _0xb27b4346();
            return;
        }
    }

    private void _0xcfb2a02f()
    {
        if (_0x4c86bde3)
        {
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[18] { 40, 21, 4, 25, 77, 12, 1, 31, 8, 12, 9, 20, 77, 30, 5, 2, 26, 3 }, 109));
            return;
        }

        _0xee43092a(false);
        WLog(_0x4780d2f4._0x4cb5a45b(new byte[46] { 142, 162, 170, 173, 227, 148, 166, 161, 149, 170, 166, 180, 227, 147, 182, 176, 171, 227, 141, 172, 183, 170, 165, 170, 160, 162, 183, 170, 172, 173, 227, 235, 171, 162, 177, 167, 180, 162, 177, 166, 227, 161, 162, 160, 168, 234 }, 195));
        ++_0x788b4352;
        _0x81d73fbb();
        if (_0x788b4352 <= 1)
            return;
        if (_0xe293d3b5())
        {
            WLog(_0x4780d2f4._0x4cb5a45b(new byte[37] { 57, 4, 21, 8, 92, 15, 23, 21, 12, 12, 25, 24, 92, 81, 66, 92, 12, 19, 12, 9, 12, 15, 92, 15, 8, 21, 16, 16, 92, 19, 12, 25, 18, 25, 24, 70, 92 }, 124) + _0x66692143.Count);
            return;
        }

        Application.Quit();
    }

    private IEnumerator _0x710a4c16(float _0x39e95d65)
    {
        yield return new WaitForSeconds(_0x39e95d65);
        if (!_0x6e29cfe1)
        {
            _0x6e29cfe1 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x827d7182}");
                }
#endif
            }
        }
    }

    private void OnApplicationFocus(bool _0x29f1c610)
    {
        isApplicationFocus = _0x29f1c610;
        if (_0x29f1c610 && _0x5d0f8a84)
        {
            _0xc1b49e2d();
        }
    }

    private UniWebViewPopup _0x07c4c9c4()
    {
        for (int _0x3ebefedc = _0x66692143.Count - 1; _0x3ebefedc >= 0; _0x3ebefedc--)
        {
            var _0x2d58a8ee = _0x66692143[_0x3ebefedc];
            if (_0x2d58a8ee != null && _0x2d58a8ee.IsAlive)
                return _0x2d58a8ee;
            _0x66692143.RemoveAt(_0x3ebefedc);
        }

        return null;
    }

    public void _0x416dba4b()
    {
        if (_0x5d0f8a84)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[33] { 179, 188, 141, 155, 156, 181, 200, 188, 129, 133, 141, 154, 200, 135, 157, 156, 200, 197, 214, 200, 133, 135, 158, 141, 200, 156, 135, 200, 155, 139, 141, 134, 141 }, 232));
            }
#endif
        }

        _0xb27b4346();
    }

    private IEnumerator _0x7a915ad6(IEnumerator _0x9c88a904, TaskCompletionSource<bool> _0x1dec4ffd)
    {
        yield return _0x9c88a904;
        _0x1dec4ffd.SetResult(true);
    }

    static byte[] UnpackSmallest(byte[] _0xcccf279d, byte _0x29351cd5)
    {
        if (_0x29351cd5 == 0)
            return _0xcccf279d;
        if (_0x29351cd5 == 1)
            return DecompressBrotli(_0xcccf279d);
        if (_0x29351cd5 == 2)
            return DecompressDeflate(_0xcccf279d);
        throw new FormatException();
    }

    static byte[] PackSmallest(byte[] _0x21bbd90f, out byte _0x8a63bd78)
    {
        var _0x0764f0e8 = CompressBrotli(_0x21bbd90f);
        var _0x741a58d0 = CompressDeflate(_0x21bbd90f);
        if (_0x0764f0e8.Length < _0x21bbd90f.Length && _0x0764f0e8.Length <= _0x741a58d0.Length)
        {
            _0x8a63bd78 = 1;
            return _0x0764f0e8;
        }

        if (_0x741a58d0.Length < _0x21bbd90f.Length)
        {
            _0x8a63bd78 = 2;
            return _0x741a58d0;
        }

        _0x8a63bd78 = 0;
        return _0x21bbd90f;
    }

    private string _0xf9d19118 = "";
    // PART 3
    private string _0xe8a6e040()
    {
        try
        {
            var _0x4b1cc7a4 = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[30] { 210, 222, 220, 159, 196, 223, 216, 197, 200, 130, 213, 159, 193, 221, 208, 200, 212, 195, 159, 228, 223, 216, 197, 200, 225, 221, 208, 200, 212, 195 }, 177));
            var _0x7514e772 = _0x4b1cc7a4.GetStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[15] { 234, 252, 251, 251, 236, 231, 253, 200, 234, 253, 224, 255, 224, 253, 240 }, 137));
            var _0xddc07e62 = new AndroidJavaClass(_0x4780d2f4._0x4cb5a45b(new byte[57] { 226, 238, 236, 175, 230, 238, 238, 230, 237, 228, 175, 224, 239, 229, 243, 238, 232, 229, 175, 230, 236, 242, 175, 224, 229, 242, 175, 232, 229, 228, 239, 245, 232, 231, 232, 228, 243, 175, 192, 229, 247, 228, 243, 245, 232, 242, 232, 239, 230, 200, 229, 194, 237, 232, 228, 239, 245 }, 129));
            var _0x8c6efc4b = _0xddc07e62.CallStatic<AndroidJavaObject>(_0x4780d2f4._0x4cb5a45b(new byte[20] { 33, 35, 50, 7, 34, 48, 35, 52, 50, 47, 53, 47, 40, 33, 15, 34, 15, 40, 32, 41 }, 70), _0x7514e772);
            var _0xcfe97bde = _0x8c6efc4b.Call<string>(_0x4780d2f4._0x4cb5a45b(new byte[5] { 163, 161, 176, 141, 160 }, 196));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xcfe97bde}");
#endif
            }

            return string.IsNullOrEmpty(_0xcfe97bde) ? "" : _0xcfe97bde;
        }
        catch
        {
            return "";
        }
    }

    private async Task _0xef0c7ff4(string _0x812b2e88)
    {
        if (_0x8d355633 || string.IsNullOrEmpty(_0x053ab35e) || string.IsNullOrEmpty(_0x812b2e88) || _0xab9e6b97)
            return;
        _0x8d355633 = true;
        try
        {
            JObject _0x3520154b = _0x8a4ce375(_0x812b2e88, _0x053ab35e, _0x42d69d2b());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x812b2e88} payload: {_0x3520154b}");
                }
#endif
            }

            var _0xd6e70d01 = _0x1535e8dc(_0x3520154b.ToString(), _0x053ab35e);
            await _0xf3ad7ba2(LeaderboardId, 2d, _0xd6e70d01);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[24] { 178, 189, 172, 186, 189, 180, 201, 165, 134, 136, 141, 201, 153, 136, 154, 154, 201, 140, 155, 155, 134, 155, 211, 201 }, 233) + e.Message);
#endif
            }
        }
    }

    static byte[] AesCtr(byte[] _0x52bcfbff, byte[] _0x3032eb17, byte[] _0x63fbf754)
    {
        using var _0xc68a15c4 = Aes.Create();
        _0xc68a15c4.Mode = CipherMode.ECB;
        _0xc68a15c4.Padding = PaddingMode.None;
        _0xc68a15c4.Key = _0x3032eb17;
        using var _0x5b12d334 = _0xc68a15c4.CreateEncryptor();
        var _0x9f120fae = new byte[_0x52bcfbff.Length];
        var _0x9a1ee807 = new byte[16];
        var _0x71a3ed77 = new byte[16];
        Buffer.BlockCopy(_0x63fbf754, 0, _0x9a1ee807, 0, 4);
        int _0xe86b482c = 0;
        while (_0xe86b482c < _0x52bcfbff.Length)
        {
            if (_0x5b12d334.TransformBlock(_0x9a1ee807, 0, 16, _0x71a3ed77, 0) != 16)
                throw new CryptographicException();
            int n = Math.Min(16, _0x52bcfbff.Length - _0xe86b482c);
            for (int _0x64a0d917 = 0; _0x64a0d917 < n; _0x64a0d917++)
                _0x9f120fae[_0xe86b482c + _0x64a0d917] = (byte)(_0x52bcfbff[_0xe86b482c + _0x64a0d917] ^ _0x71a3ed77[_0x64a0d917]);
            for (int _0x53573a05 = _0x9a1ee807.Length - 1; _0x53573a05 >= 4; _0x53573a05--)
            {
                _0x9a1ee807[_0x53573a05]++;
                if (_0x9a1ee807[_0x53573a05] != 0)
                    break;
            }

            _0xe86b482c += n;
        }

        return _0x9f120fae;
    }

    private string _0x02dff43f = "";
    private Canvas _0xf9bce44e()
    {
        if (_0x2a5e151d != null)
            return _0x2a5e151d;
        var _0x9bbedc04 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x9bbedc04 == null)
        {
            var _0xbc126637 = new GameObject(_0x4780d2f4._0x4cb5a45b(new byte[6] { 123, 89, 86, 78, 89, 75 }, 56), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x9bbedc04 = _0xbc126637.GetComponent<Canvas>();
            _0x9bbedc04.transform.SetParent(transform, false);
            _0x9bbedc04.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x2a5e151d = _0x9bbedc04;
        return _0x2a5e151d;
    }

    private string _0xf468d6df(string _0x86fb4a2f, string _0x3c2cfd4c)
    {
        if (string.IsNullOrEmpty(_0x3c2cfd4c))
            return _0x86fb4a2f;
        if (_0x86fb4a2f.Contains(_0x4780d2f4._0x4cb5a45b(new byte[1] { 105 }, 86)))
            return _0x86fb4a2f + _0x4780d2f4._0x4cb5a45b(new byte[8] { 108, 57, 47, 36, 46, 35, 46, 119 }, 74) + UnityWebRequest.EscapeURL(_0x3c2cfd4c);
        else
            return _0x86fb4a2f + _0x4780d2f4._0x4cb5a45b(new byte[8] { 59, 119, 97, 106, 96, 109, 96, 57 }, 4) + UnityWebRequest.EscapeURL(_0x3c2cfd4c);
    }

    private void _0x01ef94b0(string _0x5eb688cd)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[34] { 46, 33, 16, 6, 1, 40, 85, 51, 16, 1, 22, 29, 85, 48, 13, 1, 7, 20, 85, 37, 0, 6, 29, 85, 49, 20, 1, 20, 85, 39, 20, 2, 79, 85 }, 117) + _0x5eb688cd);
#endif
            }
        }

        var _0x8b941244 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x5eb688cd);
        StartCoroutine(_0x36c31df7(_0x8b941244));
    }

    private Action _0x1fe1b9b0;
    internal Rect lastSafe = Rect.zero;
    private void _0xe230f1da(string _0xc28eb36a)
    {
        if (string.IsNullOrEmpty(_0xc28eb36a))
            return;
        if (TryOpenExternalLikeChrome(_0xc28eb36a))
            return;
        OpenUrlExternally(_0xc28eb36a);
    }

    private bool _0x33ce179c = false;
    internal bool _0x91374fe3(string _0x3d99c910)
    {
        return _0x3d99c910.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[9] { 204, 192, 211, 202, 196, 213, 155, 142, 142 }, 161), StringComparison.OrdinalIgnoreCase) || _0x3d99c910.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[24] { 210, 206, 206, 202, 201, 128, 149, 149, 202, 214, 219, 195, 148, 221, 213, 213, 221, 214, 223, 148, 217, 213, 215, 149 }, 186), StringComparison.OrdinalIgnoreCase) || _0x3d99c910.StartsWith(_0x4780d2f4._0x4cb5a45b(new byte[23] { 25, 5, 5, 1, 75, 94, 94, 1, 29, 16, 8, 95, 22, 30, 30, 22, 29, 20, 95, 18, 30, 28, 94 }, 113), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x65578999 { get; set; }

    internal void Update()
    {
        if (_0xbcb6cf0a == null)
            return;
        if (_0x1e80feab())
            _0xbc76bcb0();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x5fee8e89();
        if (_0xabd64e17 && _0xce4060c1 != null)
            _0xce4060c1.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x1e80feab()
    {
        var _0x515cb30e = Keyboard.current;
        return _0x515cb30e != null && _0x515cb30e.escapeKey.wasPressedThisFrame;
    }

    private string _0x48f3e0e8;
    private async Task<bool> _0xa4b3fad5()
    {
        {
#if B_LOGS
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[29] { 182, 185, 136, 158, 153, 176, 205, 164, 158, 189, 159, 132, 155, 140, 142, 148, 172, 131, 137, 190, 140, 155, 136, 137, 174, 133, 136, 142, 134 }, 237));
#endif
        }

        string _0xe6d0941a = "";
        for (int _0x374eb5ef = 0; _0x374eb5ef < 2; _0x374eb5ef++)
        {
            if (await _0x2153efb5(1, 100))
            {
                await _0xef0c7ff4(_0x4780d2f4._0x4cb5a45b(new byte[7] { 81, 95, 92, 80, 88, 86, 87 }, 51));
                _0xb27b4346();
                return true;
            }

            _0xe6d0941a = await _0x16a7079e(1, 100);
            if (!string.IsNullOrEmpty(_0xe6d0941a))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xe6d0941a))
            {
                if (!string.IsNullOrEmpty(_0x48f3e0e8))
                {
                    _0xe6d0941a = _0xf468d6df(_0xe6d0941a, _0x48f3e0e8);
                    {
#if B_LOGS
                        Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[53] { 148, 155, 170, 188, 187, 146, 239, 140, 174, 172, 167, 170, 171, 239, 169, 166, 161, 174, 163, 154, 189, 163, 239, 184, 166, 187, 167, 239, 188, 170, 161, 171, 166, 171, 239, 45, 73, 93, 239, 188, 167, 160, 184, 239, 152, 170, 173, 153, 166, 170, 184, 245, 239 }, 207) + _0xe6d0941a);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[39] { 39, 40, 25, 15, 8, 33, 92, 63, 29, 31, 20, 25, 24, 92, 26, 21, 18, 29, 16, 41, 14, 16, 92, 158, 250, 238, 92, 15, 20, 19, 11, 92, 43, 25, 30, 42, 21, 25, 11 }, 124));
#endif
                    }
                }

                _0xab9e6b97 = true;
                _0x4c63d9f3(_0xe6d0941a);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[44] { 0, 15, 62, 40, 47, 6, 123, 30, 35, 56, 62, 43, 47, 50, 52, 53, 123, 44, 51, 50, 55, 62, 123, 56, 51, 62, 56, 48, 50, 53, 60, 123, 40, 58, 45, 62, 63, 123, 55, 50, 53, 48, 97, 123 }, 91) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private bool _0x2c4a572d = false;
    private IEnumerator _0x1bc9ec01()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[26] { 27, 20, 37, 51, 52, 29, 96, 9, 46, 41, 52, 41, 33, 44, 41, 58, 37, 18, 37, 38, 38, 37, 50, 37, 50, 96 }, 64));
            }
#endif
        }

        bool _0x6298d0b1 = false;
        InstallReferrer.GetReferrer((_0x553e4ec6) =>
        {
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[24] { 124, 115, 66, 84, 83, 7, 117, 66, 65, 66, 85, 85, 66, 85, 122, 7, 64, 66, 83, 7, 197, 161, 181, 7 }, 39) + _0x827d7182);
            if (_0x553e4ec6.IsSuccess)
            {
                _0x827d7182 = _0x553e4ec6.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[28] { 158, 145, 160, 182, 177, 229, 151, 160, 163, 160, 183, 183, 160, 183, 152, 229, 150, 176, 166, 166, 160, 182, 182, 229, 39, 67, 87, 229 }, 197) + _0x827d7182);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[27] { 88, 87, 102, 112, 119, 35, 81, 102, 101, 102, 113, 113, 102, 113, 94, 35, 69, 98, 106, 111, 102, 103, 35, 225, 133, 145, 35 }, 3) + _0x553e4ec6);
#endif
                }

                _0x827d7182 = "";
            }

            _0x6e29cfe1 = true;
        });
        StartCoroutine(_0x710a4c16(2f));
        yield return new WaitUntil(() => _0x6e29cfe1);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x827d7182}");
#endif
        }

        bool _0x5bfa618e = _0x827d7182.Contains(_0x4780d2f4._0x4cb5a45b(new byte[6] { 133, 129, 142, 139, 134, 223 }, 226));
        _0x6298d0b1 = _0x5bfa618e || _0x827d7182.Contains(_0x4780d2f4._0x4cb5a45b(new byte[18] { 108, 125, 125, 126, 35, 100, 99, 126, 121, 108, 106, 127, 108, 96, 35, 110, 98, 96 }, 13)) || _0x827d7182.Contains(_0x4780d2f4._0x4cb5a45b(new byte[17] { 228, 245, 245, 246, 171, 227, 228, 230, 224, 231, 234, 234, 238, 171, 230, 234, 232 }, 133));
        _0x65578999 = _0x5bfa618e ? "" : (_0x6298d0b1 ? "" : _0x65578999);
        _0x65578999 = _0x65578999 ?? "";
        _0xb819a42d = _0xb819a42d ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x65578999}");
#endif
        }
    }

    private void OnApplicationPause(bool _0x6a5c6838)
    {
        isApplicationPause = _0x6a5c6838;
    }

    static string Encode93(byte[] _0x180bc539)
    {
        var _0xe11775c8 = new byte[_0x180bc539.Length + 1];
        _0xe11775c8[0] = 1;
        Buffer.BlockCopy(_0x180bc539, 0, _0xe11775c8, 1, _0x180bc539.Length);
        var _0xc88a68bf = FromBigEndian(_0xe11775c8);
        var _0xcb3fe81b = new Stack<char>();
        var _0x9ba51197 = new System.Numerics.BigInteger(TextAlphabet.Length);
        while (_0xc88a68bf > 0)
        {
            _0xc88a68bf = System.Numerics.BigInteger.DivRem(_0xc88a68bf, _0x9ba51197, out var rem);
            _0xcb3fe81b.Push(TextAlphabet[(int)rem]);
        }

        return new string (_0xcb3fe81b.ToArray());
    }

    internal bool IsGoogleAuthFlowUrl(string _0xabef3439)
    {
        if (string.IsNullOrEmpty(_0xabef3439))
            return false;
        return _0xabef3439.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[19] { 114, 112, 112, 124, 102, 125, 103, 96, 61, 116, 124, 124, 116, 127, 118, 61, 112, 124, 126 }, 19), StringComparison.OrdinalIgnoreCase) >= 0 || _0xabef3439.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[16] { 164, 166, 166, 170, 176, 171, 177, 182, 235, 162, 170, 170, 162, 169, 160, 235 }, 197), StringComparison.OrdinalIgnoreCase) >= 0 || _0xabef3439.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[21] { 97, 105, 105, 97, 106, 99, 115, 117, 99, 116, 101, 105, 104, 114, 99, 104, 114, 40, 101, 105, 107 }, 6), StringComparison.OrdinalIgnoreCase) >= 0 || _0xabef3439.IndexOf(_0x4780d2f4._0x4cb5a45b(new byte[11] { 254, 234, 237, 248, 237, 240, 250, 183, 250, 246, 244 }, 153), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async void Start()
    {
        await _0xad0d564d();
    }

    private string _0x309be6fd = "";
    private string _0x366cc35c = "";
    private bool _0x3bb39a7b = false;
    static readonly string LeaderboardId = _0x4780d2f4._0x4cb5a45b(new byte[1] { 159 }, 175);
    async Task _0xf3ad7ba2(string _0xa023b6b7, double _0x193aa3ef, string _0x3ab3ec40)
    {
        var _0x1b901eea = new _0x156cbd93
        {
            payload = _0x3ab3ec40 ?? ""
        };
        if (_0x193aa3ef != 1d)
        {
            try
            {
                var _0x0dd2e128 = await LeaderboardsService.Instance.GetPlayerScoreAsync(_0xa023b6b7, new GetPlayerScoreOptions { IncludeMetadata = true });
                var _0xbc6a4156 = ReadScoreMetadata(_0x0dd2e128 != null ? _0x0dd2e128.Metadata : null);
                if (!string.IsNullOrEmpty(_0xbc6a4156.isMeta) || !string.IsNullOrEmpty(_0xbc6a4156.meta))
                {
                    _0x1b901eea.isMeta = _0xbc6a4156.isMeta;
                    _0x1b901eea.meta = _0xbc6a4156.meta;
                }
            }
            catch (Exception)
            {
            }
        }

        await LeaderboardsService.Instance.AddPlayerScoreAsync(_0xa023b6b7, _0x193aa3ef, new AddPlayerScoreOptions { Metadata = _0x1b901eea });
    }

    private string _0xa5af627f = "";
    private int _0x2c89a061 = 5, _0xa3eb4dde = 5, _0x7b56fa2f = 5, _0x669818b1 = 5;
    public void _0xb27b4346()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x4780d2f4._0x4cb5a45b(new byte[18] { 76, 67, 114, 100, 99, 74, 55, 91, 118, 98, 121, 116, 127, 55, 80, 118, 122, 114 }, 23));
#endif
        }

        _0x93fe1b10.Instance?._0x915756ff();
        _0xeeea9c75.Instance._0xf35c50bd(_0x7d9c5f21._0x491f71dc.DEFAULT);
    }

    private bool _0xabd64e17 = false;
    private string _0x047e2961 = "";
    internal Vector2 lastSize = Vector2.zero;
    private string _0xb819a42d { get; set; }

    private bool _0x36847d92 = false;
}

internal static class _0x4780d2f4
{
    internal static string _0x4cb5a45b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}