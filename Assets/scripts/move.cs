using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
   public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h=Input.GetAxisRaw("Horizontal");
        float v=Input.GetAxisRaw("Vertical");
        gameObject.transform.position=
        new Vector2(transform.position.x+(h+Speed),
        transform.position.y+(v+Speed));
        
    }
}
