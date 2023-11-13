using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplayer : MonoBehaviour
{
    public Vector2 jumpHeight;
    Rigidbody2D rb;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space");
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse); ;
        }
    }
    void FixedUpdate()
    {

    }
}
