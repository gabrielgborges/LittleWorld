using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
   [SerializeField]
   private PlayerController _player;

   private void Start()
   {
      _player.Initialize();
   }
}
