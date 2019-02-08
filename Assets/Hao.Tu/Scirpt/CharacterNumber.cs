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
        Debug.Log("Create option");
        var characterEnum = Enum.GetNames(typeof(CharacterEnum));
        foreach (var item in characterEnum)
        {
            Debug.Log("in for");
            CharacterPf tmp = Instantiate(m_CharacterPf, m_pfParent);
            CharacterEnum tmpEnum = (CharacterEnum)Enum.Parse(typeof(CharacterEnum), item, true);
            tmp._SetupData(m_characterChose.m_TextureDic[tmpEnum], 0, m_characterChose);
        }
    } 
    
}
