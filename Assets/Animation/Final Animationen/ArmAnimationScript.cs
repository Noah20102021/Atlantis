using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class ArmAnimationScript : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Camera cam;
    Vector2 mousePosition;
    [SerializeField] Vector2[] positionsArm;


    void Update()
    {


        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 mouseVector = mousePosition - new Vector2(transform.position.x, transform.position.y);

        mouseVector = mouseVector.normalized;

        animator.SetFloat("Horizontal", mouseVector.x);

        animator.SetFloat("Vertical", mouseVector.y);


        Vector2 zweidpoisition = new Vector2(transform.position.x, transform.position.y);

        Vector2 lookdir = mousePosition - zweidpoisition;

        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 270;

        transform.eulerAngles = new Vector3(0, 0, angle);


        if (mouseVector.x > 0 && mouseVector.y > 0)
        {
            transform.localPosition = positionsArm[0];
        }
        if (mouseVector.x < 0 && mouseVector.y > 0)
        {
            transform.localPosition = positionsArm[1];
        }
        if (mouseVector.x < 0 && mouseVector.y < 0)
        {
            transform.localPosition = positionsArm[2];
        }
        if (mouseVector.x > 0 && mouseVector.y < 0)
        {
            transform.localPosition = positionsArm[3];
        }
    }

}
