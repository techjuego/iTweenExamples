using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject m_PauseUI;
    // Start is called before the first frame update
    void Start()
    {
        m_PauseUI.transform.localPosition = new Vector3(720, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        iTween.MoveTo(m_PauseUI,iTween.Hash("x",0,"time",1,"ignoretimescale",true,"islocal",true));
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        iTween.MoveTo(m_PauseUI, iTween.Hash("x", 720, "time", 1, "ignoretimescale", true, "islocal", true));
    }
    //
   
}
