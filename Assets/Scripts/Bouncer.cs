using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Bouncer : MonoBehaviour
{
    [Range(0,1)]
    public float t;
    public float speed = 10;
    public float speed2 = 1;
    bool jump = false;
    public AnimationCurve curve;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.y += speed * Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            jump = true;
            transform.position += transform.up * speed * Time.deltaTime;
            
        }
     //if (Input.GetKeyUp(KeyCode.Space))
       // {
           // Vector3 spinSpeed = transform.eulerAngles;
           // spinSpeed.z += 10f;
           // transform.eulerAngles = spinSpeed;
       // }
       
     if (jump == true) 
        {
            transform.position -= transform.up * speed2 * Time.deltaTime;
        }
}
}
