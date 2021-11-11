using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.CompareTag("Player"))
        {
            print("Die");
            SceneManager.LoadScene(0);
        }*/
        
        print("Die");
        SceneManager.LoadScene(0);
    }
}