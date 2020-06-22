using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("Level1");
    }
    public void HowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }
    public void Back(){
        SceneManager.LoadScene("Start");
    }
    public void Next1(){
        Debug.Log("nahamaaaaaa");
        SceneManager.LoadScene("Level2");
    }
}
