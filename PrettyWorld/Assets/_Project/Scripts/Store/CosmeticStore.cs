using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticStore : ScreenBase
{
    public Action<CosmeticData> OnBoughtItem;
    
    [SerializeField]
    private List<CosmeticData> _cosmeticsToSell;
    [SerializeField]
    private CosmeticStoreView _view;

    private List<CosmeticData> _soldCosmetics;

    public override void Open()
    {
        gameObject.SetActive(true);
        _view.SpawnCosmeticsAndFadeIn(_cosmeticsToSell, _soldCosmetics);
    }

    public override void Close()
    {
        _view.FadeOut();
        gameObject.SetActive(false);
        _view.DespawnCosmetics();
    }
    
    public void Initialize()
    {
        _view.Initialize();
        _view.OnClickToClose = Close;
        _view.OnBoughtItem = BoughtItemHandler;
    }
    
    public void SetUpSoldCosmetics(List<CosmeticData> soldCosmetics)
    {
        _soldCosmetics = soldCosmetics;
    }

    public void UpdateMoneyReference(int money)
    {
        _view.UpdateMoneyReference(money);
    }
    
    private void BoughtItemHandler(CosmeticData item)
    {
        OnBoughtItem?.Invoke(item);
        _soldCosmetics.Add(item);
    }
}
