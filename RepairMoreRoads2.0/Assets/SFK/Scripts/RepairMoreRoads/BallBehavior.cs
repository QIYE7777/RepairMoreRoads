using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public ColorEnum ce;

    public void CloseIsFromHole()
    {
        ce.isFromHole = false;
    }
}
