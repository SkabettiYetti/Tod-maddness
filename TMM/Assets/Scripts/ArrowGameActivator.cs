using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGameActivator : MonoBehaviour
{
    public GameObject ArrowStorage;
    public bool isTouch;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouch == true && Input.GetKeyDown(KeyCode.Space))
        {
            ArrowStorage.SetActive(true);
        }
        else if (isTouch == false)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isTouch = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isTouch = false;
        }
    }

}
