using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpForce = 200.0f;

    Vector3 origin;
    public float radius;
    private Vector3 direction;

    private XRRig _xrRig;
    private CapsuleCollider _collider;
    private Rigidbody _body;

    private bool IsGrounded => Physics.Raycast(
        new Vector2(transform.position.x, transform.position.y + 5.0f),
        Vector3.down, 15.0f);

    //    private bool IsGrounded => Physics.SphereCast(p1, _body.height / 2, transform.forward, out hit, 10)

    void Start()
    {
        _xrRig = GetComponent<XRRig>();
        _collider = GetComponent<CapsuleCollider>();
        _body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += OnJump;
    }

    void Update()
    {
        var center = _xrRig.cameraInRigSpacePos;
        //_collider.center = new Vector3(center.x, _collider.center.y, center.z);
        _collider.center = new Vector3(center.x, _xrRig.cameraInRigSpaceHeight / 2, center.z);
        _collider.height = _xrRig.cameraInRigSpaceHeight;

        if (IsGrounded)
        {
        }
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        if (!IsGrounded) return;
        Debug.Log("Jumping");
        //jumpActionReference.asset.Disable();
        _body.AddForce(Vector3.up * jumpForce);
    }
}
