using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyableCosmeticUI : CosmeticUIBase
{
   public Action<BuyableCosmeticUI> OnClickToBuyItem;

   [SerializeField]
   private Button _buyButton;
   [SerializeField]
   private TextMeshProUGUI _priceText;

   private int _price;

   public override void SetUp(CosmeticData cosmetic)
   {
      base.SetUp(cosmetic);
      _price = cosmetic.Price;

      _priceText.text = _price.ToString();
      _buyButton.onClick.AddListener(BuyItemHandler);
   }

   public void EnableToBuy(bool enable)
   {
      _buyButton.interactable = enable;
   }

   private void BuyItemHandler()
   {
      OnClickToBuyItem?.Invoke(this);
   }
}
