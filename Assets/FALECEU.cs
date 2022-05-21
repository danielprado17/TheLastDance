using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FALECEU : MonoBehaviour
{

    public float impacto;
    // Start is called before the first frame update
    void Start()
    {
        
    }



     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Chao")) {
            Debug.Log("Faleceu");   
        }
    }
}
