using UnityEngine;

/// <summary>
/// The images this game may reference, handed from a scene bootstrap to every view.
///
/// The art is drawn by the pipeline against a FIXED name contract, so these ten are the
/// only pictures that will ever exist: anything else resolves to no asset and Unity draws a
/// white rectangle (rule B.1). Plates, frames, bars, rings and the close cross are therefore
/// NOT art - they are the template's own 9-slice rounded sprite, which can never dangle.
///
/// No constructor (rule C.59): fields are filled by Init and the object returned.
/// </summary>
public sealed class _0x9a4ef192
{
    public Sprite[] Symbols = new Sprite[0];
    /// <summary>Symbol art by index, wrapped - the five sprites are interchangeable by contract.</summary>
    public Sprite _0x7e4623dc(int _0xc41630e6)
    {
        if (this.Symbols.Length == 0)
        {
            return null;
        }

        int _0xcc9be96a = _0xc41630e6 % this.Symbols.Length;
        return this.Symbols[_0xcc9be96a < 0 ? _0xcc9be96a + this.Symbols.Length : _0xcc9be96a];
    }

    public Sprite IconPause;
    public Sprite ButtonRect; // generated rectangular button face (9-slice)
    public Sprite Emblem; // generated abstract mark - no letters anywhere on it
    public Sprite Plate; // template 9-slice rounded plate, radius via pixelsPerUnitMultiplier
    public Sprite Solid; // template flat fill, used for scrims, rules and bars
    public Sprite IconBack;
    public _0x9a4ef192 _0x71902a68(Sprite _0x13872f49, Sprite _0x9154211e, Sprite _0x37d817d9, Sprite _0xcc2a7b42, Sprite _0x95878044, Sprite _0x04e75fa0, Sprite _0xa6746813, Sprite[] _0xd95f73b8)
    {
        this.Plate = _0x13872f49;
        this.Solid = _0x9154211e;
        this.ButtonRect = _0x37d817d9;
        this.ButtonRound = _0xcc2a7b42;
        this.Emblem = _0x95878044;
        this.IconBack = _0x04e75fa0;
        this.IconPause = _0xa6746813;
        this.Symbols = _0xd95f73b8 != null ? _0xd95f73b8 : new Sprite[0];
        return this;
    }

    public Sprite ButtonRound; // generated round button face
}