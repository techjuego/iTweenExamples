using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineGizmozExample1 : MonoBehaviour
{
    public Transform[] positions;
    private void OnDrawGizmos()
    {
        iTween.DrawLineGizmos(positions, Color.green);
    }
}
