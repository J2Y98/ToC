using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q1 : MonoBehaviour
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
            ScriptTxt.text = "하루 동안에도 많은 일을 할 수 있다는 말로, 하루의 시간도 매우 중요함을 뜻한다.";
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
