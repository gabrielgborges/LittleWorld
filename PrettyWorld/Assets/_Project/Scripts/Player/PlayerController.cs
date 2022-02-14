using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField]
   private CosmeticData _test;
   [SerializeField]
   private PlayerData _configuration;
   [SerializeField]
   private PlayerInputs _playerInputs;
   [SerializeField]
   private PlayerView _playerView;

   private Vector2 _lastDirection = Vector2.zero;
   
   public void Initialize()
   {
      _playerInputs.Initialize();
      _playerInputs.OnPressToMoveSideways = Move;
      _playerInputs.OnStopToMove = IdleHandler;
   }

   private void Move(Vector2 axis)
   {
      transform.position += new Vector3{ x = axis.x * _configuration.HorizontalSpeed, y = axis.y * _configuration.VerticalSpeed, z = 0} * Time.deltaTime;
      PlayWalkAnimation(axis);
      _lastDirection = axis;
   }

   private void PlayWalkAnimation(Vector2 direction)
   {
      if (_lastDirection == direction)
      {
         return;
      }
      if (direction.y > 0)
      {
         _playerView.WalkForward();
      }
      else if (direction.y < 0)
      {
       _playerView.WalkBackward();  
      }
      else if (direction.x > 0)
      {
         _playerView.WalkSideways(false);
      }
      else if (direction.x < 0)
      {
         _playerView.WalkSideways(true);
      }
   }

   private void IdleHandler()
   {
      _lastDirection = Vector2.zero;
      _playerView.PlayIdle();
   }
}
