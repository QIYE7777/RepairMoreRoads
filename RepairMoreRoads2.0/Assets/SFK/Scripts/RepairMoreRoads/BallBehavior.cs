using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public ColorEnum ce;
    public Rigidbody rb;
    float touchGroundTime;
    public MySpawn mySpawn;
    public Rigidbody rd;
    public Transform playerRd;
    bool has;

    private void Start()
    {
        touchGroundTime = 0;
        mySpawn = RepairMoreRoadsManager.instance.player.GetComponent<MySpawn>();
        playerRd = RepairMoreRoadsManager.instance.player.GetComponent<Transform  >();
        has = false;
    }

    private void Update()
    {
        if (touchGroundTime >= 4)
        {
            if (has == false)
            {
                rd.MovePosition(playerRd.position + new Vector3(0f, 8f, 2f));
                touchGroundTime = 0;
                has = true;
            }
        }
    }

    public void CloseIsFromHole()
    {
        ce.isFromHole = false;
    }

    public void CloseKinematic()
    {
        StartCoroutine(Delay());
    }
    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.25f);
        rb.isKinematic = false;
        Debug.Log("Close kinematic");
        Debug.Log(rb.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            touchGroundTime = touchGroundTime + 1;
            Debug.Log(touchGroundTime);
        }
    }
}
