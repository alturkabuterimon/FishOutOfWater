using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectWhenOffScreen : MonoBehaviour
{
    private GameObject Bubble; 

    // Start is called before the first frame update
    void Start()
    {
        Bubble = GameObject.FindGameObjectWithTag("Bubbles");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D col)
    {
        if(Bubble.tag == "Bubbles")
        {
            Debug.Log("Bubble Destroyed");
            Bubble.SetActive(false);
            Bubble.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
