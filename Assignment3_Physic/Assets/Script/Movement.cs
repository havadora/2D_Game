using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 4.0f;
    public float jump = 3.0f;
    public bool groundTouch = true;
    public Vector3 checkPoint;
    public float Fallmultiplier = 2.5f;
    public int isKey = 0;
    public int isSpeedUp = 0;
    public int isSpeedDown = 0;
    public int isCheckpoint = 0;
    public int isCheckpoint1 = 0;
    public GameObject win;
   
    // Start is called before the first frame update
    void Start()
    {
        checkPoint = new Vector3(-3, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity += transform.up * Physics.gravity.y * Fallmultiplier * Time.deltaTime;
        Vector3 move = GetComponent<Rigidbody>().velocity;
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(speed, move.y, 0);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-speed, move.y, 0);
        }
        if (Input.GetKey("space") && groundTouch == true)
        {
            groundTouch = false;
            GetComponent<Rigidbody>().AddForce(transform.up * jump, ForceMode.Impulse);
        }


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            groundTouch = true;
        }
        if (other.gameObject.tag == "trap")
        {

                transform.position = checkPoint;
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "checkpoint" && isCheckpoint == 0  )
        {
            checkPoint = new Vector3(50, 1, 0);
            isCheckpoint = 1;
           
        }
        if (other.tag == "checkpoint2" && isCheckpoint1 == 0)
        {
            checkPoint = new Vector3(98, 15, 0);
            isCheckpoint1 = 1;

        }
        if (other.tag == "spdup" && isSpeedUp == 0)
        {
            speed = speed + 20.0f;
            isSpeedUp = 1;
            isSpeedDown = 0;
        }
        if (other.tag == "spddown" && isSpeedDown == 0)
        {
            speed = speed - 20.0f;
            isSpeedDown = 1;
            isSpeedUp = 0;
        }
        if(other.tag == "Finish")
        {
            win.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
