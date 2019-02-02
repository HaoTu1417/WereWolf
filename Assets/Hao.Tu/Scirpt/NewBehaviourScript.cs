using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<string> tmolst = new List<string>();
        tmolst.Add("a");
        tmolst.Add("b");
        tmolst.Add("c");
        tmolst.Add("d");
        tmolst.RemoveAt(2);
        Debug.Log(tmolst[2]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
