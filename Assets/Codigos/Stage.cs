using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stage : MonoBehaviour
{
       
    // Start is called before the first frame update
    void Start()
    {

    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fogueira"))
        {
            Debug.Log("Você passou a PRIMEIRA etapa!!!!");
        }
    }
}
