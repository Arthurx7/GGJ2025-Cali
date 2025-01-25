using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    private bool dificult;
    private int requiredClicks; 
    private int clicks = 0; 

    void Start()
    {
       
        dificult = Random.value > 0.5f; 
        requiredClicks = dificult ? 2 : 1; 

        Debug.Log("Dificult: " + dificult + " Required Clicks: " + requiredClicks);
    }

   
    private void OnMouseDown()
    {
        clicks++; 
        
        Debug.Log("Clicked: " + clicks);

        if (clicks >= requiredClicks)
        {
            Destroy(gameObject); 
        }
    }
}
