using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animator : MonoBehaviour
{
    private Animator amin;
    private bool isStand = true;
    public GameObject Character;

    private string Movement = "Movement";
    private string PM = "Parameter";

    enum States
    {
        Idle = 0,
        Run = 1,
        Jump = 2,
    }

    float[] direction = new float[] { 0, 0.125f, 0.25f, 0.375f, 0.5f, 0.625f, 0.75f, 0.825f};
    
    private void Awake()
    {
        amin = Character.GetComponent<Animator>();
    }

    private void Idle()
    {
        amin.SetInteger(Movement, (int)States.Idle);
    }

    private void Move()
    {
        //걷는 방향
        //backward
        if (Input.GetAxis("Horizontal") == 0 || Input.GetAxis("Vertical") < 0)
        {
            amin.SetFloat("Parameter", direction[0]);
        }
        //backward left
        else if(Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Vertical") < 0)
        {
            amin.SetFloat("Parameter", direction[1]);
        }
        //backward right
        else if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") < 0)
        {
            amin.SetFloat("Parameter", direction[2]);
        }
        //front
        else if (Input.GetAxis("Horizontal") == 0 || Input.GetAxis("Vertical") > 0)
        {
            amin.SetFloat("Parameter", direction[3]);
        }
        //front left
        else if (Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Vertical") > 0)
        {
            amin.SetFloat("Parameter", direction[4]);
        }
        //front right
        else if (Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Vertical") < 0)
        {
            amin.SetFloat("Parameter", direction[5]);
        }
        //left
        else if (Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Vertical") == 0)
        {
            amin.SetFloat("Parameter", direction[6]);
        }
        //right
        else if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") == 0)
        {
            amin.SetFloat("Parameter", direction[7]);
        }
    }

    private void Jump()
    {
        amin.SetInteger(Movement, (int)States.Jump);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Ground" || hit.gameObject.tag == "Object")
        {
            isStand = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //점프할 시
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStand = false;
            Jump();
        }
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Move();
        }
        else
        {
            Idle();
        }
    }   
}
