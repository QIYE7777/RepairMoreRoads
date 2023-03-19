using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeColor : MonoBehaviour
{
    public BoxCollider checkCollider;
    ColorEnum colorEnum;
    HoleBehavior holeBehavior;

    private void Awake()
    {
        colorEnum = GetComponent<ColorEnum> ();
        holeBehavior = GetComponent<HoleBehavior>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball" )
        {
            if (colorEnum.myColor == other.GetComponent<ColorEnum>().myColor)
            {
                Debug.Log("same");
                holeBehavior.FillHole(other);
                
            }
            else
            {
                Debug.Log("diff");
                holeBehavior.ShootBall();
            }
        }
        if (other.tag == "People")
        {
            holeBehavior.AfterTouchPeople(other);
        }
    }

}
