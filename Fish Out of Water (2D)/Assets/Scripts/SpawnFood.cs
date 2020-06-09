using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject[] Food; //Array of objects to spawn

    //range of x position for food to be spawned in
    public float xMin;
    public float xMax;

    public GameObject newFood; //to reference in another script
    public bool foodSpawned;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnFoodForFish();
        foodSpawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnFoodForFish()
    {
        for (int i = 0; i <= Food.Length; i++)
        {
            Vector2 foodPosition = new Vector2(Random.Range(xMin, xMax), 5);
            GameObject food = Food[Random.Range(0, Food.Length)];
            newFood = Instantiate(food, foodPosition, transform.rotation);
        }

        
    }
}
