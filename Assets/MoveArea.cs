using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArea : MonoBehaviour
{
    public PlayerScript ps;

    public void OnMouseDown()
    {
        ps.SetNewDestination();
        Debug.Log("Click erkannt");
    }
}
