using UnityEngine;

public class SleepingExample : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.sleepThreshold = 0.05f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Debug.Log($"Rigidbody is sleeping? {rb.IsSleeping()}");
            rb.WakeUp(); // This will Force wake up to rigidbody
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}
