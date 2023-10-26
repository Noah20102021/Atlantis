using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventar : MonoBehaviour
{
    public int Slot1;
    public int Slot2;
    public int Slot3;
    public int SlotNeu;
    public GameObject Slot1GM1;
    public GameObject Slot1GM2;
    public GameObject Slot1GM3;
    public GameObject Slot2GM1;
    public GameObject Slot2GM2;
    public GameObject Slot2GM3;
    public GameObject Slot3GM1;
    public GameObject Slot3GM2;
    public GameObject Slot3GM3;
    public GameObject SlotNeu1;
    public GameObject SlotNeu2;
    public GameObject SlotNeu3;
    public GameObject Itemauswahl;
    public GameObject ButtenB;
    public GameObject Butten1;
    public GameObject Butten2;
    public GameObject Butten3;
    //1 = Blauer Trank, 2 = Roter Trank, 3= Gr�ner Trank, 0 = Lerr
    // Start is called before the first frame update
    void Trank()
    {
        Debug.Log("Trank");
        if (Slot1 == 0)
        {
            Slot1 = Random.Range(1, 4);
        }
        else if (Slot2 == 0)
        {
            Slot2 = Random.Range(1, 4);
        }
        else if (Slot3 == 0)
        {
            Slot3 = Random.Range(1, 4);
        }
        else
        {
            SlotNeu1.SetActive(false);
            SlotNeu2.SetActive(false);
            SlotNeu3.SetActive(false);
            SlotNeu = Random.Range(1, 4);
            if (SlotNeu == 1)
            {
                SlotNeu1.SetActive(true);
            }
            if (SlotNeu == 2)
            {
                SlotNeu2.SetActive(true);
            }
            if (SlotNeu == 3)
            {
                SlotNeu3.SetActive(true);
            }
            Itemauswahl.SetActive(true);
        }
        
    }
    public void Butten1E()
    {
        Slot1GM1.SetActive(false);
        Slot1GM2.SetActive(false);
        Slot1GM3.SetActive(false);
        Slot1 = SlotNeu;
        Itemauswahl.SetActive(false);
        SlotNeu = 0;
    }
    public void Butten2E()
    {
        Slot2GM1.SetActive(false);
        Slot2GM2.SetActive(false);
        Slot2GM3.SetActive(false);
        Slot2 = SlotNeu;
        Itemauswahl.SetActive(false);
        SlotNeu = 0;
    }
    public void Butten3E()
    {
        Slot3GM1.SetActive(false);
        Slot3GM2.SetActive(false);
        Slot3GM3.SetActive(false);
        Slot3 = SlotNeu;
        Itemauswahl.SetActive(false);
        SlotNeu = 0;
    }
    public void ButtenBE()
    {
        Itemauswahl.SetActive(false);
        SlotNeu = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (Slot1 == 1)
            {
                Slot1GM1.SetActive(false);
                Slot1 = 0;
                Debug.Log("Blauer Trank Eingesetzt");
            }
            if (Slot1 == 2)
            {
                Slot1GM2.SetActive(false);
                Slot1 = 0;
                Debug.Log("Roter Trank Eingesetzt");
            }
            if (Slot1 == 3)
            {
                Slot1GM3.SetActive(false);
                Slot1 = 0;
                Debug.Log("Gr�ner Trank Eingesetzt");
            }
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (Slot2 == 1)
            {
                Slot2GM1.SetActive(false);
                Slot2 = 0;
                Debug.Log("Blauer Trank Eingesetzt");
            }
            if (Slot2 == 2)
            {
                Slot2GM2.SetActive(false);
                Slot2 = 0;
                Debug.Log("Roter Trank Eingesetzt");
            }
            if (Slot2 == 3)
            {
                Slot2GM3.SetActive(false);
                Slot2 = 0;
                Debug.Log("Gruener Trank Eingesetzt");
            }
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (Slot3 == 1)
            {
                Slot3GM1.SetActive(false);
                Slot3 = 0;
                Debug.Log("Blauer Trank Eingesetzt");
            }
            if (Slot3 == 2)
            {
                Slot3GM2.SetActive(false);
                Slot3 = 0;
                Debug.Log("Roter Trank Eingesetzt");
            }
            if (Slot3 == 3)
            {
                Slot3GM3.SetActive(false);
                Slot3 = 0;
                Debug.Log("Gruener Trank Eingesetzt");
            }
        }
        if (Slot1 > 0)
        {
            if(Slot1 == 1)
            {
                Slot1GM1.SetActive(true);
            }
            if (Slot1 == 2)
            {
                Slot1GM2.SetActive(true);
            }
            if (Slot1 == 3)
            {
                Slot1GM3.SetActive(true);
            }

        }
        else
        {
            Slot1GM1.SetActive(false);
            Slot1GM2.SetActive(false);
            Slot1GM3.SetActive(false);
        }
        if (Slot2 > 0)
        {
            if (Slot2 == 1)
            {
                Slot2GM1.SetActive(true);
            }
            if (Slot2 == 2)
            {
                Slot2GM2.SetActive(true);
            }
            if (Slot2 == 3)
            {
                Slot2GM3.SetActive(true);
            }

        }
        else
        {
            Slot2GM1.SetActive(false);
            Slot2GM2.SetActive(false);
            Slot2GM3.SetActive(false);
        }
        if (Slot3 > 0)
        {
            if (Slot3 == 1)
            {
                Slot3GM1.SetActive(true);
            }
            if (Slot3 == 2)
            {
                Slot3GM2.SetActive(true);
            }
            if (Slot3 == 3)
            {
                Slot3GM3.SetActive(true);
            }

        }
        else
        {
            Slot3GM1.SetActive(false);
            Slot3GM2.SetActive(false);
            Slot3GM3.SetActive(false);
        }
    }
}
