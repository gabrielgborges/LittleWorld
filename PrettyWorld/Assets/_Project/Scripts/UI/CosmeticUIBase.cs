using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CosmeticUIBase : MonoBehaviour
{
    [SerializeField]
    private Button _cosmeticImage;

    private CosmeticData _cosmetic;

    public void SetUp(CosmeticData cosmetic)
    {
        _cosmetic = cosmetic;
        _cosmeticImage.image.sprite = cosmetic.Sprite;
    }

    public CosmeticData Cosmetic
    {
        get { return _cosmetic; }
    }
}
