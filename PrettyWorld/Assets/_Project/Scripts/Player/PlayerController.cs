using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField]
   private PlayerData _configuration;
   [SerializeField]
   private PlayerInputs _playerInputs;
   [SerializeField]
   private PlayerView _playerView;
   
   public void Initialize()
   {
      _playerInputs.Initialize();
      _playerInputs.OnPressToMoveSideways = Move;
   }

   private void Move(Vector2 axis)
   {
      transform.position += new Vector3{ x = axis.x * _configuration.HorizontalSpeed, y = axis.y * _configuration.VerticalSpeed, z = 0} * Time.deltaTime;
   }
}
