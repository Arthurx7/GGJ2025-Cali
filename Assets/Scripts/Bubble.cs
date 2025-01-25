using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Bubble : MonoBehaviour
{
    private bool dificult;
    private int requiredClicks; 
    private int clicks = 0; 
    private Image imageComponent;

    [SerializeField] private LevelManager levelManager;
    

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
       
        dificult = Random.value > 0.5f; 
        requiredClicks = dificult ? 2 : 1; 

        Debug.Log("Dificult: " + dificult + " Required Clicks: " + requiredClicks);

        imageComponent = GetComponent<Image>();
    }

    public void Clicked() {

        clicks++; 
        
        Debug.Log("Clicked: " + clicks);

        if (clicks >= requiredClicks)
        {
            imageComponent.enabled = false;
            levelManager.ExplodeBubble();
        }

    }
   
    private void OnMouseDown()
    {
        
    }
}
