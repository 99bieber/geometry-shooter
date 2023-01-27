using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesShip : MonoBehaviour
{
    public float bounds;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > bounds || this.transform.position.x < -bounds || this.transform.position.y > bounds || this.transform.position.x < -bounds)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Bullet")
        {
            Game.AddToScore(1);
            Destroy(gameObject);
        }

    }
}
