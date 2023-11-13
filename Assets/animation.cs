using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator animatorRF;   
    public Rigidbody2D rg;
    // Update is called once per frame

    void FixedUpdate()
    {
        animatorRF.SetFloat("speed x",Mathf.Abs (rg.velocity.x));
        if (animatorRF.velocity.y <0)
        {
            animatorRF.SetBool("chute", true);
        }
        if (Input.GetKeyDown(KeyCode.Space)==true)
        { 
            animatorRF.SetBool("jump 0", true); 
        }
       
    }
}







