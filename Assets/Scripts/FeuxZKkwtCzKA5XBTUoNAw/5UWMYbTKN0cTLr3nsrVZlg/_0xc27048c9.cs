using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xc27048c9 : MonoBehaviour
{
    private new Camera _0xeefe1526;
    private float _0x969982eb = 1;
    private Vector3 _0xa02b2023 { get; set; }

    private void Awake()
    {
        this._0xeefe1526 = this.GetComponent<Camera>();
        _0x7e7d8fb2 = this;
        this._0xf92e8bb5();
    }

    private Color _0xc33f3431 = Color.white;
    private void _0xf92e8bb5()
    {
        float _0x6735f4e9, _0x84099fd5, _0x6ac89336, _0xd96340d9;
        if (this._0x126fc34b == _0xfa7282c1.Landscape)
            this._0xeefe1526.orthographicSize = 1f / this._0xeefe1526.aspect * this._0x969982eb / 2f;
        else
            this._0xeefe1526.orthographicSize = this._0x969982eb / 2f;
        this._0x6a06f9bf = 2f * this._0xeefe1526.orthographicSize;
        this._0x3aae7f60 = this._0x6a06f9bf * this._0xeefe1526.aspect;
        float _0x2ea7a215 = this._0xeefe1526.transform.position.x;
        float _0x645e6079 = this._0xeefe1526.transform.position.y;
        _0x6735f4e9 = _0x2ea7a215 - this._0x3aae7f60 / 2;
        _0x84099fd5 = _0x2ea7a215 + this._0x3aae7f60 / 2;
        _0x6ac89336 = _0x645e6079 + this._0x6a06f9bf / 2;
        _0xd96340d9 = _0x645e6079 - this._0x6a06f9bf / 2;
        this._0xece6561d = new Vector3(_0x6735f4e9, _0xd96340d9, 0);
        this._0x527f7324 = new Vector3(_0x2ea7a215, _0xd96340d9, 0);
        this._0x273f8341 = new Vector3(_0x84099fd5, _0xd96340d9, 0);
        this._0xa02b2023 = new Vector3(_0x6735f4e9, _0x645e6079, 0);
        this._0x4abda607 = new Vector3(_0x2ea7a215, _0x645e6079, 0);
        this._0x262f102c = new Vector3(_0x84099fd5, _0x645e6079, 0);
        this._0x26e20604 = new Vector3(_0x6735f4e9, _0x6ac89336, 0);
        this._0x255fe05d = new Vector3(_0x2ea7a215, _0x6ac89336, 0);
        this._0x9e562e35 = new Vector3(_0x84099fd5, _0x6ac89336, 0);
    }

    public enum _0xfa7282c1
    {
        Landscape,
        Portrait
    }

    private float _0x6a06f9bf { get; set; }
    private Vector3 _0x262f102c { get; set; }
    //public bool executeInUpdate;
    private float _0x3aae7f60 { get; set; }
    private Vector3 _0xece6561d { get; set; }

    private static _0xc27048c9 _0x7e7d8fb2;
    private Vector3 _0x255fe05d { get; set; }

    private _0xfa7282c1 _0x126fc34b = _0xfa7282c1.Portrait;
    private Vector3 _0x273f8341 { get; set; }
    private Vector3 _0x26e20604 { get; set; }
    private Vector3 _0x527f7324 { get; set; }
    private Vector3 _0x9e562e35 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xc33f3431;
        Matrix4x4 _0x957b3c4c = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xeefe1526.orthographic)
        {
            float _0xa48753d7 = this._0xeefe1526.farClipPlane - this._0xeefe1526.nearClipPlane;
            float _0x0a338c07 = (this._0xeefe1526.farClipPlane + this._0xeefe1526.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x0a338c07), new Vector3(this._0xeefe1526.orthographicSize * 2 * this._0xeefe1526.aspect, this._0xeefe1526.orthographicSize * 2, _0xa48753d7));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xeefe1526.fieldOfView, this._0xeefe1526.farClipPlane, this._0xeefe1526.nearClipPlane, this._0xeefe1526.aspect);
        }

        Gizmos.matrix = _0x957b3c4c;
    }

    private Vector3 _0x4abda607 { get; set; }
}