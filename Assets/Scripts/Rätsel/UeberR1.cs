using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UberR1 : MonoBehaviour
{
    public GameObject Textfeld;
    public string text;
    public GameObject butten;
    public GameObject R�tsel;
    public GameObject R�tselScri;
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
            R�tsel.SetActive(false);
            R�tselScri.SendMessage("Richtig");
        }
        else
        {
            Debug.Log("Falsch");
            R�tsel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
