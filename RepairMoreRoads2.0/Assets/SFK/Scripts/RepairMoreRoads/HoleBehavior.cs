using DG.Tweening;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    public Transform fillHoleTrans;
    public AudioSource closeDoor;

    private void Awake()
    {
        closeDoor = GetComponent<AudioSource>();
    }
    public void FillHole()
    {
        fillHoleTrans.DOScaleZ(2, 1).SetEase(Ease.InCubic) ;
        
        closeDoor.Play();
    }

    public void ShootBall()
    {

    }
}
