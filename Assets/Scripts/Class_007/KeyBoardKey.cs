using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class KeyBoardKey : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public KeyCode keyboardButtons;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void playKey()
    {
        audioSource.PlayOneShot(audioClip);
    }

    private void Update()
    {
        audioSource.pitch = Input.GetKey(KeyCode.LeftShift) ? audioSource.pitch = 2.0f : audioSource.pitch = 1.0f; 
        //are you pressing down left shift? 2.0 is the true return, 1.0 is the false return.
        if (Input.GetKeyDown(keyboardButtons))
        {
            playKey();
        }
    }
}
