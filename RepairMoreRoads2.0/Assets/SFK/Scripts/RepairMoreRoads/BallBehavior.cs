using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public ColorEnum ce;
    public Rigidbody rb;

    public void CloseIsFromHole()
    {
        ce.isFromHole = false;
    }

    public void CloseKinematic()
    {
       StartCoroutine (Delay());
    }
    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.25f);
        rb.isKinematic = false;
        Debug.Log("Close kinematic");
        Debug.Log(rb.gameObject);
    }
}
