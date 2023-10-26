
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] int HealthOfenemy = 10;

    public void takeDamage(int dmaage) 
    {
        HealthOfenemy -= dmaage;
        if(HealthOfenemy <= 0) 
        {
            Die();
        }
    }

    public void Die() 
    {
        gameObject.SetActive(false);

    }

    private void OnCollisionEnter2D(Collision2D collison) 
    {
        if(collison.collider.CompareTag("Player"))
        {
        PlayerHealth player = collison.collider.GetComponent<PlayerHealth>();
        player.TakeDamage(20);
        takeDamage(2);
        }
    }
    
}
