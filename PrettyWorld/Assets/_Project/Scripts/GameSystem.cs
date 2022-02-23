using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
   [SerializeField]
   private PlayerController _player;
   [SerializeField]
   private CosmeticStore _cosmeticStore;
   [SerializeField]
   private HUDController _hud;

   private void Start()
   {
      _player.Initialize();
      _cosmeticStore.Initialize();
      _cosmeticStore.UpdateMoneyReference(_player.Data.Money);
      _cosmeticStore.SetUpSoldCosmetics(_player.CurrentCosmetics);
      _cosmeticStore.OnBoughtItem = BuyItemHandler;
      
      _hud.Initialize();
      _hud.UpdateMoney(_player.Data.Money);
      _hud.OnClickToOpenStore = _cosmeticStore.Open;
   }

   private void BuyItemHandler(CosmeticData item)
   {
      _player.EquipBoughtItem(item);
      _hud.UpdateMoney(_player.Data.Money);
      _cosmeticStore.UpdateMoneyReference(_player.Data.Money);
   }
}
