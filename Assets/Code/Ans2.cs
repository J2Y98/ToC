using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ans2 : MonoBehaviour
{
    public Text anTxt;
    private float b = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (b == 1)
        {
            anTxt.text = "열 길 물속은 알아도 한 길 사람 속은 모른다. ";
        }
        else if (b == 0)
        {
            anTxt.text = "";
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
