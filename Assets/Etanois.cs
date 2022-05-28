    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Etanois : MonoBehaviour
{
    public Image etanoi;
    public Movimento movimento;


    public void Update()
    {
        etanoi.fillAmount = movimento.tanque / 100;
    }

    public void AddFuel ()
    {
        movimento.tanque = 100;
       
    }
}
