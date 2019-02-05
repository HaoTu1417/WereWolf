using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChose : MonoBehaviour {

    public List<string> m_CharacterStringList = new List<string>();
    public Player m_CurrentChosePlayer;

    [SerializeField]
    private PlayerControler m_playerControler;
    public Dictionary<CharacterEnum, Texture2D> m_TextureDic = new Dictionary<CharacterEnum, Texture2D>();
    // Use this for initialization
    void Start () {
        var characterEnum = Enum.GetNames(typeof(CharacterEnum));
        foreach (var item in characterEnum)
        {
            //  if(m_SpriteDic.ContainsKey())
            var dickey = (CharacterEnum)Enum.Parse(typeof(CharacterEnum), item);
            var tmpText2d = Resources.Load<Texture2D>(dickey.ToString());
            if (!m_TextureDic.ContainsKey(dickey))
            {
                m_TextureDic.Add(dickey, tmpText2d);
            }
        }
    }
	
	// Update is called once per framem_
	void Update () {
		
	}
    public void _ChoseACharacter(int _index)
    {
        switch (_index)
        {
            case 0:
                //m_CurrentChosePlayer.m_Character = CharacterEnum.ThoSan;
                m_CurrentChosePlayer._SetCharacter(CharacterEnum.ThoSan, m_TextureDic[CharacterEnum.ThoSan]);
                break;
            case 1:
                //m_CurrentChosePlayer.m_Character = CharacterEnum.Soi;
                m_CurrentChosePlayer._SetCharacter(CharacterEnum.Soi, m_TextureDic[CharacterEnum.Soi]);
                break;
            case 2:
                //m_CurrentChosePlayer.m_Character = CharacterEnum.BaoVe;
                m_CurrentChosePlayer._SetCharacter(CharacterEnum.BaoVe, m_TextureDic[CharacterEnum.BaoVe]);
                break;
            case 3:
                //m_CurrentChosePlayer.m_Character = CharacterEnum.TienTri;
                m_CurrentChosePlayer._SetCharacter(CharacterEnum.TienTri, m_TextureDic[CharacterEnum.TienTri]);
                break;
            case 4:
                //m_CurrentChosePlayer.m_Character = CharacterEnum.PhuThuy;
                m_CurrentChosePlayer._SetCharacter(CharacterEnum.PhuThuy, m_TextureDic[CharacterEnum.PhuThuy]);
                break;
        }
        GameController.m_GameControler.m_PlayerControler._SetActiveChoseCharacter(false);
    }
}



