using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPf : MonoBehaviour {

    [SerializeField]
    private RawImage m_CharacterImg;
    [SerializeField]
    private Dropdown m_QuantityInputField;
    [SerializeField]
    private List<string> m_ListOfQuantity = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
    [SerializeField]
    private CharacterNumber m_CharacterNumber;

    public void _SetupData(Texture2D _tex,int _DefaultNum, CharacterChose _characterChose)
    {
        m_CharacterImg.texture = _tex;
        m_QuantityInputField.AddOptions(m_ListOfQuantity);
        m_QuantityInputField.value=_DefaultNum;
        m_QuantityInputField.RefreshShownValue();


    }
    public void _ChangeCharacterQuantity(int _value)
    {

    }
}
