using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public GameObject bullet;

     // Enable this script when the GameObject moves into the camera's view
    void OnBecameVisible()
    {
        enabled = true;
        Debug.Log("GameObject is visible!");
    }
    // Disable this script when the GameObject moves out of the camera's view
    void OnBecameInvisible()
    {
        Destroy(bullet);
        enabled = false;
        Debug.Log("GameObject is not visible!");
        

    }

   

}
