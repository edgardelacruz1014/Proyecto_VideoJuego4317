using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jam : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Has recogido un JAMP");
            Destroy(gameObject);
        }
    }


}
