using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiddleMenu : MonoBehaviour
{
    public Text playerdisplay;
    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerdisplay.text = "Player: " + DBManager.username;
        }
    }

    public void GoToGame()
    
        {
            SceneManager.LoadScene(4);
        }

    public void GoToScore()

    {
        SceneManager.LoadScene(5);
    }



}
