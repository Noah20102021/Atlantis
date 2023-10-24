using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ueberpruefung : MonoBehaviour
{
    public GameObject Textfeld;
    public string text;
    public GameObject butten;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text = Textfeld.GetComponent<TMP_InputField>().text;

        if(text == "N")
        {
            Debug.Log("Richtig");
        }
        
    }
}
