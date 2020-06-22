using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchingLevels : MonoBehaviour
{
    public string levelName;
    public GameObject endscrn;

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {  
            endscrn.gameObject.SetActive(true);

            //SceneManager.LoadScene(levelName);
        }
    }
    
}
