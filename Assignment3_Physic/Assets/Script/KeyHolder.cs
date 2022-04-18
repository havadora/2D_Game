using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    // Start is called before the first frame update
    private List<KeySys.KeyType> keyList;

    private void Awake()
    {
        keyList = new List<KeySys.KeyType>();
    }
    public void AddKey(KeySys.KeyType keyType)
    {
        keyList.Add(keyType);
    }
    public void RemoveKey(KeySys.KeyType keyType)
    {
        keyList.Remove(keyType);
    }

    public bool ContainsKey(KeySys.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter(Collider other)
    {
        KeySys key = other.GetComponent<KeySys>();
        if (key != null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }


        Door keyD = other.GetComponent<Door>();
        if (keyD != null)
        {
            if (ContainsKey(keyD.GetKeyType()))
            {
                keyD.OnFlipperPressedInternal();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Door keyD = other.GetComponent<Door>();
        if (keyD != null)
        {
            keyD.OnFlipperReleasedInternal();
            
        }
        KeySys key = other.GetComponent<KeySys>();
        if (key != null)
        {
            RemoveKey(key.GetKeyType());
            
        }
    }
}
