using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject followedObject;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(
            followedObject.transform.position.x, 
            followedObject.transform.position.y, 
            transform.position.z);
    }
}
