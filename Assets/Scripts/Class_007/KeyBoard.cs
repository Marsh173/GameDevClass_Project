using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class KeyBoard : MonoBehaviour
{
    public List<KeyBoardKey> keyboardKeys = new List<KeyBoardKey>();
    public AudioSource drumLoop;

    void DrumInput()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            drumLoop.Stop();
        }
        if(Input.GetKeyDown(KeyCode.C) && !drumLoop.isPlaying)
        {
            drumLoop.Play();
        }

        //drumLoop.pitch = Class_007_MusicManager.instance.tempo;
    }

    private void Update()
    {
        DrumInput();
    }
}
