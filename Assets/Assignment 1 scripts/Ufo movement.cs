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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Vector2.Lerp(begin.position, end.position, curve.Evaluate(c));
        }
    }
}
