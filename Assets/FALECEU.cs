using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FALECEU : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GameController"))
        {
            etanol.AddFuel();
            Destroy(gameObject);
        }
    }
}
