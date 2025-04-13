using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPath : MonoBehaviour
{
    public Transform[] positionPoint;
    private void OnDrawGizmos()
    {
        iTween.DrawPath(positionPoint, Color.green);
    }
}
