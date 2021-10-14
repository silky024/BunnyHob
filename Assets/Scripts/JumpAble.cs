using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAble : MonoBehaviour
{
    [SerializeField] public float jump = 10.0f;
    [SerializeField] public float jumpTrap = 50.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            Debug.Log("Jump");

            Rigidbody2D rigidbody2d = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody2d.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);

        }
        else if(collision.CompareTag("Spike"))
        {
            Debug.Log("Trap");

            Rigidbody2D rigidbody2d = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody2d.AddForce(new Vector2(0, jumpTrap), ForceMode2D.Impulse);

        }
    }
}

