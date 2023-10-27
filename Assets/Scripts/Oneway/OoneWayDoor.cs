using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OoneWayDoor : MonoBehaviour
{
    public GameObject Door;
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
        Debug.Log("Auf");
        Door.SetActive(false);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Zu");
        Door.SetActive(true);
        
    }
}
