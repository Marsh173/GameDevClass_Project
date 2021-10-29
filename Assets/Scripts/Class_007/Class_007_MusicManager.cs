using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class_007_MusicManager : MonoBehaviour
{
    public static Class_007_MusicManager instance = null;

    public float volume = 1.0f;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this; //reference the actual object that's on
            DontDestroyOnLoad(this);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
}
