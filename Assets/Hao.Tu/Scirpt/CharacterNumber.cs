using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNumber : MonoBehaviour
{
    [SerializeField]
    private GameObject m_CharacterPf;
    [SerializeField]
    private Transform m_pfParent;

   
    public void _CreateOption()
    {
        var characterEnum = Enum.GetNames(typeof(CharacterEnum));
        foreach (var item in characterEnum)
        {
            Instantiate(m_CharacterPf, m_pfParent);
        }
    }
}
