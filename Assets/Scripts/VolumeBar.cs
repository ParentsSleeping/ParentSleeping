using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeBar : MonoBehaviour
{
public Image currentVolumeBar;
public Text ratioText;
private float hitPoint=0;
private float maxHitPoint=150;
private bool isTouching=false;

private void Start() {
    UpdateVolumeBar();
}

private void Update() {
    if(!isTouching){
        healNoise(Time.deltaTime*30);
    }
}

private void UpdateVolumeBar() {
    float ratio=hitPoint/maxHitPoint;
    currentVolumeBar.rectTransform.localScale=new Vector3(ratio,1,1);
    ratioText.text=(ratio*100).ToString()+'%';
}

private void healNoise(float noise){
    isTouching=false;
    hitPoint-=noise;
    if(hitPoint<0){
        hitPoint=0;
    }
    UpdateVolumeBar();

}

private void takeNoise(float silence){
    isTouching=true;
    hitPoint+=silence;
    if(hitPoint>maxHitPoint){
        hitPoint=maxHitPoint;
    }
        UpdateVolumeBar();

}
 
}
