using
    System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimento : MonoBehaviour
{
    public Rigidbody2D carmov;
    public Rigidbody2D rodatras;
    public Rigidbody2D rodafrente;
    public WheelJoint2D rodaf, rodar;
    public float tanque = 100;

    public float acelera;
    public float torque;

    private float move;



    void Update()
    {
        if (tanque > 0)
        {
            move = Input.GetAxis("Horizontal");


            if (move != 0)
            {
                tanque -= Time.deltaTime;
            }
        } else
        {

            move = 0;
            if (carmov.velocity.magnitude < 0.01f)
            Invoke("LoadScenes", 2);

        }

    }
        public void LoadScenes()
        {
            SceneManager.LoadScene("GameOver");
        }


    


    private void FixedUpdate()
    {
        JointMotor2D motor = new JointMotor2D();
        motor.motorSpeed = move * acelera;
        motor.maxMotorTorque= Mathf.Abs(move) * torque;

        rodaf.motor = motor;
        rodar.motor = motor;


        //rodatras.AddTorque(-move * acelera * Time.fixedDeltaTime);
        //rodafrente.AddTorque(-move * acelera * Time.fixedDeltaTime);
        //carmov.AddTorque(-move * torque * Time.fixedDeltaTime);
    }
}
