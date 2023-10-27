using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Truhe3 : MonoBehaviour
{
    public GameObject Text;
    public Boolean IsOpen;
    public Boolean InReatch;
    [SerializeField] private Renderer truhe;
    public GameObject InventarGM;
    public GameObject TruheAuf;
    public GameObject TruheZu;
    // Start is called before the first frame update
    void Start()
    {
        IsOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && IsOpen == false && InReatch == true)
        {
            Debug.Log("Open");
            IsOpen = true;
            Text.SetActive(false);
            TruheAuf.SetActive(true);
            TruheZu.SetActive(false);
            InventarGM.SendMessage("Trank");

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
