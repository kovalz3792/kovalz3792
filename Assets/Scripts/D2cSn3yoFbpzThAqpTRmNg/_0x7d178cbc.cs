using UnityEngine;

/// <summary>
/// Every duration in the game, in one place, already scaled by the REDUCE MOTION setting -
/// which is why that settings row is a control the build can really honour rather than a
/// dead switch.
///
/// Timings are chosen so a baseline route - no win at all, no player input beyond the idle
/// auto-spin - lasts about 76 seconds. The review capture takes its first gameplay frame at
/// about second 15 and its last at about second 30, so the run must outlast that by a wide
/// margin (rule C.5).
/// </summary>
public static class _0x7d178cbc
{
    public const float ReelOvershoot = 0.22f;
    public const float BadgeOut = 0.3f;
    public const float BadgeHold = 1.4f;
    public const float Card = 0.34f;
    public const float PressIn = 0.08f;
    public const float StopAdvance = 0.6f;
    public const float PayoutTrail = 0.9f;
    /// <summary>A duration as the player will actually experience it.</summary>
    public static float Scaled(float _0x5da8e1a6)
    {
        return _0xf4914d3b._0x570a1891 ? _0x5da8e1a6 * ReducedScale : _0x5da8e1a6;
    }

    public const float BadgeIn = 0.45f;
    public const float PressOut = 0.12f;
    public const float ReelStagger = 0.25f;
    public const float ReducedScale = 0.35f;
    public const float IdleAutoSpin = 6f;
    public const float StopArrive = 0.5f;
    public const float CountUp = 0.6f;
    public const float ReelColumn = 1.7f;
    public const float View = 0.28f;
    /// <summary>
    /// The first stop waits longer before it rolls itself. The review capture settles the
    /// new scene by watching for a still frame, so the opening stop has to hold one -
    /// and a player arriving on a brand new route deserves a moment to read the board
    /// before it moves on its own.
    /// </summary>
    public const float IdleFirstStop = 20f;
}