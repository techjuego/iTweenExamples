using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Update : MonoBehaviour
{
    public Vector3 starValue;
    public Vector3 endValue;
    public float speed;

    void Start()
    {
        iTween.Vector3Update(starValue, endValue, speed);
    }

    void Update()
    {
        
    }
}
