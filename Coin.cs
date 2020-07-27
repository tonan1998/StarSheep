using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player") ;
        {
            other.GetComponent<Collect>().points++;
            Destroy(gameObject);
        }
    }
}
