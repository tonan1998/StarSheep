using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void onOpen()        //stop the game and update the numbers to show the player
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
        //player.GetComponent<Player>().changeSpeed(0);
        // GetComponent<Camera>().GetComponent<camera>().addDistance(0);

    }


    public void onClose()       //close the window and continue the game
    {

        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
