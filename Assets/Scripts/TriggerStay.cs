using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStay : MonoBehaviour
{
   public bool isDamaging;
   public AudioSource loafSound;


   private void OnTriggerStay(Collider other) {       
       if(other.tag=="Player"&&this.tag=="loaf"){
           loafSound = GetComponent<AudioSource>();
            loafSound.Play(0);
           other.SendMessage("takeNoise",Time.deltaTime*200);
       }
      
   }
   private void OnTriggerExit(Collider other) {
       if(other.tag=="Player"){
           other.SendMessage("healNoise",Time.deltaTime*70);
       }
   }
}
