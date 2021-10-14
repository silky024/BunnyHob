using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float speed = 1.0f;
    //public float jump = 10.0f;
    //public float jumpTrap = 50.0f;

    Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Vector2 f = new Vector2(0, 0);
        if(Input.GetKey(KeyCode.D))
        {
            f= new Vector2(speed, 0);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            f= new Vector2(-speed, 0);
        }
        /*else if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space bar");
            rigidbody.AddForce(new Vector2(1, jump),ForceMode2D.Impulse);
        }*/

        rigidbody.AddForce(f);
    }
}



