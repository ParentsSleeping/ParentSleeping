using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public void Play(){
         Debug.Log("aaaa");
        SceneManager.LoadScene("Level1");
    }
    public void HowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }
    public void Back(){
        SceneManager.LoadScene("Start");
    }
    public void Next1(){
        SceneManager.LoadScene("Level2");
    }
    public void Next2(){
        SceneManager.LoadScene("Level3");
    }
}
