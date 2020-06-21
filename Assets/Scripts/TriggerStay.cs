using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStay : MonoBehaviour
{
   public bool isDamaging;


   private void OnTriggerStay(Collider other) {       
       if(other.tag=="Player"&&this.tag=="loaf"){
           other.SendMessage("takeNoise",Time.deltaTime*30);
       }
      
   }
   private void OnTriggerExit(Collider other) {
       if(other.tag=="Player"){
           other.SendMessage("healNoise",Time.deltaTime*30);
       }
   }
}
