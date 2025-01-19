using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_make : MonoBehaviour
{
    public GameObject ball;
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log(" test");
            Instantiate(ball);
        }
    }
}
