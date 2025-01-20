using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//gameover
public class gameover : MonoBehaviour
{
   public Text myText;
   public Text scoreText;
   private int score=0;
   private void OnCollisionEnter2D(Collision2D other){
    if(other.gameObject.tag=="Finish"){
        Debug.Log("you lost");
        myText.text="you lost";
    }
   }
}
