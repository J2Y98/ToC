using UnityEngine;
using UnityEngine.UI;

public class Wooden_Door : MonoBehaviour
{
    

    //나무 문
    public GameObject door_left;
    public GameObject door_right;

    public GameObject door_left_prefab1;
    public GameObject door_left_prefab2;
    public GameObject door_left_prefab3;

    public GameObject door_right_prefab1;
    public GameObject door_right_prefab2;
    public GameObject door_right_prefab3;

    private Vector3 target_left_angle = new Vector3(0, 90, 0);
    private Vector3 target_right_angle = new Vector3(0, -90, 0);
    private Vector3 current_left_angle;
    private Vector3 current_right_angle;

    //트리거 텍스트
    
    bool Door_is_Open = false;
    
    bool Door_is_near = false;
    bool player_interact = false;

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Door_is_near = true;
        }
    }

    private void Start()
    {
        current_left_angle = door_left.transform.eulerAngles;
        current_right_angle = door_right.transform.eulerAngles;
    }

    private void Update()
    {           
            if (Door_is_near)
            {
                player_interact = true;
            }
            else
            {

            }
            
        
        if (player_interact)
        {
            current_left_angle = new Vector3(0, Mathf.LerpAngle(current_left_angle.y, target_left_angle.y, Time.deltaTime), 0);
            current_right_angle = new Vector3(0, Mathf.LerpAngle(current_right_angle.y, target_right_angle.y, Time.deltaTime), 0);
            door_left_prefab1.transform.eulerAngles = current_left_angle;
            door_left_prefab2.transform.eulerAngles = current_left_angle;
            door_left_prefab3.transform.eulerAngles = current_left_angle;
            door_right_prefab1.transform.eulerAngles = current_right_angle;
            door_right_prefab2.transform.eulerAngles = current_right_angle;
            door_right_prefab3.transform.eulerAngles = current_right_angle;
        }
    }
}