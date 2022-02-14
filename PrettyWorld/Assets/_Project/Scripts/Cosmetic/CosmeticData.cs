using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "CosmeticData", menuName = "Data/Cosmetic")]
public class CosmeticData : ScriptableObject
{
    [SerializeField]
    private RuntimeAnimatorController _animations;
    [SerializeField]
    private Sprite _sprite;
    [SerializeField]
    private string _name;
    [SerializeField]
    private int _price;
    [SerializeField]
    private CosmeticType _cosmeticType;

    public RuntimeAnimatorController Animations
    {
        get { return _animations; }
    }

    public Sprite Sprite
    {
        get { return _sprite; }
    }

    public string Name
    {
        get { return _name; }
    }

    public int Price
    {
        get { return _price; }
    }

    public CosmeticType CosmeticType
    {
        get { return _cosmeticType; }
    }
}
