using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemiesSpawn : MonoBehaviour
{
    float timer = 0.0f;
    float randtime;
    public GameObject spawnPoint;
    public GameObject enemy;
    private int level;
    private float startspeed;
    private float endspeed;
    private float endspawn;
 
    // Start is called befiore nthe first frame update
    void Start()
    {
        randtime = Random.Range( 0.5f, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        switch(level){
            case 2:
                this.startspeed = 50;
                this.endspeed = 200;
                this.endspawn = 2f;
                break;
            case 3:
                this.startspeed = 100;
                this.endspeed = 300;
                this.endspawn = 1.5f;
                break;
            case 4:
                this.startspeed = 200;
                this.endspeed = 400;
                this.endspawn = 1f;
                break;
            case 5:
                this.startspeed = 300;
                this.endspeed = 500;
                this.endspawn = 0.4f;
                break;
            case 6:
                this.startspeed = 400;
                this.endspeed = 600;
                this.endspawn = 0.2f;
                break;
        }
        if(timer > randtime)
        {
            GameObject ship = Spawn();
            Vector2 dir = (Vector2)(Quaternion.Euler(0, 0, Random.Range(0f, 360f)) * Vector2.right);
            ship.GetComponent<Rigidbody2D>().velocity = dir * Random.Range(this.startspeed, this.endspeed) * Time.deltaTime;
            randtime = Random.Range(0.1f, this.endspawn);
            timer = 0.0f;
        }
        timer += Time.deltaTime;

     
    }

    GameObject Spawn()
    {

        return Instantiate(enemy, spawnPoint.transform.position, Quaternion.Euler(0f, 0f,0f));
       
    }
}