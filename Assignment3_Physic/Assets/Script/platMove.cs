using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platMove : MonoBehaviour
{
    public Rigidbody rb;
    public int isLeft = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isLeft == 0)
        {
            rb.velocity = new Vector3(-3.0f, 0, 0);
        }
        else
        {
            rb.velocity = new Vector3(3.0f, 0, 0);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wall")
        {
            if (isLeft == 0)
            {
                isLeft = 1;
            }
            else
            {
                isLeft = 0;
            }
        }
    }
}
