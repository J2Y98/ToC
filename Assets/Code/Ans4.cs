using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ans4 : MonoBehaviour
{
    public GameObject anTxt;
    private float b = 0;
    public GameObject Q2;
    public GameObject door1;
    public GameObject swer1;
    public GameObject swer2;
    public GameObject swer3;
    public GameObject swer4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (b == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(door1);
                Destroy(Q2);
                Destroy(swer1);
                Destroy(swer2);
                Destroy(swer3);
                Destroy(swer4);
                Destroy(anTxt);
            }
            anTxt.SetActive(true);
        }
        else if (b == 0)
        {
            anTxt.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            b++;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            b--;

        }
    }
}
