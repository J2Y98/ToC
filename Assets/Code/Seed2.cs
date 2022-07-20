using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seed2 : MonoBehaviour
{
    public GameObject anTxt;
    public GameObject seed;
    public GameObject door;
    private float b = 0;

    // Start is called before the first frame update
    void Start()
    {
        anTxt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (b == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                seed.SetActive(false);
                Destroy(anTxt);
                door.SetActive(false);
            }
            anTxt.SetActive(true);
        }
        else if (b <= 0)
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
