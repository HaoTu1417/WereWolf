using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController m_GameControler;

    [SerializeField]
    private List<GameObject> m_PanelList = new List<GameObject>();

    //Controller
    public PlayerControler m_PlayerControler;

    // Use this for initialization
    void Start()
    {
        if (Preload.m_Instance == null)
        {
            SceneManager.LoadScene("Preload");
        }
        else
        {
            m_GameControler = this;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeScene(int _index)
    {

        for (int i = 0; i < m_PanelList.Count; i++)
        {
            m_PanelList[i].SetActive(false);
        }
        m_PanelList[_index].SetActive(true);
    }

}
public enum PanelNameEnum
{
    MainMenu,
    AddPlayer
}

