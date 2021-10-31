using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Duaar!");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Woohoo!");
    }
}
