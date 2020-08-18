using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelect : MonoBehaviour
{
    public bool touching;

    //Delete all variables below
    GameObject player;
    public GameObject wonPanel;
    public GameObject gameOverText;
    public Text score;
    public GameObject exclamationMark;
    public GameObject playerInventory;
    public GameObject timeToGoText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (touching == true)
            {
                gameOverText.SetActive(false);
                if(playerInventory != null)
                {
                    playerInventory.SetActive(false);
                }
                wonPanel.SetActive(true);
                exclamationMark.SetActive(false);
                timeToGoText.SetActive(false);
                //SFX
                FindObjectOfType<SoundManager>().StopTheme();
                FindObjectOfType<SoundManager>().Play("Win");

                //replace above with below
                //SceneManager.LoadScene(LevelEnd);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            touching = true;
            exclamationMark.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            touching = false;
            exclamationMark.SetActive(false);
        }
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(1);
        //SFX
        FindObjectOfType<SoundManager>().Play("MenuSelect");
    }

    public void EasyMode()
    {
        SceneManager.LoadScene(2);
        //SFX
        FindObjectOfType<SoundManager>().Play("MenuSelect");
    }

    public void NormalMode()
    {
        SceneManager.LoadScene(3);
        //SFX
        FindObjectOfType<SoundManager>().Play("MenuSelect");
    }

    public void HardMode()
    {
        SceneManager.LoadScene(4);
        //SFX
        FindObjectOfType<SoundManager>().Play("MenuSelect");
    }

}
