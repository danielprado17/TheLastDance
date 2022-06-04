using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganhou : MonoBehaviour
{
    public float impacto;
    // Start is called before the first frame update
    void Start()
    {

    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Final"))
        {
            Debug.Log("Campeones!!!");
            Invoke("LoadScenes", 2);
        }

    }
    public void LoadScenes()
    {
        SceneManager.LoadScene("TelaFinal");
    }
}
