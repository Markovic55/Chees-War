using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;


public class SeeScoreTable : MonoBehaviour
{
    public Text playerDisplay;
    public Text winsDisplay;
    public Text lossesDisplay;
    public void GoToMiddle()

    {
        SceneManager.LoadScene(3);
    }


   private void Awake()
    {
        if(DBManager.username == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        playerDisplay.text = "Player: " + DBManager.username;
        winsDisplay.text = "Wins: " + DBManager.wins;
        lossesDisplay.text = "Losses: " + DBManager.losses;
    }
    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData());
    }
    IEnumerator SavePlayerData()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", DBManager.username);
        form.AddField("wins", DBManager.wins);
        form.AddField("losses", DBManager.losses);

        UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/savedata.php", form);
        yield return www.SendWebRequest();

        if(www.downloadHandler.text[0] == '0')
        {
            Debug.Log("Saved");
        }
        else
        {
            Debug.Log("Save failed. error #" + www.downloadHandler.text);
        }

        DBManager.LogOut();

        

    }
    public void IncreaseScore()
    {
        DBManager.wins++;
        winsDisplay.text = "Wins: " + DBManager.wins;
        DBManager.losses++;
        lossesDisplay.text = "Losses" + DBManager.losses;

    }

}
