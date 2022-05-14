    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Etanois : MonoBehaviour
{
    public Image etanoi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        etanoi.fillAmount -= Input.GetAxis("Horizontal") / 1000f;
    }

    public void AddFuel ()
    {
        etanoi.fillAmount += 1f;
    }
}