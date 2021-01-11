using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform Trans;
    public Vector3 mousePos;
    public Vector3 worldPos;
    public Vector3 playerPos;
    public float Speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = Trans.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        Trans.position = Vector3.MoveTowards(Trans.position,playerPos,Speed);
    }

    public void SetNewDestination()
    {
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        playerPos = new Vector3(worldPos.x, worldPos.y, Trans.position.z);
    }
}
