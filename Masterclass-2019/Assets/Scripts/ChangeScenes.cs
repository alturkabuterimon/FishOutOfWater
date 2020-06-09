using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void Load1()
    {
        SceneManager.LoadScene("ImageTracking");
    }

    public void Load2()
    {
        SceneManager.LoadScene("SimpleAR");
    }

    public void Load3()
    {
        SceneManager.LoadScene("DataScene");
    }
}
