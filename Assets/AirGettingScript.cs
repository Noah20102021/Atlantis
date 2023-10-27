using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AirGettingScript : MonoBehaviour
{
    [SerializeField] AirBar manager;

    [SerializeField] bool Inreach;

    public GameObject text;
    
    public GameObject enaughisenough;

    public int IncreaseValue;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && Inreach == true && manager.Score < 140)
        {
            Debug.Log("Touching");
            text.SetActive(false);
            manager.IncreaseScore(IncreaseValue);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.CompareTag("Player" ) && manager.Score < 140)  
        {
            text.SetActive(true);
            Inreach = true;
        }
       /* else
        {
            enaughisenough.SetActive(true);
            
        }
        */
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) 
        {
            text.SetActive(false);
            Inreach = false;
        }    
        /*else if(other.CompareTag("Player") && manager.Score > 140)
        {
            enaughisenough.SetActive(false);
        }
        */
    }
}
