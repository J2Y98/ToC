using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject water;
    public GameObject Lever;

    private void Start()
    {
        water.SetActive(false);
    }
}