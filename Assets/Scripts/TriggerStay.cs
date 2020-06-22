using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStay : MonoBehaviour
{
//    public bool isDamaging;
   public AudioSource sound;
   bool flag=true;


   private void OnTriggerStay(Collider other) {       
       if(other.tag=="Player"&&this.tag=="loaf"){
        if(flag){
            flag=false;
            InvokeRepeating("playSound", 0f, 0.4f);
        }
           other.SendMessage("takeNoise",Time.deltaTime*300);
       } else if(other.tag=="Player"&&this.tag=="carpet"){
        if(flag){
            flag=false;
            InvokeRepeating("playSound", 0f, 0.4f);
        }
           other.SendMessage("takeNoise",Time.deltaTime*100);
       }
      
   }
   private void OnTriggerExit(Collider other) {
       if(other.tag=="Player"){
           flag=true;
           CancelInvoke("playSound");
           other.SendMessage("healNoise",Time.deltaTime*70);
       }
   }

   private void playSound(){
    sound = GetComponent<AudioSource>();
    sound.Play(0);
   }
}
