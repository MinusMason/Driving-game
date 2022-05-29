using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) //In built method used to assist with 2d collision
    {
        Debug.Log("Ouch");
    }
}
