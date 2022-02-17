/**
* ChangeLog:
*
* Update 1:
* Added Sprites for Enemies and Player
* Had Camera Move with Player
* Added Speed Increase Button
* Added "Destruction Counter"
*
*
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public int numDestroyed = 0;
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(0, 0, -turnSpeed * Time.deltaTime);
        }     
    }
    private void OnCollisionEnter2D(Collision2D other) {
       if (other.transform.gameObject.tag == "enemy") {
           numDestroyed++;
       } 
    }
    void OnGUI() {
        //Destruction Counter
        GUI.Label(new Rect(10, 10, 100, 100), "Destruction count:" + numDestroyed);
        //Speed Increase
          if (GUI.Button(new Rect(150, 300, 250, 50), "Speed Boost (Current Speed: " + moveSpeed + ")"))
            moveSpeed = moveSpeed + 5f;  
          
    }
}
