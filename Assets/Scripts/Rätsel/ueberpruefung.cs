using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ueberpruefung : MonoBehaviour
{
    public GameObject Textfeld;
    public string text;
    public GameObject butten;
    public GameObject raetsel;
    public GameObject Truhe;
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
            raetsel.SetActive(false);
            Truhe.SendMessage("Geloest");
        }
        else
        {
            Debug.Log("Falsch");
            raetsel.SetActive(false);
            Truhe.SendMessage("Faltch");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
