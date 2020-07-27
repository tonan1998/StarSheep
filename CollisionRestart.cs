using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionRestart : MonoBehaviour
{
    
void OnTriggerEnter(Collider other)
    {
       
        if(other.tag == "Obstacle")
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
