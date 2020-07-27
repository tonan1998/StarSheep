using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
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
}
