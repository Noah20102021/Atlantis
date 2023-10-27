using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    [SerializeField] AirBar managerOFAIR;

    [SerializeField] PlayerMovement ManagerOfspeed;

    [SerializeField] Bullet managerofdmaage;

    [SerializeField] float duration = 15f, currentTime;

    private void Start() 
    {
     duration = currentTime;   
    }
   public void UnterWasserAtmen() 
   {
    managerOFAIR.score = 50000;
   }

   public void SchnellerLaufen() 
   {
    ManagerOfspeed.Speed = 8f;
   }

   public void MehrSchadenMachen() 
   {
    managerofdmaage.damage = 50;
   }

   public IEnumerator DauerVonPowerUp() 
   {
    while(currentTime >= 0) 
        {
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        SetBackToNormal();
   }

   public void SetBackToNormal() 
   {
    managerofdmaage.damage = 25;
    ManagerOfspeed.Speed = 5f;
    managerOFAIR.score = 180;
   }

}
