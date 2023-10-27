using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Rätsel2 : MonoBehaviour
{
    public Boolean InReatch;
    public GameObject Text;
    public GameObject Rätsel;
    public GameObject Rätseltuer;
    public GameObject Raetseltuer2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && InReatch == true)
        {
            Debug.Log("Open");
            Text.SetActive(false);
            Rätsel.SetActive(true);

        }
    }
    public void Richtig()
    {
        Rätseltuer.SetActive(false);
        Raetseltuer2.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
      
            Debug.Log("InReatch");
            Text.SetActive(true);
            InReatch = true;
        
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OutOfReatch");
        Text.SetActive(false);
        InReatch = false;
    }
}
