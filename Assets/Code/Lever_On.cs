using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lever_On : MonoBehaviour
{
    public GameObject canvas;

    //레버
    public GameObject Lever;
    public GameObject Gate;
    public GameObject Gate_Prefab1;
    public GameObject Gate_Prefab2;
    public GameObject Gate_Prefab3;

    //트리거 텍스트
    public Text Interact_text;

    bool Lever_is_near = false;

    private void OnTriggerEnter(Collider other)
    {
        Lever_is_near = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Lever_is_near = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Lever_is_near)
            {

            }
        }   
    }
}
