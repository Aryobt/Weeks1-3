using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ufomovement : MonoBehaviour
{
    [Range(0, 1)]
    public float c;
    public AnimationCurve curve;
    public Transform begin;
    public Transform end;
    public float Ufospeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        c = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            c += Time.deltaTime * Ufospeed;
        //}
        if(c > 1)
        {
            c = 0;
        }
        transform.position = Vector2.Lerp(begin.position, end.position, curve.Evaluate(c));
    }


}
