using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Transform firepoint;

    [SerializeField] GameObject bulletPrefab;

    [SerializeField] float bulletforce = 20f;

    public float FireRate;
    float RedyForeNextShot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            if(Time.time > RedyForeNextShot) 
            {
                RedyForeNextShot = Time.time + 1/FireRate;
                Shoot();
            }
        }
    }

    public void Shoot() 
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rigidbody2D = bullet.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);

    }
}
