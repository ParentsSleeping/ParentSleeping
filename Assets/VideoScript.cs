using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoScript : MonoBehaviour
{
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("stopVideo", 0f, 9f);  
    }

    public void stopVideo(){
        if(flag){
            CancelInvoke("stopVideo");
            this.gameObject.SetActive(false);
        }
        flag = true;
    }
}
