using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float carmov;
    public float rodatras;
    public float rodafrente;


    public float acelera;
    public float torque;

    private float move;



    void FixedUpdate()
    {

        move = Input.GetAxis("Horizontal");


           }


    private void FixedUpdate()
    {
        rodatras.AddTorque(move * acelera * Time.fixedDeltaTime);
        rodafrente.AddTorque(move * acelera * Time.fixedDeltaTime);
        carmov.AddTorque(move * torque * Time.FixedDeltaTime);
    }
}
