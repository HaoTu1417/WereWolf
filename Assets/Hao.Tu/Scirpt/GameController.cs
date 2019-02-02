using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController m_GameControler;

    [SerializeField]
    private List<GameObject> m_PanelList = new List<GameObject>();



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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

