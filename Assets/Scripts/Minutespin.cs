using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minutespin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spinSpeed = transform.eulerAngles;
        spinSpeed.z += 0.6f;
        transform.eulerAngles = spinSpeed;
    }
}
