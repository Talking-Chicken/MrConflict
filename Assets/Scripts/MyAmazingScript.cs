using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAmazingScript : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        head.transform.position += Vector3.up * speed;
        body.transform.position += Vector3.up * speed;
    }
}
