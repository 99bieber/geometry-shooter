using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text scoreMain;
    public void back()
    {
        Debug.Log("Keluar");
        SceneManager.LoadScene(0);
    }

    void Update() {
        scoreMain.text = PlayerPrefs.GetInt("HS1").ToString() + "\n"
        + PlayerPrefs.GetInt("HS2").ToString() + "\n"
        + PlayerPrefs.GetInt("HS3").ToString() + "\n"
        + PlayerPrefs.GetInt("HS4").ToString() + "\n"
        + PlayerPrefs.GetInt("HS5").ToString() + "\n";        
    }

}
