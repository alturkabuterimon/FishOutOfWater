using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePopper : MonoBehaviour
{
    public float time;


    // Start is called before the first frame update
    void Awake()
    {
        
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("PopBubble");

        if (time <= 0)
        {
            StopCoroutine("PopBubble");
            Destroy(gameObject);
        }
    }

    IEnumerator PopBubble()
    {
        yield return new WaitForSeconds(1);
        time--;
    }
}
