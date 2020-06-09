using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnFish : MonoBehaviour
{
    public GameObject FishSpawn; //Fish to be spawned 
    public AudioSource achievementSound;

    public float minX;
    public float maxX;

    public Slider waterBar;
    public bool fishSpawned = false; //Check if the fish has been spawned
   


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (fishSpawned == false)
        {
            SpawnFishInTank();
        }
        else if (fishSpawned == true)
        {

        }

    }


    public void SpawnFishInTank()
    {

        if (waterBar.value == waterBar.maxValue)
        {
            Debug.Log("Fish Spawned");
            achievementSound.Play();
            Vector2 fishPosition = new Vector2(Random.Range(minX, maxX), 5); //Set position for the fish to be spawned at
            Instantiate(FishSpawn, fishPosition, transform.rotation);
            fishSpawned = true;
            
        }
    }
}
