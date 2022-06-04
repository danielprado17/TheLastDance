using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Jogar : MonoBehaviour
{

 public void LoadScenes (string HeavyHill)
    {
        SceneManager.LoadScene(HeavyHill);
    }
    public void Quit ()
    {
        Application.Quit();
    }
}
