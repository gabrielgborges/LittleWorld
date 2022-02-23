using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class CosmeticStoreView : MonoBehaviour
{
    public Action<CosmeticData> OnBoughtItem;
    public Action OnClickToClose;
    
    [SerializeField]
    private BuyableCosmeticUI _cosmeticPrefab;
    [SerializeField]
    private Transform _cosmeticsParent;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private Button _close;

    private int _moneyReference = 0;

    private List<BuyableCosmeticUI> _spawnedCosmetics = new List<BuyableCosmeticUI>();

    public void Initialize()
    {
        _close.onClick.AddListener(CloseButtonHandler)  ;
        _close.gameObject.SetActive(false);
    }

    public void UpdateMoneyReference(int playerMoney)
    {
        _moneyReference = playerMoney;
        
        foreach (BuyableCosmeticUI cosmetic in _spawnedCosmetics)
        {
            if (_moneyReference < cosmetic.Cosmetic.Price)
            {
                cosmetic.EnableToBuy(false);   
            }
        }
    }
    
    public void FadeOut()
    {
        _animator.Play("FadeOut");
        _close.gameObject.SetActive(false);
    }

    public void SpawnCosmeticsAndFadeIn(List<CosmeticData> cosmeticDatas, List<CosmeticData> soldCosmetics)
    {
        foreach (CosmeticData cosmeticData in cosmeticDatas)
        {
            BuyableCosmeticUI cosmeticSpawned = Instantiate(_cosmeticPrefab, _cosmeticsParent);
            cosmeticSpawned.SetUp(cosmeticData);
            cosmeticSpawned.OnClickToBuyItem = BoughtItemHandler;
            cosmeticSpawned.EnableToBuy(!soldCosmetics.Contains(cosmeticData) && _moneyReference >= cosmeticData.Price);
            _spawnedCosmetics.Add(cosmeticSpawned);
        }
        
        _close.gameObject.SetActive(true);
        _animator.Play("FadeIn");
        Debug.Log("Faded in");
    }

    public void DespawnCosmetics()
    {
        foreach (CosmeticUIBase cosmetic in _spawnedCosmetics)
        {
            Destroy(cosmetic.gameObject);
        }
        _spawnedCosmetics.Clear();
    }

    private void BoughtItemHandler(BuyableCosmeticUI item)
    {
        OnBoughtItem?.Invoke(item.Cosmetic);
        item.EnableToBuy(false);
    }

    private void CloseButtonHandler()
    {
        OnClickToClose?.Invoke();
    }
}
