using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring_Arm : MonoBehaviour
{
    public GameObject cameraPos;
    public GameObject playerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos.transform.position = new Vector3 (playerPos.transform.position.x, playerPos.transform.position.y + 6.0f,  -17.0f);
    }
}
