using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinga : MonoBehaviour
{
    public Etanois etanol;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            etanol.AddFuel();
            Destroy(gameObject);
        }
    }
}
