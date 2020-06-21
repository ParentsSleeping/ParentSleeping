using UnityEngine;
using System;
// using System.Timers;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Threading;

public class Life : MonoBehaviour
{

    public int maxHealth = 5;
	public int currentHealth;
    private Timer timer1; 

	public HealthBar healthBar;
    public GameObject Rabbit;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Text: " + "start");
        currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }
    // void OnTriggerEnter(Collider other) {
    //     if(other.CompareTag("Rabbit")){
    //         Debug.Log("Text: " + "Rabbit");

    //         System.Timers.Timer myTimer = new System.Timers.Timer();
    //         myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
    //         myTimer.Interval = 2000; // 1000 ms is one second
    //         myTimer.Start();
            
    //     }   
    // }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "toy")
        {
            Debug.Log("Text: " + "toy");
            if (currentHealth < 1)
            { 
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                TakeDamage(1);
            } 
            
        }
        else if (collision.gameObject.tag == "Rabbit")
        {
            Debug.Log("Text: " + "Rabbit");
            // System.Timers.Timer myTimer = new System.Timers.Timer();
            // myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            // myTimer.Interval = 1000; // 1000 ms is one second
            // myTimer.Start();
          InvokeRepeating("doWork", 0f, 4.0f);
        }
        else if(collision.gameObject.tag == "RabbitTop")
        {
            Destroy(collision.gameObject);
            Destroy(Rabbit);
            CancelInvoke("doWork");
        }
    }

    // public void DisplayTimeEvent(object source, ElapsedEventArgs e)
    // {
        
    //      Debug.Log("Text: " + "DisplayTimeEvent");
    //     if (currentHealth < 1)
    //         { 
    //             SceneManager.LoadScene("GameOver");
    //         }
    //         else
    //         {
    //             TakeDamage(1);
    //         }
           
    // }

    public void TakeDamage(int damage)
	{
        Debug.Log("Text: " + "TakeDamage");
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

    public void doWork(){
        Debug.Log("Text: " + "DisplayTimeEvent");
        
             if (currentHealth < 1)
            { 
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                TakeDamage(1);
            }
            // Thread.Sleep(2000);
        
       
    }
}
