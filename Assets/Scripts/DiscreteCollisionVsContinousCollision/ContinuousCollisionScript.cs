using UnityEngine;

public class ContinuousCollisionScript : MonoBehaviour
{
    //If you set an high insane speed, this will NOT pass the wall
    public float speed = 1f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"HIT: {collision.gameObject.name}");
    }
}
