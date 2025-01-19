using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isMuted = false;

    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
        isMuted = PlayerPrefs.GetInt("Mute", 0) == 1;
        audioSource.mute = isMuted;
    }
    public void ToggleMute()
    {
        isMuted = !isMuted; // تغییر وضعیت قطع/وصل صدا
        audioSource.mute = isMuted; // اعمال تغییر به AudioSource
        PlayerPrefs.SetInt("Mute", isMuted ? 1 : 0);
    }
}