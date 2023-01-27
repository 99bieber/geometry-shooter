using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public GameObject objectMusic;
    private AudioSource AudioBG;
    void Start()
    {
        objectMusic = GameObject.FindWithTag("Music");
        AudioBG = objectMusic.GetComponent<AudioSource>();   
    }
    void Update()
    {
        
    }
}
