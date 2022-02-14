using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticStoreView : MonoBehaviour
{
    [SerializeField]
    private CosmeticUIBase _cosmeticPrefab;
    [SerializeField]
    private Transform _cosmeticsParent;
    
    private List<CosmeticUIBase> _spawnedCosmetics = new List<CosmeticUIBase>();
    
    public void FadeOut()
    {
        
    }

    public void SpawnCosmetics(List<CosmeticData> cosmeticDatas)
    {
        foreach (CosmeticData cosmeticData in cosmeticDatas)
        {
            _spawnedCosmetics.Add(Instantiate(_cosmeticPrefab, _cosmeticsParent));
        }
    }

    public void DespawnCosmetics()
    {
        foreach (CosmeticUIBase cosmetic in _spawnedCosmetics)
        {
            Destroy(cosmetic);
        }
        _spawnedCosmetics.Clear();
    }
}
