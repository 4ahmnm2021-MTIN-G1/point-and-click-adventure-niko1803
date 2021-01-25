using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractibalObject : MonoBehaviour
{
    public GameObject commandMenu;
    public Transform reposition;
    public UIManager uIManager;
    public Text df;
    public string inspectText;

    public SpriteRenderer sr;
    public Image img;

   public void Start()
    {
        commandMenu.active = false;
          
    }

    public void Update()
    {

    }

    public void OnMouseDown()
    {
        commandMenu.active = true;
        commandMenu.transform.position = reposition.position;
        uIManager.activeIO = this;
        // df.text = inspectText;
        
    }
}
