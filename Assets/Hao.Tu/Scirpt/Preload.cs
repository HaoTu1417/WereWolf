using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preload : MonoBehaviour {

    public static Preload m_Instance;
    [SerializeField]
    private LoadingScene m_LoadingScene;

	// Use this for initialization
	void Start () {
        m_Instance = this;
        m_LoadingScene.enabled = true;

    }
	

}
