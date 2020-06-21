
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiveRabbitsDemo
{
    public class RabbitTrigger : MonoBehaviour
    {

        private string[] m_buttonNames = new string[] { "Idle", "Run", "Dead" };

        private Animator m_animator;
        public AudioSource audioSource;

        // Use this for initialization
        void Start()
        {

            m_animator = GetComponent<Animator>();

        }


    //     void OnTriggerEnter(Collider other) {
    //     if(other.CompareTag("Player")){
    //         Debug.Log("rabbit start");
    //          m_animator.SetInteger("AnimIndex", 1);
    //                 m_animator.SetTrigger("Next");
    //     }
    // }

     private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("rabbit start on RabbitTrigger");

            audioSource.Play();
             m_animator.SetInteger("AnimIndex", 1);
             m_animator.SetTrigger("Next");
        }

    }

        // // Update is called once per frame
        // void Update()
        // {

        // }

        // private void OnGUI()
        // {
        //     GUI.BeginGroup(new Rect(0, 0, 150, 1000));

        //     for (int i = 0; i < m_buttonNames.Length; i++)
        //     {
        //         if (GUILayout.Button(m_buttonNames[i], GUILayout.Width(150)))
        //         {
        //             m_animator.SetInteger("AnimIndex", i);
        //             m_animator.SetTrigger("Next");
        //         }
        //     }

        //     GUI.EndGroup();
        // }
    }
}
