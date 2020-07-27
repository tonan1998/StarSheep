using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public Vector3 Offset;
 
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + Offset;
    }
    public void changeoffset(int number)
    {
        Offset.y += number;
        transform.LookAt(player.position);
    }
}
