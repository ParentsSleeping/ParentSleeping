using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroychracter : MonoBehaviour
{
    public int live = 5;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "toy")
        {
            if (live < 1) { Destroy(col.gameObject); }
            else { live = live - 1; }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
