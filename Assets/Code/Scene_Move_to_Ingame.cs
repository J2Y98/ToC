using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Move_to_Ingame : MonoBehaviour
{
    public GameObject E_image;
    public Text Interact_text;
    private bool Portal_trigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.gameObject.tag == "Player")
        {
            Portal_trigger = true;
            E_image.SetActive(Portal_trigger);
            Interact_text.text = "Interact";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            Portal_trigger = false;
            E_image.SetActive(Portal_trigger);
            Interact_text.text = "";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        E_image.SetActive(false);
        Interact_text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && Portal_trigger)
        {
            SceneManager.LoadScene("Time_Stage");
        }
    }
}
