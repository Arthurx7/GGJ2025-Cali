using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button[] bots;
    // Start is called before the first frame update
    void Start()
    {
        if(!DATA.once)
        {
            DATA.set_once();
        }

        for(int i=0; i<bots.Length;i++)
        {
            bots[i].interactable = false;
        }

        for(int i=0; i<DATA.level;i++)
        {
            bots[i].interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
