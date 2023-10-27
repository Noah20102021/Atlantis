using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UberR1 : MonoBehaviour
{
    public GameObject Textfeld;
    public string text;
    public GameObject butten;
    public GameObject Raetsel;
    public GameObject RaetselScri;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Button()
    {
        text = Textfeld.GetComponent<TMP_InputField>().text;

        if (text == "B" || text == "b")
        {
            Debug.Log("Richtig");
            Raetsel.SetActive(false);
            RaetselScri.SendMessage("Richtig");
        }
        else
        {
            Debug.Log("Falsch");
            Raetsel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
