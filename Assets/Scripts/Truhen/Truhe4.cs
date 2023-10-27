using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Truhe4 : MonoBehaviour
{
    public GameObject Text;
    public Boolean IsOpen;
    public Boolean InReatch;
    public Boolean RaetselisOpen;
    [SerializeField] private Renderer truhe;
    public GameObject InventarGM;
    public GameObject TruheAuf;
    public GameObject TruheZu;
    public GameObject Raetsel;
    // Start is called before the first frame update
    void Start()
    {
        IsOpen = false;
    }

    // Update is called once per frame
    public void Geloest()
    {
        Debug.Log("Open");
        IsOpen = true;
        Text.SetActive(false);
        TruheAuf.SetActive(true);
        TruheZu.SetActive(false);
        InventarGM.SendMessage("Trank");
        RaetselisOpen = false;
    }
    public void Faltch()
    {
        RaetselisOpen = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && IsOpen == false && InReatch == true && RaetselisOpen == false)
        {
            Debug.Log("OpenRätsel");
            //IsOpen = true;
            Text.SetActive(false);
            //TruheAuf.SetActive(true);
            //TruheZu.SetActive(false);
            //InventarGM.SendMessage("Trank");
            Raetsel.SetActive(true);
            RaetselisOpen = true;

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsOpen == false)
        {
            Debug.Log("InReatch");
            Text.SetActive(true);
            InReatch = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OutOfReatch");
        Text.SetActive(false);
        InReatch = false;
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        
    }

}
