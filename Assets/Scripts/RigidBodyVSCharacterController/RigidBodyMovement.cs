using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    public float moveForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(x, 0, z ) * moveForce;
        rb.AddForce(force);
    }
}
