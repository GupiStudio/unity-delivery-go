using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;
    [SerializeField] private float destroyDelay;

    SpriteRenderer spriteRenderer;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        //
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Package") && !hasPackage)
        {
            SpriteRenderer packageRenderer = other.gameObject.GetComponent<SpriteRenderer>();

            Destroy(other.gameObject, destroyDelay);
            hasPackage = true;
            
            if (spriteRenderer != null && packageRenderer != null)
            {
                spriteRenderer.color = packageRenderer.color;
            }

            Debug.Log("Package picked up!");
        }
        else if (other.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            
            if (spriteRenderer != null)
            {
                spriteRenderer.color = new Color32(255, 255, 255, 255);
            }

            Debug.Log("Package delivered!");
        }
    }
}
