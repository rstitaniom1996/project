using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject levelsPanel;
    private bool isPaused = false;

    // منطق توقف/شروع مجدد بازی
    public void PauseGame()
    {
        if (Time.timeScale == 0)
        {
            // بازی از حالت توقف خارج می‌شود
            Time.timeScale = 1;
        }
        else
        {
            // بازی متوقف می‌شود
            Time.timeScale = 0;
        }
    }

    public void showLevelsPanel()
    {
        levelsPanel.SetActive(true);
    }

    public void hideLevelsPanel()
    {
        levelsPanel.SetActive(false);
    }

    public void ResumeGame()
    {
        levelsPanel.SetActive(false);
        Time.timeScale = 1.0f;  // بازی دوباره ادامه می‌یابد
        isPaused = false;
    }

    public void ReStartGame()
    {
        Time.timeScale = 1.0f;  // بازی دوباره با زمان نرمال شروع می‌شود
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // صحنه فعلی دوباره بارگذاری می‌شود
    }

    public void GoToMenu()
    {
        Time.timeScale = 0.0f;  // بازی متوقف می‌شود
        SceneManager.LoadScene("Menu");  // به منو می‌رود
    }

    // فراخوانی برای متوقف کردن/شروع مجدد بازی
    public void TogglePause()
    {
        PauseGame();  // فراخوانی متد PauseGame که منطق توقف بازی را اجرا می‌کند
    }
}
