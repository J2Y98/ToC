using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    
    private bool ladder = false;
    float speed = 6f;
    float jumpPower = 8f;
    float gravity = 20f;
    float mouseX = 0;

    public GameObject caObject;
    public GameObject caObject2;
    public GameObject Sand_Clock;
    public GameObject sickle;
    public GameObject Sand_Clock1;
    public GameObject sickle1;
    public GameObject Grass;
    public GameObject Grass1;
    public GameObject Grass2;
    public GameObject Grass3;
    public GameObject seed_Grass;
    public GameObject seed_Grass1;
    public GameObject seed_Grass2;
    public GameObject seed_Grass3;
    public GameObject water;
    public GameObject door3;
    public GameObject end;
    public GameObject door4;


    float A = 0;
    float B = 0;
    float C = 0;



    private bool gr = false;
    private float key = 1;
    private bool ca = false;
    public float time = 0;

    private Vector3 moveDirection = Vector3.zero;
    private void Start()
    {
        
        seed_Grass.SetActive(false);
        seed_Grass1.SetActive(false);
        seed_Grass2.SetActive(false);
        seed_Grass3.SetActive(false);
        water.SetActive(false);
        Grass.SetActive(false);
        Grass1.SetActive(false);
        Grass2.SetActive(false);
        Grass3.SetActive(false);
        sickle.SetActive(false);
        sickle1.SetActive(false);
        Sand_Clock1.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        Ladder();
        if (ca == true)
        {
            caObject2.SetActive(true);
            caObject.SetActive(false);
            time += Time.fixedDeltaTime;
            if (time >= 40.0f)
                caObject2.SetActive(false);
            caObject.SetActive(true);

        }
        else
        {
            caObject2.SetActive(false);
            caObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.LeftShift)) speed = 8f;
        else speed = 4f;


    }



    

    void Ladder()
    {
        if (ladder == true)
        {
            CharacterController controller = GetComponent<CharacterController>();
            moveDirection = new Vector2(0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
        else
        {
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

        }
        mouseX += Input.GetAxis("Mouse X") * 10;
        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Ladder")
        {
            ladder = true;
        }
        if (hit.gameObject.tag == "Altar")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(Sand_Clock);
                A++;
            }
        }
        if (hit.gameObject.tag == "Altar1")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(sickle);
                B++;
            }
        }
        if (hit.gameObject.tag == "end")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hit.gameObject);
                sickle.SetActive(true);
                water.SetActive(true);
                Grass.SetActive(true);
                Grass1.SetActive(true);
                Grass2.SetActive(true);
                Grass3.SetActive(true);

            }

        }
        if (hit.gameObject.tag == "Altar2")
        {   if(A == 1)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Sand_Clock1.SetActive(true);
                }
            }
   
        }
        if (hit.gameObject.tag == "Altar3")
        {
            if (B == 1)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    sickle1.SetActive(true);
                    door4.SetActive(false);
                }
            }

            

        }
        if (hit.gameObject.tag == "sg")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                seed_Grass.SetActive(true);
                
            }
        }
        if (hit.gameObject.tag == "sg1")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                seed_Grass1.SetActive(true);
                
            }
        }
        if (hit.gameObject.tag == "sg2")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                seed_Grass2.SetActive(true);
                
            }
        }
        if (hit.gameObject.tag == "sg3")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                seed_Grass3.SetActive(true);
                door3.SetActive(false);

            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Ground")
        {
            ladder = false;
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }

    }
}
