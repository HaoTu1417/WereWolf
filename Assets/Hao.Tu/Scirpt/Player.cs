using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private bool isAlive;
    public CharacterEnum m_Character=CharacterEnum.None;
    [SerializeField]
    private RawImage m_CharacterImage;
    [SerializeField]
    private InputField m_PlayerName;
    private PlayerControler m_PlayerControl;
    private int m_IndexInList;
    private CharacterChose m_CharacterChose;

   public void _LoadData(string _name,int _index,PlayerControler _playerControl, CharacterChose _characterChose)
    {
        m_PlayerName.text = _name+" "+_index+1;
        m_IndexInList = _index;
        m_PlayerControl = _playerControl;
        m_CharacterChose = _characterChose;
    }

    public void _RemovePlayer()
    {
        m_PlayerControl.RemovePlayerObject(this);
        Destroy(gameObject);
    }

    public void _HighLightText()
    {
        m_PlayerName.Select();
        Debug.Log("Selected");
    }
    public bool _IsCharacterSelected()
    {
        if (m_Character != CharacterEnum.None)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void _ChangeCharacter()
    {
        m_PlayerControl._SetActiveChoseCharacter(true);
        m_CharacterChose.m_CurrentChosePlayer = this;

    }
    public void _SetCharacter(CharacterEnum _CharEnum,Texture2D _texture)
    {
        m_Character = _CharEnum;
        m_CharacterImage.color = Color.white;
        m_CharacterImage.texture = _texture;
    }

}
