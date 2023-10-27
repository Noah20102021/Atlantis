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
    public void Button()
    {
        text = Textfeld.GetComponent<TMP_InputField>().text;

        if (text == "N" || text == "n")
        {
            Debug.Log("Richtig");
        }
        else
        {
            Debug.Log("Falsch");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
