using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public AudioSource audioSelect;
    public void TryAgain()
    {
        SceneManager.LoadScene(Player.GetScene());
        audioSelect.Play();
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        audioSelect.Play();
        DontDestroy.instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
