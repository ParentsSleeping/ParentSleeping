using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Threading;

public class Bars : MonoBehaviour
{
    public Image currentVolumeBar;
    public Text ratioText;
    private float hitPoint=0;
    private float maxHitPoint=150;
    private bool isTouching=false;

    public int maxHealth = 5;
	public int currentHealth;
    private Timer timer1; 
	public HealthBar healthBar;
    public GameObject Rabbit;

private void Start() {
    UpdateVolumeBar();

    Debug.Log("Text: " + "start");
    currentHealth = maxHealth;
	healthBar.SetMaxHealth(maxHealth);
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

    if(hitPoint>=maxHitPoint){
        hitPoint/=2;
        if (currentHealth < 1)
            { 
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                TakeDamage(1);
            } 
            ratio/=2;
    }
    
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

private void OnCollisionEnter(Collision collision){
    if (collision.gameObject.tag == "Rabbit")
        {
            Debug.Log("Text: " + "Rabbit");
          InvokeRepeating("doWork", 0f, 0.05f);
        }
        else if(collision.gameObject.tag == "RabbitTop")
        {
            Destroy(collision.gameObject);
            Destroy(Rabbit);
            CancelInvoke("doWork");
        }
}

public void TakeDamage(int damage)
	{
        Debug.Log("Text: " + "TakeDamage");
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
        
    }

    public void doWork(){
        takeNoise(Time.deltaTime*200);
       
    }
 
}
