using UnityEngine;

public class JointsExample : MonoBehaviour
{
    void Start()
    {
        HingeJoint hinge = gameObject.AddComponent<HingeJoint>();
        hinge.useMotor = true;
        JointMotor motor = hinge.motor;
        motor.force = 100f;
        motor.targetVelocity = 90f;
        motor.freeSpin = false;
        hinge.motor = motor;
    }
}
