using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticStore : ScreenBase
{
    [SerializeField]
    private List<CosmeticData> _cosmeticsToSell;
    [SerializeField]
    private CosmeticStoreView _view;

    private List<CosmeticData> _soldCosmetics;

    public void SetUpSoldCosmetics(List<CosmeticData> soldCosmetics)
    {
        _soldCosmetics = soldCosmetics;
    }

    public override void Open()
    {
        _view.SpawnCosmetics(_cosmeticsToSell);
        gameObject.SetActive(true);
    }

    public override void Close()
    {
        gameObject.SetActive(false);
    }
}
