using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Lobby_Menu : MonoBehaviour
{
    public Camera Lobby_Camera;
    public Camera InGame_Camera;
    public GameObject Player;

    private Vector3 moveDirection = Vector3.zero;

    //게임시작, 옵션, 게임 종료 옵션 캔버스
    public GameObject Start_Canvas;
    public GameObject In_Game_Canvas;

    public GameObject Mouse;

    public GameObject[] menu_arrow = new GameObject[3];
    public GameObject[] menu_text = new GameObject[3];
    public GameObject[] menu_select_icon = new GameObject[3];

    public int Menu = -1;
    private bool select = false;
    private bool Ingame = false;

    //화면 이동 및 전환을 위한 메인 카메라
    GameObject Home_Screen;

    //메인화면 카메라 벡터3
    public Vector3 Gamestart_Position;
    public Vector3 Option_Position;
    public Vector3 ExitGame_Position;
    private Vector3 Nothing_Choose_Position;
    private Vector3 current_Position;

    //게임 시작 선택 후 카메라 벡터3
    public Vector3 Select_Position;

    // Start is called before the first frame update
    void Start()
    {
        Display.displays[0].Activate();
        Lobby_Camera.enabled = true;
        InGame_Camera.enabled = false;
        Player.SetActive(false);
        In_Game_Canvas.SetActive(false);
        Nothing_Choose_Position = transform.position;
        current_Position = transform.position;
        Start_Canvas.SetActive(true);
        for(int i = 0; i<3; i++)
        {
            menu_arrow[i].SetActive(false);
            menu_select_icon[i].SetActive(false);
        }
    }

    public void menu_select()
    {
        switch (Menu)
        {
            case 0:
                Start_game();
                break;
            case 1:
                Option();
                break;
            case 2:
                Exit_game();
                break;
        }
    }

    private void Start_game()
    {
        Ingame = true;
        Player.SetActive(true);
        Lobby_Camera.enabled = false;
        InGame_Camera.enabled = true;
        Start_Canvas.SetActive(false);
        In_Game_Canvas.SetActive(true);
    }

    //이 구간은 일단 제외하고 진행
    private void Option()
    {

    }

    private void Exit_game()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if (Ingame)
        {
            Player.SetActive(true);
        }
    }

    private void LateUpdate()
    {
        if (Menu == 0)
        {
            current_Position = Vector3.Lerp(current_Position, Gamestart_Position, Time.deltaTime * 2);
            transform.position = current_Position;
        }
        else if (Menu == 1)
        {
            current_Position = Vector3.Lerp(current_Position, Option_Position, Time.deltaTime * 2);
            transform.position = current_Position;
        }
        else if (Menu == 2)
        {
            current_Position = Vector3.Lerp(current_Position, ExitGame_Position, Time.deltaTime * 2);
            transform.position = current_Position;
        }
        else if (Menu == -1)
        {
            current_Position = Vector3.Lerp(current_Position, Nothing_Choose_Position, Time.deltaTime * 2);
            transform.position = current_Position;
        }
    }
}
