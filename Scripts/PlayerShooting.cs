using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private List<GameObject> gms;
    public float knockback = 10f;
    void Start()
    {
        gms = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position, Mathf.Infinity, ~LayerMask.NameToLayer("e"));
            if(hit.transform != null) {
                if(hit.transform.gameObject.tag == "enemy") {
                    Rigidbody2D enemyRb = hit.rigidbody;
                    enemyRb.AddForce((new Vector2(hit.transform.position.x-hit.point.x, hit.transform.position.y-hit.point.y)) * knockback);
                    gms.Add(Instantiate(hit.transform.gameObject, hit.transform.position, Quaternion.identity));
                }
            }
        }
        if (Input.GetMouseButtonDown(1)) {
            foreach(GameObject gm in gms) {
                Destroy(gm);
            }
        }   
    }
}
