using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNumber : MonoBehaviour
{
    [SerializeField]
    private CharacterPf m_CharacterPf;
    [SerializeField]
    private Transform m_pfParent;
    [SerializeField]
    private CharacterChose m_characterChose;
    [SerializeField]
    private int m_TotalNumber;


    public void _CreateOption()
    {
        var characterEnum = Enum.GetNames(typeof(CharacterEnum));
        foreach (var item in characterEnum)
        {

            CharacterPf tmp = Instantiate(m_CharacterPf, m_pfParent);
            CharacterEnum tmpEnum = (CharacterEnum)Enum.Parse(typeof(CharacterEnum), item, true);
            tmp._SetupData(m_characterChose.m_TextureDic[tmpEnum], 0, m_characterChose,this);
        }
    } 
    
    public void _IncreasePlayer(int _num)
    {
        m_TotalNumber += _num;
    }
    public void _DecreasePlayer(int _num)
    {
        m_TotalNumber -= _num;
    }
}
