using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public void LevelStart()
    {
        SceneManager.LoadScene(1);
    }
    
    //Works?
    public void ExitGame()
    {
        Application.Quit();
    }

}
