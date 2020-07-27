using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{public int points = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(100,300, 300, 300), "Score : " + points);
    }
}
