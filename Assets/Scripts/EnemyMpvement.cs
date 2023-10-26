using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyMpvement : MonoBehaviour
{
  public Transform Target;

    public float speed;

    public float lineofSite;

    
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distncefromplayer = Vector2.Distance(Target.position, transform.position);
        if(distncefromplayer < lineofSite) 
        {
            transform.position =  Vector2.MoveTowards(this.transform.position, Target.position, speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmosSelected() {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, lineofSite);
        }
}
