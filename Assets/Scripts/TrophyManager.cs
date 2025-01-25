using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyManager : MonoBehaviour
{
    public GameObject trophy1;
    public GameObject trophy2;
    public GameObject trophy3;
    public GameObject trophy4;
    public GameObject trophy5;

    void Start()
    {
        trophy1.SetActive(DATA.Trophy1);
        trophy2.SetActive(DATA.Trophy2);
        trophy3.SetActive(DATA.Trophy3);
        trophy4.SetActive(DATA.Trophy4);
        trophy5.SetActive(DATA.Trophy5);
    }
}
