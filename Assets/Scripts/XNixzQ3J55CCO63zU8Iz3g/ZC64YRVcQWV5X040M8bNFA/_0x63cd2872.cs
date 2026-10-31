using UnityEngine;

public class _0x63cd2872 : MonoBehaviour
{
    public bool IsOnlyWinGameEndEnabled;
    public bool IsLevelSelectorEnabled;
    private void _0x8248ed05()
    {
    }

    public bool IsBestScoreEnabled;
    private void _0xbf2bb923()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsSkipSplashEnabled;
    public bool IsTutorialEnabled;
    public static _0x63cd2872 Instance;
    public bool IsCheckScoreEnabled;
    public bool IsStoryEnabled;
    public bool IsLevelIncrementOnWin;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x63cd2872>();
            DontDestroyOnLoad(this.gameObject);
            this._0xbf2bb923();
        }
        else
        {
            this._0x8248ed05();
            Destroy(this.gameObject);
        }
    }

    public bool IsTimerEnabled;
}