using DG.Tweening;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    public Transform fillHoleTrans;
    public AudioSource closeDoor;
    public ParticleSystem particleSystem;

    private void Awake()
    {
        closeDoor = GetComponent<AudioSource>();
        particleSystem = GetComponent<ParticleSystem>();
    }
    public void FillHole()
    {
        fillHoleTrans.DOScaleZ(2, 1).SetEase(Ease.InCubic) ;
        particleSystem.Play();   
        closeDoor.Play();
    }

    public void ShootBall()
    {

    }
}
