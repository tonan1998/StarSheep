using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TouchMovement : MonoBehaviour
{   
    private float touchDis = 10;
    public float jump;
    public float speed;
    public float sideSpeed;
    private Vector3 startPosition;          //to check for swipes on the screen
    private Vector3 endPosition;
    public Rigidbody rb;
    private Vector3 moveToo;
    private bool onGround = false;
    private bool isMouseDown = false;
    

    void Update()
    {
        Move();
        GetMouseDown();
        if(transform.position.y < -1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



   
   void Move() 
    {
      rb.velocity = new Vector3 (0,0,speed * Time.deltaTime);
       
       if(isMouseDown) //  move the player with the finger 
        {

            rb.velocity =new Vector3 ((Input.mousePosition.x - Screen.width / 2) / Screen.width * 2 * 10, 0, speed * Time.deltaTime);

          
        } 
    
    }
    private void OnTriggerEnter(Collider other) // enable jump and Copleted stage
    {
        if (other.tag == "Ground") 
            onGround = true;
        if (other.tag == "LevelComplete")
            SceneManager.LoadScene("LevelComplete");
    }
    void GetMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            isMouseDown = true;
        if (Input.GetMouseButtonUp(0))
            isMouseDown = false;
    }
    public void changeSpeed(int number)
    {
        speed += number;
    }

}
