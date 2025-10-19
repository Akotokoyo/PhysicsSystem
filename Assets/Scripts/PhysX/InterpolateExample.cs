using UnityEngine;

public class InterpolateExample : MonoBehaviour
{
    public bool useInterpolation;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (useInterpolation) {
            rb.interpolation = RigidbodyInterpolation.Interpolate;
        }

        rb.AddForce(Vector3.forward * 10f, ForceMode.VelocityChange);
    }

}
