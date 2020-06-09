using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public GameObject Bubble;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bubble.transform.position += transform.up * speed * Time.deltaTime;
    }
}
