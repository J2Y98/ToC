using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobby_Move : MonoBehaviour
{
    float speed = 6f;
    float jumpPower = 8f;
    float gravity = 20f;
    float mouseX = 0;

    private Vector3 moveDirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) speed = 8f;
        else speed = 4f;

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpPower;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        mouseX += Input.GetAxis("Mouse X") * 10;
        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }
}
