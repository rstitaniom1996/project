using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public void PauseGame()
    {
       if(Time.timeScale==0){
        Time.timeScale=1;
       }
       else
       {
        
            Time.timeScale=0;
        
       }
    }

   
}
