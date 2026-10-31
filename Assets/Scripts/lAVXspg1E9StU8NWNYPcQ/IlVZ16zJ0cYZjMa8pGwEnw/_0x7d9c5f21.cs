using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x7d9c5f21
{
    public static class _0x991ac867
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x2ad08372
    {
        public static int _0xa3be3a7a
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x7724590d._0x6a1fb6ad(new byte[5] { 24, 52, 50, 53, 40 }, 91)))
                    PlayerPrefs.SetInt(_0x7724590d._0x6a1fb6ad(new byte[5] { 33, 13, 11, 12, 17 }, 98), 0);
                return PlayerPrefs.GetInt(_0x7724590d._0x6a1fb6ad(new byte[5] { 253, 209, 215, 208, 205 }, 190));
            }

            set
            {
                PlayerPrefs.SetInt(_0x7724590d._0x6a1fb6ad(new byte[5] { 78, 98, 100, 99, 126 }, 13), value);
                _0x5b07c2df.Instance._0x35c4d9fc();
            }
        }
    }

    public static class _0x4c653446
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0x4e89534f
    {
        private static readonly _0x4e89534f _0x397e72d7 = new();
        public static readonly _0x4e89534f[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x397e72d7,
            _0x397e72d7,
            _0x397e72d7,
        };
        private int _0x4fc592c8 => 0;
        private int _0xa3395994 => 10;
        private string _0xe962ef09 => _0x7724590d._0x6a1fb6ad(new byte[4] { 61, 21, 30, 5 }, 112);
        private string _0x205e4c7a => _0x7724590d._0x6a1fb6ad(new byte[8] { 230, 239, 252, 239, 230, 209, 154, 215 }, 170);

        private int _0xe0981b7a
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x7724590d._0x6a1fb6ad(new byte[25] { 104, 94, 89, 89, 78, 69, 95, 108, 71, 68, 73, 74, 71, 104, 67, 74, 91, 95, 78, 89, 98, 69, 79, 78, 83 }, 43)))
                    PlayerPrefs.SetInt(_0x7724590d._0x6a1fb6ad(new byte[25] { 254, 200, 207, 207, 216, 211, 201, 250, 209, 210, 223, 220, 209, 254, 213, 220, 205, 201, 216, 207, 244, 211, 217, 216, 197 }, 189), 0);
                return PlayerPrefs.GetInt(_0x7724590d._0x6a1fb6ad(new byte[25] { 2, 52, 51, 51, 36, 47, 53, 6, 45, 46, 35, 32, 45, 2, 41, 32, 49, 53, 36, 51, 8, 47, 37, 36, 57 }, 65));
            }

            set => PlayerPrefs.SetInt(_0x7724590d._0x6a1fb6ad(new byte[25] { 226, 212, 211, 211, 196, 207, 213, 230, 205, 206, 195, 192, 205, 226, 201, 192, 209, 213, 196, 211, 232, 207, 197, 196, 217 }, 161), value);
        }

        public int _0xf29f4f7a
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xe962ef09}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xe962ef09}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xe962ef09}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xe962ef09}CurrentLevelIndex", value);
        }

        public int _0x30a3ef7d
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xe962ef09}BestScore"))
                    this._0x30a3ef7d = 0;
                return PlayerPrefs.GetInt($"{this._0xe962ef09}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xe962ef09}BestScore", value);
        }

        public bool _0x9ce278e8
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xe962ef09}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xe962ef09}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xe962ef09}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xe962ef09}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x491f71dc
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0x7724590d
{
    internal static string _0x6a1fb6ad(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}