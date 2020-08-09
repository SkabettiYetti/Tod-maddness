using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using System.Linq;
using Random = UnityEngine.Random;
using System.Net.Http.Headers;

public class ArrowGame : MonoBehaviour
{
    public GameObject[] Arrowlist1;
    public GameObject[] Arrowlist2;
    public GameObject[] Arrowlist3;
    public GameObject[] Arrowlist4;
    public int Counter;

    void Start()
    {
        Counter = 1;
        Arrowlist1[Random.Range(0, Arrowlist1.Length)].SetActive(true);
        Arrowlist2[Random.Range(0, Arrowlist2.Length)].SetActive(true);
        Arrowlist3[Random.Range(0, Arrowlist3.Length)].SetActive(true);
        Arrowlist4[Random.Range(0, Arrowlist4.Length)].SetActive(true);
    }

    void Update()
    {
            Inputs();
    }

    void Inputs()
    {

        //Arrowlist 1

        if (Arrowlist1[0].activeInHierarchy && Input.GetKeyDown(KeyCode.W) && Counter == 1)
        {
            Arrowlist1[0].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist1[1].activeInHierarchy && Input.GetKeyDown(KeyCode.S) && Counter == 1)
        {
            Arrowlist1[1].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist1[2].activeInHierarchy && Input.GetKeyDown(KeyCode.A) && Counter == 1)
        {
            Arrowlist1[2].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist1[3].activeInHierarchy && Input.GetKeyDown(KeyCode.D) && Counter == 1)
        {
            Arrowlist1[3].SetActive(false);
            Counter += 1;
        }

       //ArrowList 2

        if (Arrowlist2[3].activeInHierarchy && Input.GetKeyDown(KeyCode.W) && Counter == 2)
        {
            Arrowlist2[3].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist2[2].activeInHierarchy && Input.GetKeyDown(KeyCode.S) && Counter == 2)
        {
            Arrowlist2[2].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist2[1].activeInHierarchy && Input.GetKeyDown(KeyCode.A) && Counter == 2)
        {
            Arrowlist2[1].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist2[0].activeInHierarchy && Input.GetKeyDown(KeyCode.D) && Counter == 2)
        {
            Arrowlist2[0].SetActive(false);
            Counter += 1;
        }

        //ArrowList 3

        if (Arrowlist3[0].activeInHierarchy && Input.GetKeyDown(KeyCode.W) && Counter == 3)
        {
            Arrowlist3[0].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist3[1].activeInHierarchy && Input.GetKeyDown(KeyCode.S) && Counter == 3)
        {
            Arrowlist3[1].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist3[2].activeInHierarchy && Input.GetKeyDown(KeyCode.A) && Counter == 3)
        {
            Arrowlist3[2].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist3[3].activeInHierarchy && Input.GetKeyDown(KeyCode.D) && Counter == 3)
        {
            Arrowlist3[3].SetActive(false);
            Counter += 1;
        }

        //ArrowList 4

        if (Arrowlist4[0].activeInHierarchy && Input.GetKeyDown(KeyCode.W) && Counter == 4)
        {
            Arrowlist4[0].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist4[1].activeInHierarchy && Input.GetKeyDown(KeyCode.S) && Counter == 4)
        {
            Arrowlist4[1].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist4[2].activeInHierarchy && Input.GetKeyDown(KeyCode.A) && Counter == 4)
        {
            Arrowlist4[2].SetActive(false);
            Counter += 1;
        }

        if (Arrowlist4[3].activeInHierarchy && Input.GetKeyDown(KeyCode.D) && Counter == 4)
        {
            Arrowlist4[3].SetActive(false);
            Counter += 1;
        }

    }
}
