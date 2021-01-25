using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject commandMenu;
    public InteractibalObject activeIO;
    //public Text df;
    //public string inspectText;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Inspect()
    {
       
        activeIO.df.text = activeIO.inspectText;
        Debug.Log("Click UI erkannt");

    }

    public void Collect()
    {
        activeIO.img.sprite = activeIO.sr.sprite;
    }

    
}
