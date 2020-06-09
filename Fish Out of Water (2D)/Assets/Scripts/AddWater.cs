using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AddWater : MonoBehaviour
{
    public Slider waterBar;
    public Dropdown goals;
    public Dropdown water;

    void Start()
    {

    }

    //Set the max value of the slider equal to the value chosen in the goals option, so far this is 0-5
    public void SetGoal()
    {
        //Set the max value of the water gauge slider according to the players choice
        if(goals.GetComponent<Dropdown>().value == 0)
        {
            waterBar.maxValue = 500;
        }
        else if(goals.GetComponent<Dropdown>().value == 1)
        {
            waterBar.maxValue = 1000;
        }
        else if(goals.GetComponent<Dropdown>().value == 2)
        {
            waterBar.maxValue = 1500;
        }
        else if(goals.GetComponent<Dropdown>().value == 3)
        {
            waterBar.maxValue = 2000;
        }
        else if(goals.GetComponent<Dropdown>().value == 4)
        {
            waterBar.maxValue = 2500;
        }
        else if (goals.GetComponent<Dropdown>().value == 5)
        {
            waterBar.maxValue = 3000;
        }

        Debug.Log(waterBar.maxValue);
    }


    //Fill up bar 
    public void Fill()
    {
        if (water.GetComponent<Dropdown>().value == 0)
        {
            waterBar.value += 300;
        }
        else if (water.GetComponent<Dropdown>().value == 1)
        {
            waterBar.value += 500;
        }
        else if (water.GetComponent<Dropdown>().value == 2)
        {
            waterBar.value += 700;
        }
        else if (water.GetComponent<Dropdown>().value == 3)
        {
            waterBar.value += 1000;
        }
        else if (water.GetComponent<Dropdown>().value == 4)
        {
            waterBar.value += 1250;
        }
        else if (water.GetComponent<Dropdown>().value == 5)
        {
            waterBar.value += 1500;
        }
        Debug.Log(waterBar.value);

    }

}
