using UnityEngine;
 
public class SmoothFollow: MonoBehaviour
{
    // camera will follow this object
    public Transform Target;
    //camera transform
    public Transform camTransform;
    // offset between camera and target
    public Vector3 Offset;
    // change this value to get desired smoothness
    public float SmoothTime = 0.3f;
 
    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;

    private float yaw, pitch;
 
    private void Start()
    {
        Offset = new Vector3(0,3.125f,-10);
    }
 
    private void LateUpdate()
    {
        // update position
        Vector3 targetPosition = Target.position + Offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);

        if (!Input.GetKey("left cmd"))
        {
            transform.LookAt(Target);
        }
        else
        {
            transform.RotateAround(Target.position, Vector3.up,Input.GetAxis("Horizontal"));
        }

    }
}