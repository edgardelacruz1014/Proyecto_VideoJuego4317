using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libro : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Has recogido el libro");
            Destroy(gameObject);
        }
   
    }
}
