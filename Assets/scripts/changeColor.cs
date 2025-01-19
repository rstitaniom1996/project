using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
   private SpriteRenderer sr;
   public Color color1;
   public Color color2;
    void Start()
    {
        Debug.Log("start function called...");
        sr=GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColor2());
    }

  IEnumerator ChangeColor2(){
    while (true){
        if(sr.color==color1){
            sr.color=color2;
            Debug.Log("change color to..."+color2);
        }
        else{
            sr.color=color1;
            Debug.Log("change color to..."+color1);
        }
        yield return new WaitForSeconds(3);
    }
  }
}
