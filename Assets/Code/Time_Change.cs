using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Change : MonoBehaviour
{
    public Material Sunrise;
    public Material Sunset;
    public Material Night;
    public GameObject Sun_Light;
    private Light light;
    private Color color;
    private string Tint = "_SkyTint";

    private int time_set = 0; //0 = 아침, 1 = 오후, 2 = 저녁

    private void Awake()
    {
        light = Sun_Light.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            switch (time_set)
            {
                case 0:
                    RenderSettings.skybox = Sunset;
                    color = new Color(0.5f, 0.5f, 0.5f, 0.5019f);
                    RenderSettings.skybox.SetColor(Tint, color);
                    Sun_Light.transform.eulerAngles = new Vector3(20, 60, 0);
                    color = new Color(1, 0.82f, 0.75f, 0);
                    light.color = color;
                    light.intensity = 0.8f;
                    time_set = 1;
                    break;
                case 1:
                    RenderSettings.skybox = Night;
                    color = new Color(0.5f, 0.5f, 0.5f, 0.5019f);
                    RenderSettings.skybox.SetColor(Tint, color);
                    Sun_Light.transform.eulerAngles = new Vector3(40, 40, 0);
                    color = new Color(0.4f, 0.7f, 1, 1);
                    light.color = color;
                    light.intensity = 0.1f;
                    time_set = 2;
                    break;
                case 2:
                    RenderSettings.skybox = Sunrise;
                    color = new Color(0.5f, 0.5f, 0.5f, 0.5019f);
                    RenderSettings.skybox.SetColor(Tint, color);
                    Sun_Light.transform.eulerAngles = new Vector3(110, 70, 0);
                    color = new Color(1, 1, 1, 0);
                    light.color = color;
                    light.intensity = 1.2f;
                    time_set = 0;
                    break;
            }
        }
    }
}
