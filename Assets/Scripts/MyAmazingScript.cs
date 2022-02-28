using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAmazingScript : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject arms;
    public float speed;
    public float headStretch;

    void Start()
    {
        
    }

    
    void Update()
    {
        head.transform.position += Vector3.up * speed * 1.2f;
        body.transform.position += Vector3.up * speed;
        head.transform.localScale += headStretch * Vector3.right;
        arms.transform.position += Vector3.up * speed;
    }
}
