using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest_Open : MonoBehaviour
{
    public GameObject canvas;
    //상자 + 트리거
    public GameObject Chest;
    public GameObject Chest_Prefab1;
    public GameObject Chest_Prefab2;
    public GameObject Chest_Prefab3;
    private Vector3 target_angle = new Vector3(-90f, 0, 0);
    private Vector3 current_angle;

    //트리거 텍스트
    public Text Interact_text;

    bool player_is_near = false;
    bool player_interact = false;

    private void Start()
    {
        current_angle = Chest.transform.eulerAngles;
        Interact_text.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player_is_near = true;
            Interact_text.text = "Open";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player_is_near = false;
            Interact_text.text = "";
        }
    }

    void Update()
    {
        if(player_interact == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (player_is_near)
                {
                    player_interact = true;
                    
                }
            }
        }
        if (player_interact)
        {
            current_angle = new Vector3(Mathf.LerpAngle(current_angle.x, target_angle.x, Time.deltaTime), 0, 0);
            Chest.transform.eulerAngles = current_angle;
            Chest_Prefab1.transform.eulerAngles = current_angle;
            Chest_Prefab2.transform.eulerAngles = current_angle;
            Chest_Prefab3.transform.eulerAngles = current_angle;
        }
    }
}
