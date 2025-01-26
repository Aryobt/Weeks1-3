using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetspin : MonoBehaviour
{
    public float planetSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spinSpeed = transform.eulerAngles;
        spinSpeed.z -= planetSpeed;
        transform.eulerAngles = spinSpeed;
    }
}
