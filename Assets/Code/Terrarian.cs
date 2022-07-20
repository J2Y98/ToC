using UnityEngine;
using UnityEngine.UI;

public class Terrarian : MonoBehaviour
{
    public GameObject canvas;
    public Text Interact_text;

    public GameObject terra;
    public GameObject grass;
    public int terrarian_num;
    public GameObject player;
    public GameObject Water_Lever;
    public int time = 0;
    bool grass_grow = false;

    private void Awake()
    {
        grass.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.gameObject.tag == "Player")
        {
            collision.transform.gameObject.GetComponent<Grow>().terrarian_count = terrarian_num;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.gameObject.tag == "Player")
        {
            collision.transform.gameObject.GetComponent<Grow>().terrarian_count = -1;
        }
    }

    private void Update()
    {
        if(terrarian_num == player.transform.gameObject.GetComponent<Grow>().terrarian_count)
        {
            grass_grow = true;
        }
        if (Water_Lever.gameObject.GetComponent<Water>().water && grass_grow)
        {
            grass.SetActive(true);
        }
    }
}
