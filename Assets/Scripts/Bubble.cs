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
    private Button buttonComponent;

    [SerializeField] private GameObject effects; 
    [SerializeField] private GameObject effects2; 
    // [SerializeField] private LevelManager levelManager;
    [SerializeField] private Sprite bubbleExplote;

    //Sonidos 
     [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip popSound; 
    [SerializeField] private AudioClip explodeSound; 


    void Start()
    {
        //levelManager = FindObjectOfType<LevelManager>();
       
        dificult = Random.value > 0.5f; 
        requiredClicks = dificult ? 2 : 1; 

        Debug.Log("Dificult: " + dificult + " Required Clicks: " + requiredClicks);
       
        imageComponent = GetComponent<Image>();
        buttonComponent = GetComponent<Button>();

        audioSource = GetComponent<AudioSource>();
        

    }

    public void Clicked()
    {
        clicks++; 
     
        if (clicks == 1 && requiredClicks > 1)
        {
            PlaySound(popSound);
            GameObject instantiatedEffect = Instantiate(effects2, transform.position, Quaternion.identity);
        }
        
        Debug.Log("Clicked: " + clicks);

        if (clicks >= requiredClicks)
        {
            PlaySound(explodeSound);

            imageComponent.sprite = bubbleExplote;

            buttonComponent.interactable = false; 
            
            //levelManager.ExplodeBubble(); 

            GameObject instantiatedEffect = Instantiate(effects, transform.position, Quaternion.identity);
        }
    }

    private void PlaySound(AudioClip clip)
    {
    
         audioSource.PlayOneShot(clip); 
    }
}
