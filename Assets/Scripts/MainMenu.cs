using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioselect;
    // private AudioSource audiobg;

    // public GameObject objectMusic;

    // void Awake() {
    //     AudioConfiguration config = AudioSettings.GetConfiguration();
    //     AudioSettings.Reset(config);   
    // }
    void Start() {
    //  objectMusic = GameObject.FindWithTag("Music");
    //  audiobg = objectMusic.GetComponent<AudioSource>();
    }

    public void play()
    {
        
        audioselect.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void HighScore()
    {
        
        audioselect.Play();
        SceneManager.LoadScene("HighScoreScene");
    }

    void Update() {
         
    }

    public void quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
        audioselect.Play();
    }
}
