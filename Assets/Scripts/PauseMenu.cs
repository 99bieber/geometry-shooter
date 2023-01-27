using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public AudioSource audioPause;
    

    public GameObject pauseMenu;
    
    public void Pause()
    {
        audioPause.Play();
        AudioListener.pause = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        
    }

    public void Resume()
    {
        AudioListener.pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Exit()
    {
        AudioListener.pause = false;
        DontDestroy.instance.gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }

    public void show(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void hide(GameObject obj)
    {
        obj.SetActive(false);
    }
}
