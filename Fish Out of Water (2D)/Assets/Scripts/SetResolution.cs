using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Screen.SetResolution(600, 900, false); //hard set the resolution on awake
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
