using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Truhen : MonoBehaviour
{
    public GameObject Text;
    public Boolean IsOpen;
    [SerializeField] private Renderer truhe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsOpen == false)
        {
            Debug.Log("InReatch");
            Text.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OutOfReatch");
        Text.SetActive(false);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E)  && IsOpen == false)
        {
            Debug.Log("Open");
            IsOpen = true;
            Text.SetActive(false);
            truhe.material.color = Color.green;

        }
    }

}
