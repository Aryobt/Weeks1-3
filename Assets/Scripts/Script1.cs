using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if(squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        transform.position = pos;
    }
}
