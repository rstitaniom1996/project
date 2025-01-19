using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serializefield : MonoBehaviour
{
    [SerializeField]
    private KeyCode keyToDestroy;

    void Update()
    {
        if(Input.GetKeyDown(keyToDestroy)){
            Destroy (gameObject);
        }
    }
}
