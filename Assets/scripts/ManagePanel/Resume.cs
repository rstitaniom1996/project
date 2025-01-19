using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject levelsPanel;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResumeGame()
    {
        levelsPanel.SetActive(false);
        Time.timeScale = 1.0f;  // بازی دوباره ادامه می‌یابد
        isPaused = false;
    }
}
