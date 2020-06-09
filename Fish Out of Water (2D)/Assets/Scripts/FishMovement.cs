using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public SpriteRenderer fishSprite;

    public float speed = 7.0f;
    public GameObject fish;

    public Sprite Swim1;
    public Sprite Swim2;

    public Vector2 newPosition;
    public Vector2 currentPosition
    {
        get { return fish.transform.position; }
        set { fish.transform.position = currentPosition; }
    }

    private GameObject Food;
        
    // Start is called before the first frame update
    void Start()
    {
        fishSprite.GetComponent<SpriteRenderer>();
        InvokeRepeating("NewPosition", 1.5f, 3.0f); //Create new position every 1.5 seconds
        StartCoroutine("SwapSprite"); //Start swim anim
    }

    void NewPosition()
    {
        newPosition = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(-4.5f, 4.5f)); //Create a new position for the fish to swim to 
    }

    IEnumerator SwapSprite()
    {
        while (enabled)
        {
            fishSprite.sprite = Swim1;
            yield return new WaitForSeconds(0.5f);
            fishSprite.sprite = Swim2;
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void EatFood()
    {
        
        Food = GameObject.FindGameObjectWithTag("Food"); //Grab food objects
        
        //should move the fish to the food game object
        fish.transform.position = Vector2.MoveTowards(currentPosition, Food.transform.position, speed * Time.deltaTime);

    }

     void OnCollisionEnter2D(Collision2D col)
    {
        if (Food.tag == "Food")
        {
            Food.SetActive(false);
            Food.GetComponent<SpriteRenderer>().enabled = false; //"Eat" the food
        }
    }



    // Update is called once per frame
    void Update()
    {
        //flip the sprite depending on position (needs to be improved)
        if (currentPosition.x >= -0.01f)
        {
            
            fishSprite.flipX = false;
        }
        else
        {
            
            fishSprite.flipX = true;
        }
        //This moves the fish
        fish.transform.position = Vector2.MoveTowards(currentPosition, newPosition, speed * Time.deltaTime);

        //if (Food.GetComponent<SpawnFood>().foodSpawned == true)
        //{
            //Debug.Log("Food Spawned.");
            EatFood();
        //}
    }
}
