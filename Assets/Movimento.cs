using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public Rigidbody2D carmov;
    public Rigidbody2D rodatras;
    public Rigidbody2D rodafrente;


    public float acelera;
    public float torque;

    private float move;



    void Update()
    {

        move = Input.GetAxis("Horizontal");


    }


    private void FixedUpdate()
    {
        rodatras.AddTorque(-move * acelera * Time.fixedDeltaTime);
        rodafrente.AddTorque(-move * acelera * Time.fixedDeltaTime);
        carmov.AddTorque(-move * torque * Time.fixedDeltaTime);
    }
}
