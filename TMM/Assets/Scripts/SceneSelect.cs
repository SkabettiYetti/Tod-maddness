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
}
