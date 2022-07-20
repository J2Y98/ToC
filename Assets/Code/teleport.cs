using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    private CharacterController controller;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        controller = other.gameObject.GetComponent<CharacterController>();
        controller.enabled = false;
        other.gameObject.transform.position = target.position;
        controller.enabled = true;
    }

}
