using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        int DistanceAway = 10;
        Vector3 PlayerPOS = GameObject.Find("Square").transform.transform.position;
        transform.position = new Vector3(PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - DistanceAway); 
    }
}
