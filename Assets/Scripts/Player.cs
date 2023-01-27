using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float rotationspeed;
    private float rotationSpeedbyLevel;
    private float rotationSpeedbySpace;
    public GameObject bullet;
    public Transform muzzle;
    public AudioSource audiofire;
    public AudioSource audiodeath;
    private int scene;
    static Player saveScene;

    void Awake()
    {
        if (saveScene == null) saveScene = this;  
        else Destroy(this.gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        switch(scene){
            case 0:
                this.rotationSpeedbyLevel = 50;
                break;
            case 1:
                this.rotationSpeedbyLevel = 0;
                break;
            case 2:
                this.rotationSpeedbySpace = 10;
                this.rotationSpeedbyLevel = 30;
                break;
            case 3:
                this.rotationSpeedbySpace = 10;
                this.rotationSpeedbyLevel = 40;
                break;
            case 4:
                this.rotationSpeedbySpace = 10;
                this.rotationSpeedbyLevel = 50;
                break;
            case 5:
                this.rotationSpeedbySpace = 100;
                this.rotationSpeedbyLevel = 30;
                break;
            case 6:
                this.rotationSpeedbySpace = 120;
                this.rotationSpeedbyLevel = 30;
                break;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, muzzle.position, muzzle.rotation).GetComponent<Rigidbody2D>().AddForce(muzzle.transform.position * -10, ForceMode2D.Impulse);
            audiofire.Play();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.rotationspeed = this.rotationSpeedbySpace;
        }
        else
        {
            this.rotationspeed = this.rotationSpeedbyLevel;
        }
        transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * this.rotationspeed);
    }

     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy") {
            audiodeath.Play();
            Destroy(gameObject);
            GameOver();
        }
    }

    void GameOver()
    {
        switch(scene){
            case 2:
                HighScoreCheck(PlayerPrefs.GetInt("HS1"), Game.GetScore(), "HS1");
                break;
            case 3:
                HighScoreCheck(PlayerPrefs.GetInt("HS2"), Game.GetScore(), "HS2");
                break;
            case 4:
                HighScoreCheck(PlayerPrefs.GetInt("HS3"), Game.GetScore(), "HS3");
                break;
            case 5:
                HighScoreCheck(PlayerPrefs.GetInt("HS4"), Game.GetScore(), "HS4");
                break;
            case 6:
                HighScoreCheck(PlayerPrefs.GetInt("HS5"), Game.GetScore(), "HS5");
                break;
        }
        SceneManager.LoadScene("GameOver");
    }

    public static int GetScene()
    {
        return saveScene.scene;
    }

    void HighScoreCheck(int score, int newScore, string highScoreLevel)
    {
        if (newScore > score)
        {
            PlayerPrefs.SetInt(highScoreLevel, newScore);
            PlayerPrefs.Save();
        }
    }

}
