using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
       if (other.transform.gameObject.tag == "Player") {
           Destroy(gameObject);
       } 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
