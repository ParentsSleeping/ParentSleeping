using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchingLevels : MonoBehaviour
{
    // private string[] levels={"Level1",};
    public string levelName;
     public GameObject endscrn;

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {  
            //SceneManager.LoadScene(levelName);
            endscrn.gameObject.SetActive(true);
        }
    }
    
}
