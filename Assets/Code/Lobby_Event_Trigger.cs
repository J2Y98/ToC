using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Lobby_Event_Trigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public GameObject Lobby_Camera;
    int Pointer;

   public void OnPointerEnter(PointerEventData eventData)
    {
        switch (Pointer)
        {
            case 0:
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu = 0;
                break;
            case 1:
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu = 1;
                break;
            case 2:
                Lobby_Camera.GetComponent<Lobby_Menu>().Menu = 2;
                break;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Lobby_Camera.GetComponent<Lobby_Menu>().Menu = -1;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Lobby_Camera.GetComponent<Lobby_Menu>().menu_select();
    }

    private void Start()
    {
        if(transform.gameObject == Lobby_Camera.GetComponent<Lobby_Menu>().menu_text[0])
        {
            Pointer = 0;
        }
        else if(transform.gameObject == Lobby_Camera.GetComponent<Lobby_Menu>().menu_text[1])
        {
            Pointer = 1;
        }
        else if(transform.gameObject == Lobby_Camera.GetComponent<Lobby_Menu>().menu_text[2])
        {
            Pointer = 2;
        }
    }
}
