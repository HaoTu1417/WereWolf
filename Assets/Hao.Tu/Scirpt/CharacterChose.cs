using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChose : MonoBehaviour {

    public List<string> m_CharacterStringList = new List<string>();

	// Use this for initialization
	void Start () {
        var values = Enum.GetValues(typeof(CharacterEnum));
        foreach (var item in values)
        {
            Debug.Log(item);
            if (!item.Equals("None"))
            {
                m_CharacterStringList.Add(item.ToString());
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}



