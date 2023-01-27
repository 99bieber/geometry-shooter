using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Off : MonoBehaviour
{
    private float rotationspeed;


    void Update()
    {
        this.rotationspeed = 50;
        transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * this.rotationspeed);
    }


}
