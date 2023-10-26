using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float durationbullet = 2.5f, currentTimeBullet;

    public int damage = 25;

  

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timeOFBullet());
        currentTimeBullet = durationbullet;
    }

    IEnumerator timeOFBullet() 
    {
        while(currentTimeBullet >= 0) 
        {
            yield return new WaitForSeconds(1f);
            currentTimeBullet--;
        }
        DestroyBullet();
    }

    public void DestroyBullet() 
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        enemy enemyscript = collision2D.GetComponent<enemy>();
        if(collision2D.CompareTag("Enemy")) 
        {
            enemyscript.takeDamage(damage);
            Destroy(gameObject);
        }
    }
}
