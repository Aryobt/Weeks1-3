using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ufomovement : MonoBehaviour
{
    [Range(0, 1)]//a public class that gives the curve a range
    public float c;//making a public veraible for the name the curve 
    public AnimationCurve curve;//making a public variable for the animation curve and named it curve
    public Transform begin;//public veriable for the starting position of the Ufo
    public Transform end;//public veriable for the ending position of the Ufo
    public float Ufospeed = 0.5f;//public veriable for the Ufo speed
    // Start is called before the first frame update
    void Start()
    {
        c = 0;//the curve value is equal to zero
    }

    // Update is called once per frame
    void Update()
    {
       
            c += Time.deltaTime * Ufospeed;// making the movement smoother with Time.deltaTime

        if(c > 1)//if the c value is under 1 c is equal to zero
        {
            c = 0;
        }
        transform.position = Vector2.Lerp(begin.position, end.position, curve.Evaluate(c));//update the position of the curved object
    }


}
