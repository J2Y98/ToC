using UnityEngine;
using UnityEngine.UI;

public class Lobby_Event_Keyboard : MonoBehaviour
{
    GameObject Lobby_Camera;

    private void Start()
    {
        Lobby_Camera = transform.gameObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) ||
                Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            if (Lobby_Camera.GetComponent<Lobby_Menu>().Menu == -1)
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu = 0;
            else
            {
                Lobby_Camera.GetComponent<Lobby_Menu>().menu_arrow[Lobby_Camera.GetComponent<Lobby_Menu>().Menu].SetActive(false);
                Lobby_Camera.GetComponent<Lobby_Menu>().menu_select_icon[Lobby_Camera.GetComponent<Lobby_Menu>().Menu].SetActive(false);
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu -= 1;
            }       
            if (Lobby_Camera.GetComponent<Lobby_Menu>().Menu < 0)
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu = 2;
            Lobby_Camera.GetComponent<Lobby_Menu>().menu_arrow[Lobby_Camera.GetComponent<Lobby_Menu>().Menu].SetActive(true);
            Lobby_Camera.GetComponent<Lobby_Menu>().menu_select_icon[Lobby_Camera.GetComponent<Lobby_Menu>().Menu].SetActive(true);

        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) ||
            Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            if (Lobby_Camera.GetComponent<Lobby_Menu>().Menu == -1)
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu = 0;
            else
            {
                Lobby_Camera.GetComponent<Lobby_Menu>().menu_arrow[Lobby_Camera.GetComponent<Lobby_Menu>().Menu].SetActive(false);
                Lobby_Camera.GetComponent<Lobby_Menu>().menu_select_icon[Lobby_Camera.GetComponent<Lobby_Menu>().Menu].SetActive(false);
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu += 1;
            } 
            if (Lobby_Camera.GetComponent<Lobby_Menu>().Menu > 2)
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu = 0;
            Lobby_Camera.GetComponent<Lobby_Menu>().menu_arrow[Lobby_Camera.GetComponent<Lobby_Menu>().Menu].SetActive(true);
            Lobby_Camera.GetComponent<Lobby_Menu>().menu_select_icon[Lobby_Camera.GetComponent<Lobby_Menu>().Menu].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            Lobby_Camera.GetComponent<Lobby_Menu>().menu_select();
        }
    }
}
