using UnityEngine;
using UnityEngine.UI;

public class Seed : MonoBehaviour
{
    public GameObject canvas;
    GameObject seed;
    public Text Interact_text;

    bool player_is_near = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player_is_near = true;
            Interact_text.text = "Get";
        }    
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player_is_near = false;
            Interact_text.text = "";
        }
    }

    private void Awake()
    {
        seed = transform.gameObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (player_is_near)
            {

            }
        }
    }
}
