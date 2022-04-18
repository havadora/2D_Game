using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySys : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private KeyType keyType;
    public enum KeyType {ice, slime }
    public float yRot = 10.0f;
    // Update is called once per frame
    void Update()
    {
        yRot ++;
        Quaternion target = Quaternion.Euler(0.0f, yRot, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5.0f);
    }
    public KeyType GetKeyType()
    {
        return keyType;
    }
    
}
