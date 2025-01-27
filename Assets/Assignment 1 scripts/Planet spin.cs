using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetspin : MonoBehaviour
{
    public float PlanetSpeed = 0.05f;// a veriable that showcases the speed of rotation of the planet also made public so it can be changed in unity
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 planetSpeed = transform.eulerAngles;//update the position of the spinning for a vector3/3d object

        planetSpeed.z -= PlanetSpeed;//make the planets spin in the z position because z position is the position where wwe can see the 2d object spinning
        
        transform.eulerAngles = planetSpeed;//update the planets to spin around
    }
}
