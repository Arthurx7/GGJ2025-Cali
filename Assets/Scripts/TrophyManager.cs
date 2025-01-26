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
    public GameObject trophy6;
    public GameObject trophy7;
    public GameObject trophy8;
    public GameObject trophy9;
    public GameObject trophy10;

    void Start()
    {
        trophy1.SetActive(DATA.Trophy1);
        trophy2.SetActive(DATA.Trophy2);
        trophy3.SetActive(DATA.Trophy3);
        trophy4.SetActive(DATA.Trophy4);
        trophy5.SetActive(DATA.Trophy5);
        trophy6.SetActive(DATA.Trophy6);
        trophy7.SetActive(DATA.Trophy7);
        trophy8.SetActive(DATA.Trophy8);
        trophy9.SetActive(DATA.Trophy9);
        trophy10.SetActive(DATA.Trophy10);
    }
}
