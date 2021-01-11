using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExampleClass : MonoBehaviour
{
    public float Name1;
    public int Name2;
    public bool Name3;
    public string Name4;
    public HingeJoint hj;
    public SpriteRenderer sr;
    public GameObject go;
    public AudioSource audio;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hj.massScale = Name1;
        sr.sortingOrder = Name2;
        go.name = Name4;
        audio.loop = Name3;
    }
}
