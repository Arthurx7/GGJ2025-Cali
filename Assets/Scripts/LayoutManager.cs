using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutManager : MonoBehaviour
{
    public GameObject bubble;
    public Transform papel;
    public int count; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject b = Instantiate(bubble, papel);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
