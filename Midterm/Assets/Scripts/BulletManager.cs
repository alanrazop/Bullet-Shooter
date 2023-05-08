using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletManager : MonoBehaviour
{
    public static Text bulletText;
    public static int bulletCount;

    // Update is called once per frame
    void Update()
    {
        GameObject[] thingyToFind = GameObject.FindGameObjectsWithTag("Respawn");
        bulletCount = thingyToFind.Length;
        Debug.Log(bulletCount);
    }
}
