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
            ScriptTxt.text = "���� ���̵� �������� ���� �ؾ��� �ٹ��Ÿ��ٰ��� �ᱹ �ؾ� �� ���� ���ϰ� �ȴ�.";
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
