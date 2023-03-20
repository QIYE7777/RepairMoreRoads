using DG.Tweening;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    public Transform fillHoleTrans;
    public AudioSource closeDoor;
    public ParticleSystem particleSystem;
    public SpwanBall sb;
    public ColorEnum colorEnum;
    public HoleShooter holeShooter;

    private void Awake()
    {
        
    }

    private void Start()
    {
        if (gameObject == null)
            Debug.LogWarning(gameObject.name);
        closeDoor = GetComponent<AudioSource>();
        particleSystem = GetComponent<ParticleSystem>();
        sb = RepairMoreRoadsManager.instance.player.GetComponent<SpwanBall>();
        colorEnum = GetComponent<ColorEnum>();
        var nowColor = colorEnum.GetColor(colorEnum.myColor);
        SetParticleColor(nowColor);
    }

    public void FillHole(Collider ball)
    {
        fillHoleTrans.DOScaleZ(4, 1).SetEase(Ease.InCubic);
        particleSystem.Play();
        closeDoor.Play();
        DestroyBall(ball);
        SpawnNewBall();
    }

    public void DestroyBall(Collider ball)
    {
        //Destroy(ball.gameObject,3 );
    }

    void SpawnNewBall()
    {
        sb.Spawn();
    }

    public void SetParticleColor(Color color)
    {
        var newMain = particleSystem.main;
        newMain.startColor = color;
    }

    public void AfterTouchPeople(Collider people)
    {
        DestroyPeple(people);
        fillHoleTrans.DOScaleZ(4, 1).SetEase(Ease.InCubic);
        particleSystem.Play();
        closeDoor.Play();
        RepairMoreRoadsManager.instance.deadPeople = RepairMoreRoadsManager.instance.deadPeople + 1;
        Debug.Log(RepairMoreRoadsManager.instance.deadPeople);
    }
    public void DestroyPeple(Collider people)
    {
        Destroy(people.gameObject);
    }

    public void ShootBall()
    {
        Debug.LogWarning(holeShooter.gameObject);
        holeShooter.SpawnBall();
        //holeShooter.rigidbody  = GetComponent<Rigidbody>();
        //holeShooter.Shoot();
    }
}
