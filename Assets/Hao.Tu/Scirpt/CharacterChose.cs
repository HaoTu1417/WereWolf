using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChose : MonoBehaviour {

    public List<string> m_CharacterStringList = new List<string>();
    public Player m_CurrentChosePlayer;

	// Use this for initialization
	void Start () {
        //var values = Enum.GetValues(typeof(CharacterEnum));
        //foreach (var item in values)
        //{
        //    Debug.Log(item);
        //    Instantiate(Resources.Load("Hatchet"));
        //}
	}
	
	// Update is called once per framem_
	void Update () {
		
	}
    public void _ChoseACharacter(int _index)
    {
        switch (_index)
        {
            case 0:
                m_CurrentChosePlayer.m_Character = CharacterEnum.ThoSan;
                break;
            case 1:
                m_CurrentChosePlayer.m_Character = CharacterEnum.Soi;
                break;
            case 2:
                m_CurrentChosePlayer.m_Character = CharacterEnum.BaoVe;
                break;
            case 3:
                m_CurrentChosePlayer.m_Character = CharacterEnum.TienTri;
                break;
            case 4:
                m_CurrentChosePlayer.m_Character = CharacterEnum.PhuThuy;
                break;
        }
        GameController.m_GameControler.m_PlayerControler._SetActiveChoseCharacter(false);
    }
}



