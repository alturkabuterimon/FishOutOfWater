using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBubbles : MonoBehaviour    
{
    public GameObject[] Bubbles; //Array to spawn bubbles

    GameObject Bubble;

    public float xMin; //min x value 
    public float xMax; //max x value
    public float yMin; //min y value
    public float yMax; //max y value

    

    public GameObject newBubble; //To reference in DestroyObjectWhenOffScreen Script


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BubblesSpawn", 2, 4); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BubblesSpawn()
    {
        //Same code as spawning food
        for (int i = 0; i <= Bubbles.Length; i++)
        {
            Vector2 BubblePosition = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
            Bubble = Bubbles[Random.Range(0, Bubbles.Length)];
            newBubble = Instantiate(Bubble, BubblePosition, transform.rotation);

        }
    }
}
