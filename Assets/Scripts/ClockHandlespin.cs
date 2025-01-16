using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandlespin : MonoBehaviour
{
    public float SpinSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 spinSpeed = transform.eulerAngles;
        spinSpeed.z -= SpinSpeed;
        transform.eulerAngles = spinSpeed;

    }
}
