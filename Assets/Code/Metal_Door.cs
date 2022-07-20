using UnityEngine;
using UnityEngine.UI;

public class Metal_Door : MonoBehaviour
{
    public GameObject canvas;
    //금속문(감옥)
    public GameObject metal_door;
    public GameObject door_prefab1;
    public GameObject door_prefab2;
    public GameObject door_prefab3;

    //트리거 텍스트
    public Text Interact_text;

    private Vector3 target_angle = new Vector3(0, 90, 0);
    private Vector3 current_angle;

    bool Door_is_Open = false;
    public bool Key_have = false;
    bool Door_is_near = false;
    bool player_interact = false;

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Door_is_near = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Door_is_near)
            {
                if (Key_have)
                {
                    player_interact = true;
                }
                else
                {

                }
            }
        }
        if (player_interact)
        {
            current_angle = new Vector3(0, Mathf.LerpAngle(current_angle.y, target_angle.y, Time.deltaTime), 0);
            door_prefab1.transform.eulerAngles = current_angle;
            door_prefab2.transform.eulerAngles = current_angle;
            door_prefab3.transform.eulerAngles = current_angle;
        }
    }
}