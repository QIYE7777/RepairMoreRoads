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
    public bool isFromHole;

    public Color GetColor(ColorIdentifier c)
    {
        switch (c)
        {
            case ColorIdentifier.Blue:
                return new Color(0.3f,0.7f,0.9f) ;
            case ColorIdentifier.Red:
                return new Color(0.9f, 0.4f, 0.4f);
            case ColorIdentifier.Yellow:
                return new Color(0.9f,0.8f,0.3f) ;
            case ColorIdentifier.Green:
                return new Color(0.3f, 0.9f, 0.3f);
        }
        return Color.white;
    }

    private void Start()
    {
        colorPropertySetter.ApplyColor(GetColor(myColor));
    }
}
