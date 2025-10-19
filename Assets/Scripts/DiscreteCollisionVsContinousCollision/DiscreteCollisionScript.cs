using UnityEngine;

public class DiscreteCollisionScript : MonoBehaviour
{
    //If you set an high insane speed, this will pass the wall without the collision trigger (That's called Tunneling)
    public float speed = 1f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Discrete; //It's default, but we'll set again.
        rb.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"HIT: {collision.gameObject.name}");
    }

}
