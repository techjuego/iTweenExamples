using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndResumeExample : MonoBehaviour
{
    public GameObject[] box;

    public void PlayTween()
    {
        for (int i = 0; i < box.Length; i++)
        {
            Vector3 newpos = box[i].transform.position + new Vector3(20, 0, 0);
            iTween.MoveTo(box[i],iTween.Hash("position",newpos,"time",Random.Range(5,10)));
        }
    }
    public void PauseTween()
    {
        iTween.Pause();
    }
    public void ResumeTween()
    {
        iTween.Resume();
    }
}
