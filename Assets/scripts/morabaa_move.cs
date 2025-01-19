using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morabaa_move : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D body;

    void Start()
    {
        
    }

    // Update is called once per 
    void Update()
    {
        float h=Input.GetAxisRaw("Horizontal");
        float v=Input.GetAxisRaw("Vertical");
        body.velocity=new Vector2(h*Speed, v *Speed); 
    }
}
