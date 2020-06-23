using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishScrip : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {  
            SceneManager.LoadScene("Finish");
        }
    }
}
