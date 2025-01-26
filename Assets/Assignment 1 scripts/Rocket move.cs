using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//udpate the game object position to mouse position
        transform.position = mousePos;//Update the position of the game object to where the mouse is
    }
}
