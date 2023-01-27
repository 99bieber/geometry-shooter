using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{  
    public ParticleSystem explosion;
    private ParticleSystem explode;
    public float sceneradius = 15;
    // public float speed = 20f;
    // public Rigidbody2D rb;
    void Start()
    {
        // rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        if (transform.position.x < -sceneradius || transform.position.x > sceneradius || transform.position.y < -sceneradius || transform.position.x > sceneradius)
        {
            Destroy(gameObject);
        }
        if (Time.timeScale == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BigBos")
        {
            explode = Instantiate(explosion);

            explode.Play();
            Destroy(gameObject);
        }



    }
}
