using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private bool isAlive;
    private CharacterEnum m_Character;
    [SerializeField]
    private Image m_CharacterImage;
    [SerializeField]
    private InputField m_PlayerName;
    private PlayerControler m_PlayerControl;
    private int m_IndexInList;

   public void _LoadData(string _name,int _index,PlayerControler _playerControl)
    {
        m_PlayerName.text = _name+" "+_index+1;
        m_IndexInList = _index;
        m_PlayerControl = _playerControl;
    }

    public void _RemovePlayer()
    {
        m_PlayerControl.RemovePlayerObject(this);
        Destroy(gameObject);
    }

}
