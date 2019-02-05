using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    [SerializeField]
    public Player m_PlayerPf;
    [SerializeField]
    private List<Player> m_PlayerList = new List<Player>();
    [SerializeField]
    private Transform m_PlayerContent;
    [SerializeField]
    private Transform m_AddNewBtn;
    [SerializeField]
    private GameObject m_CharacterChosePanel;
    [SerializeField]
    private CharacterChose m_CharacterChoseControl;
    private int m_currentIndex=0;
    private int m_SelectedCharacter;


    public void AddNewPlayere()
    {
        //tao player
        Player go = Instantiate(m_PlayerPf , m_PlayerContent);
        go._LoadData("New Player ", m_currentIndex,this,m_CharacterChoseControl);
        m_currentIndex += 1;
        m_PlayerList.Add(go);
        m_AddNewBtn.SetAsLastSibling();
        //add player vao list
    }
    public void RemovePlayerAtIndex(int _Index)
    {
        m_PlayerList.RemoveAt(_Index);
    }
    public void RemovePlayerObject(Player _player)
    {
        m_PlayerList.Remove(_player);
    }

    public void UpdateCharacterNumber()
    {
        int tmp = 0;
        foreach (var item in m_PlayerList)
        {
            if (item._IsCharacterSelected())
            {
                tmp += 1;
            }
        }
        if (tmp == m_PlayerList.Count)
        {
            Debug.Log("du so duong");
        }
    }

    public void _SetActiveChoseCharacter(bool _value)
    {
        m_CharacterChosePanel.SetActive(_value);
    }

}
