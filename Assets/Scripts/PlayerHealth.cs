using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;

    [SerializeField] int currenthealth;

    [SerializeField] Healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.SetHealth(currenthealth);

        if(Input.GetKeyDown(KeyCode.L)) 
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int Damage) 
    {
        currenthealth -= Damage;

        if(currenthealth <= 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
