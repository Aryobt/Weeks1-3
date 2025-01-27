using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ufomovement : MonoBehaviour
{
    [Range(0, 1)]
    public float c;
    public float Ufospeed;
    public AnimationCurve curve;
    public Transform begin;
    public Transform end;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += Ufospeed * Time.deltaTime;

        Vector2 begin = Camera.main.WorldToScreenPoint(pos);

        if (begin.x < 0 || begin.x > end)
        {
            Ufospeed = Ufospeed * -1;
        }

        transform.position = pos;
    }


}
