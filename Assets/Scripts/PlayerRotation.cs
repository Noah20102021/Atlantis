using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    [SerializeField] Camera cam;
  

    //Vector2 movement;
    
    Vector2 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody2D.angularDrag = 0;
       // movement.x = Input.GetAxisRaw("Horizontal");
       // movement.y = Input.GetAxisRaw("Vertical");

        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

         Vector2 zweidpoisition = new Vector2 (transform.position.x, transform.position.y);

        Vector2 lookdir = mousePosition - zweidpoisition;

        float angle = Mathf.Atan2(lookdir.y, lookdir.x)* Mathf.Rad2Deg - 90;

        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    void FixedUpdate() 
    {
//       /* rigidbody2D.MovePosition(rigidbody2D.position + Speed * Time.deltaTime * movement);
        /*Vector2 zweidpoisition = new Vector2 (transform.position.x, transform.position.y);

        Vector2 lookdir = mousePosition - zweidpoisition;

        float angle = Mathf.Atan2(lookdir.y, lookdir.x)* Mathf.Rad2Deg;

        transform.Rotate(0, 0 , angle, Space.Self);
        
        */
        }
}
