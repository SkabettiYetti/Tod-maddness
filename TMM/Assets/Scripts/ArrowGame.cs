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

    public static ArrowGame instance;
    public GameObject ArrowStorage;
    public GameObject[] Arrowlist1;
    public GameObject[] Arrowlist2;
    public GameObject[] Arrowlist3;
    public GameObject[] Arrowlist4;
    public int Counter;

    //It ain't pretty but god damn it better work
    public GameObject
        A1U, A2U, A3U, A4U,
        A1D, A2D, A3D, A4D,
        A1R, A2R, A3R, A4R,
        A1L, A2L, A3L, A4L;

    void Start()
    {
        ArrowStorage.SetActive(false);

        instance = this;
        Counter = 1;
        Arrowlist1[Random.Range(0, Arrowlist1.Length)].SetActive(true);
        Arrowlist2[Random.Range(0, Arrowlist2.Length)].SetActive(true);
        Arrowlist3[Random.Range(0, Arrowlist3.Length)].SetActive(true);
        Arrowlist4[Random.Range(0, Arrowlist4.Length)].SetActive(true);
    }

    void Update()
    {

        IsActive();

        if (Counter == 1)
        {
            ArrowList1();
        }
        else if (Counter == 2)
        {
            ArrowList2();
        }
        else if (Counter == 3)
        {
            ArrowList3();
        }
        else if (Counter == 4)
        {
            ArrowList4();
        }
    }

    void ArrowList1()
    {
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

    }

    void ArrowList2()
    {
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

    }

    void ArrowList3()
    {
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
    }

    void ArrowList4()
    {
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

    void IsActive()
    {
        if (A1U.activeInHierarchy || A2U.activeInHierarchy || A3U.activeInHierarchy || A4U.activeInHierarchy ||
            A1D.activeInHierarchy || A2D.activeInHierarchy || A3D.activeInHierarchy || A4D.activeInHierarchy ||
            A1L.activeInHierarchy || A2L.activeInHierarchy || A3L.activeInHierarchy || A4L.activeInHierarchy ||
            A1R.activeInHierarchy || A2R.activeInHierarchy || A3R.activeInHierarchy || A4R.activeInHierarchy)
        {
            PlayerController.instance.interacting = true;
        }
    }
}
