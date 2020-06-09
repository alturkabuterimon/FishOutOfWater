using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject goalsTab;
    public GameObject addWaterTab;
    public GameObject helpTab;
    public GameObject logo1;
    public GameObject logo2;

    void Start()
    {
        goalsTab.SetActive(true);
        addWaterTab.SetActive(false);
        Screen.SetResolution(600, 900, false);
    }

    //Close Goals Tab
    public void CloseGoalsTab()
    {
        goalsTab.SetActive(false);
    }
    //Open Goals tab
    public void OpenGoalsTab()
    {
        goalsTab.SetActive(true);
    }

    public void OpenAddWaterTab()
    {
        addWaterTab.SetActive(true);
    }
    
    public void CloseAddWaterTab()
    {
        addWaterTab.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("FishTank");
    }

    public void OpenHelpTab()
    {
        logo1.SetActive(false);
        logo2.SetActive(false);
        helpTab.SetActive(true);

    }

    public void CloseHelpTab()
    {
        helpTab.SetActive(false);
        logo1.SetActive(true);
        logo2.SetActive(true);
    }
}
