using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPathExample1 : MonoBehaviour
{
    public Vector3[] positionPoint;
    private void OnDrawGizmos()
    {
        iTween.DrawPath(positionPoint, Color.green);
    }
}
