using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAddExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        iTween.MoveAdd(gameObject, Vector3.one, 5);
    }
}
