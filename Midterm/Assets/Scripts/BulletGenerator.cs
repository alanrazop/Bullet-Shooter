using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This Bullet Generator class will instance the bullets through their vectors.
/// Standard coding documentation can be found in 
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
/// </summary>
public class BulletGenerator : MonoBehaviour
{
    public GameObject bullet;
    public int numBullets;
    public float speed;
    private Vector3 startPoint;
    private const float radius = 1f;
    public static int bulletCount;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown("h")){
            InvokeRepeating("Scenario1", 1, 1.0F);   
        }
        if (Input.GetKeyDown("j")){
             InvokeRepeating("Scenario2", 1, 0.2F);  
        }

        if (Input.GetKeyDown("k")){
             InvokeRepeating("Scenario3", 1, 0.5F);  
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
          CancelInvoke(); 
        }

        // Guarda la lista de objetos actuales
        GameObject[] thingyToFind = GameObject.FindGameObjectsWithTag("bullet");
        bulletCount = thingyToFind.Length; 
    }

    /// <summary>
    /// Scenarios are invoked when their respective key is pressed
    /// </summary>
    void Scenario1()
    {
        startPoint = transform.position;
        LaunchProjectile(5, 50);
    }

    void Scenario2()
    {
        startPoint = transform.position;
        LaunchProjectile(3, 10);
    }

    void Scenario3()
    {
        startPoint = transform.position;
        LaunchProjectile(30, 30);
    }

   
    /// <summary>
    /// LaunchProjectile is called before the first frame update
    /// </summary>
    void LaunchProjectile(int _numberBullets, int _speed)
    {
        float degree = 360f / _numberBullets;
        float angle = 0f;

        for (int i = 1; i <= _numberBullets; i++){
            //Calculo de la dirección en X e Y
            float bulletXPos = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float bulletYPos = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

             Vector3 bulletVector = new Vector3(bulletXPos, bulletYPos, 0);
             Vector3 bulletMoveDir = (bulletVector - startPoint).normalized * _speed;

             GameObject instance = Instantiate(bullet, startPoint, Quaternion.identity);
             instance.GetComponent<Rigidbody>().velocity = new Vector3 (bulletMoveDir.x, 0, bulletMoveDir.y);

             angle += degree;
        }
    }
}
