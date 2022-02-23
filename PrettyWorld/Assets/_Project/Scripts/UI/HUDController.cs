using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Action OnClickToOpenStore;
    
    [SerializeField]
    private Button _openStore;
    [SerializeField]
    private TextMeshProUGUI _actualMoney;

    public void Initialize()
    {
        _openStore.onClick.AddListener(OpenStoreHandler);
    }

    public void UpdateMoney(int actualMoney)
    {
        _actualMoney.text = actualMoney.ToString();
    }
    
    private void OpenStoreHandler()
    {
        OnClickToOpenStore?.Invoke();
    }
}
