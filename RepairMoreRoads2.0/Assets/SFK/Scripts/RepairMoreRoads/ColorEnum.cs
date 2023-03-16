using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEnum : MonoBehaviour
{
    public enum ColorIdentifier
    {
        Blue,
        Red,
        Yellow,
        Green,
    }

    public ColorIdentifier myColor;
    public ColorPropertySetter colorPropertySetter;
    public ParticleSystem particleSystem ;

    public Color GetColor(ColorIdentifier c)
    {
        switch (c)
        {
            case ColorIdentifier.Blue:
                return Color.blue ;
            case ColorIdentifier.Red:
                return Color.red ;
            case ColorIdentifier.Yellow:
                return Color.yellow ;
            case ColorIdentifier.Green:
                return new Color(0.1f, 1f, 0f);
        }
        return Color.white;
    }

    private void Start()
    {
        colorPropertySetter.ApplyColor(GetColor(myColor));
        //particleSystem .startColor = GetColor(myColor);
    }
}
