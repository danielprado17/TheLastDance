using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinga : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Etanois>().AddFuel();
            Destroy(gameObject);
        }
    }
}
