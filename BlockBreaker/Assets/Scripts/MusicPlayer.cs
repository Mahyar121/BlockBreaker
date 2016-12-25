using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        // otherwise make an instance from the class and don't destroy the gameObject which is MusicPlayer
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
 
}
