using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button : MonoBehaviour
{
    [SerializeField]
    private Text myText;
    private int _counter=0;
   
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
    public void OnBtnClick(){
        _counter++;
        myText.text="count " +  _counter;
        Debug.Log($"Count:{_counter}");
    }
}
