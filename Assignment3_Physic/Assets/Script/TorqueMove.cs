using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float torque;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        rb.AddTorque(transform.right * torque , ForceMode.Force);
    }
}
