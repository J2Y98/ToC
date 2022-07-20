using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q2 : MonoBehaviour
{
    public Text ScriptTxt;
    private float a = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (a == 1)
        {
            ScriptTxt.text = "무슨 일이든 부지런히 힘써 해야지 꾸물거리다가는 결국 해야 할 일을 못하게 된다.";
        }
        else if (a == 0)
        {
            ScriptTxt.text = "";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a++;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            a--;

        }
    }
}
