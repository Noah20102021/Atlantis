using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public  float Speed = 5f;
    [SerializeField] Camera cam;
    Rigidbody2D rigidbody2D;

    Vector2 movement;
    Vector2 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.angularDrag = 0;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate() 
    {
        rigidbody2D.MovePosition(rigidbody2D.position + Speed * Time.deltaTime * movement);

        //Vector2 lookdir = mousePosition - rigidbody2D.position;

        //float angle = Mathf.Atan2(lookdir.y, lookdir.x)* Mathf.Rad2Deg - 90;

        //rigidbody2D.rotation = angle;   
    }
}
