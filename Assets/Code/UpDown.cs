using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    float mouseSpeed = 10;
    float mouseY = 0;

    // Update is called once per frame
    void Update()
    {
        mouseY += Input.GetAxis("Mouse Y") * mouseSpeed;
        mouseY = Mathf.Clamp(mouseY, -55.0f, 55.0f);
        transform.localEulerAngles = new Vector3(-mouseY, 0, 0);
    }
}
