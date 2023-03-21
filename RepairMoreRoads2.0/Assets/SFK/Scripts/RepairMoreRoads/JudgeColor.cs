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
        sameColorHas = false;
    }

    bool sameColorHas;
    public bool differColorHas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball" )
        {
            if (colorEnum.myColor == other.GetComponent<ColorEnum>().myColor && sameColorHas == false )
            {
                Debug.Log("same");
                sameColorHas = true;
                holeBehavior.FillHole(other);
                
            }
            if (colorEnum.myColor != other.GetComponent<ColorEnum>().myColor && differColorHas == false)
            {
                holeBehavior.ShootBall();
                differColorHas = true;
                StartCoroutine (Delay());
                Debug.Log("diff");
            }
        }
        if (other.tag == "People")
        {
            holeBehavior.AfterTouchPeople(other);
        }
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.25f);
        differColorHas = false;
    }
}
