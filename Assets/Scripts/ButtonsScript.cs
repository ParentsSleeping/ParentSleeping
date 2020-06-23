using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    private string[] levels={"Level1","Level2","Level3"};
    public static int levelPosition=1;
    public GameObject endscrn;
    public GameObject estoryscrn;

    public void Start1(){
        SceneManager.LoadScene("Level1");
    }
    public void Play(){
        SceneManager.LoadScene("BetweenLevels");
    }
    public void HowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }
    public void Back(){
        SceneManager.LoadScene("Start");
    }
    public void Next(){
        endscrn.gameObject.SetActive(false);
        estoryscrn.gameObject.SetActive(true);
    }
    public void Next1(){
        SceneManager.LoadScene("Level2");
    }
    public void Next2(){
        SceneManager.LoadScene("Level3");
    }
    public void Next3(){
        SceneManager.LoadScene("Level4");
    }
}
