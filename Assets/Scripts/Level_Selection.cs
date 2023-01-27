using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Selection : MonoBehaviour
{
    public AudioSource audioselect; 
    void Start() {
         
    }
    public void LevelSelection(int level)
    {
        switch(level){
            case 1:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                ControlMusic();
                break;
            case 2:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
                ControlMusic();
                break;
            case 3:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
                ControlMusic();
                break;
            case 4:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);
                ControlMusic();
                break;
            case 5:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+5);
                ControlMusic();
                break;
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void ControlMusic()
    {
        audioselect.Play();
        DontDestroy.instance.gameObject.GetComponent<AudioSource>().Stop();
    }
}
