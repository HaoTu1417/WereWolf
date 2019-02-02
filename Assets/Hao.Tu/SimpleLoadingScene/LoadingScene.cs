using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour {

    [SerializeField]
    private RectTransform m_LoadingIcon;
    [SerializeField]
    private Text m_LoadingPercentTxt;
    [SerializeField]
    private float m_virtualLoadingTime;
    [SerializeField]
    private Text m_PAK;
    [SerializeField]
    private CanvasGroup m_CanvasGroup;
    private bool m_DisableCanvasGroup;
    private AsyncOperation m_LoadingProgress;

    public float speed = -3;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        m_LoadingProgress = SceneManager.LoadSceneAsync(1);
        m_LoadingProgress.allowSceneActivation = false;

    }

  
	// Update is called once per frame
	void Update () {
        //rotate the icon
        if (m_LoadingIcon != null)
        {
            m_LoadingIcon.Rotate(0, 0, speed);
        }
        //loading progress percent display
        if (m_LoadingProgress != null)
        {
            m_LoadingPercentTxt.text = "Loading\n" + m_LoadingProgress.progress * 100 + " %";
        }
        //loading nearly complete
        if (m_virtualLoadingTime > 0)
        {
            m_virtualLoadingTime -= Time.deltaTime;
        }
        if (m_LoadingProgress.progress >= 0.9f && m_virtualLoadingTime<0)
        {
            m_LoadingProgress.allowSceneActivation = true;
        }
        if (m_LoadingProgress.isDone)
        {
            m_PAK.color = new Color(m_PAK.color.r, m_PAK.color.g, m_PAK.color.b, Mathf.PingPong(Time.time, 1));
            if (Input.anyKeyDown)
            {
                Debug.Log("down");
                gameObject.transform.localScale = Vector3.zero;
                m_DisableCanvasGroup = true;

            }
            if (Input.touchCount > 0)
            {
                gameObject.transform.localScale = Vector3.zero;
            }

        }
        if (m_DisableCanvasGroup && m_CanvasGroup.alpha >0)
        {
            m_CanvasGroup.alpha -= Time.deltaTime;
        }
	}
}
