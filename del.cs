using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class del : MonoBehaviour
{

    public GameObject agent;
    public GameObject pul;
    void Start()
    {
    
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "trig" )
        {
            Destroy(pul);

        }
        else if (collision.collider.name == "agent")
        {
            Destroy(pul);
            Destroy(agent);

        }
    }
}