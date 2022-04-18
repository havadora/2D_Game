using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float thrust = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(rb.transform.up * thrust, ForceMode.Impulse);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            rb.AddForce(rb.transform.up * thrust, ForceMode.Impulse);
        }
    }
}
