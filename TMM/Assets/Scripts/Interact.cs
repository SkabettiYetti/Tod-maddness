using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public bool canActivate;
    public GameObject sTick;
    public GameObject bTick;
    public GameObject kTick;

    void Update()
    {
        if(canActivate == true)
        {
           if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerController.instance.interacting = true;
            }
        }

        if (PlayerController.instance.slider.value == 10)
        {
            PlayerController.instance.interacting = false;
            PlayerController.instance.slider.value = 0;
        }
    }

   private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.tag == "Player" && gameObject.tag == "Shower") //&& PlayerController.instance.slider.value == 10 // Was trying to add 
        {
            //check trigger more then once in tell bar riches 10

            canActivate = true;
            //Slider stuff need go here

            if(canActivate == true)
            {
                sTick.SetActive(true);
            }  
        }
        else if (other.gameObject.tag == "Player" && gameObject.tag == "Brush")
        {
             //canActivate = true;

            //Slider stuff need go here
            bTick.SetActive(true);
        }  
        else if (other.gameObject.tag == "Player" && gameObject.tag == "Keys")
        {
            //canActivate = true;

            //Slider stuff need go here
            kTick.SetActive(true); 
        }
    } 
}