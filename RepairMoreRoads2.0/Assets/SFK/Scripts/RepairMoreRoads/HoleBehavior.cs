using DG.Tweening;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    public Transform fillHoleTrans;

    public void FillHole()
    {
        fillHoleTrans.DOScaleZ(2, 1).SetEase(Ease.InCubic) ;
    }

    public void ShootBall()
    {

    }
}
