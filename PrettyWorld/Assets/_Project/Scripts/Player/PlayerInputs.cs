using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
   public Action<Vector2> OnPressToMoveSideways;
   public Action<Vector2> OnPressToMoveHeightways;
   
   private PlayerControls _controllers;
   private int _moveButtonsPressed = 0;

   public void Initialize()
   {
      if (_controllers != null)
      {
         _controllers.Disable();
      }
      _controllers = new PlayerControls();
      _controllers.Enable();
      _controllers.Standard.MoveSideWays.started += StartMoveHandler;
      _controllers.Standard.MoveHeightWays.started += StartMoveHandler;
      _controllers.Standard.MoveSideWays.canceled += StopMoveHandler;
      _controllers.Standard.MoveHeightWays.canceled += StopMoveHandler;

   }

   private void StartMoveHandler(InputAction.CallbackContext receiver)
   {
      _moveButtonsPressed++;
      StartCoroutine(ReadMovements());
   }

   private void StopMoveHandler(InputAction.CallbackContext receiver)
   {
      Debug.Log("Stopped");
      _moveButtonsPressed--;
   }

   private IEnumerator ReadMovements()
   {
      OnPressToMoveSideways?.Invoke(new Vector2{x = _controllers.Standard.MoveSideWays.ReadValue<float>(), y = _controllers.Standard.MoveHeightWays.ReadValue<float>()});
      yield return new WaitForFixedUpdate();
      if (_moveButtonsPressed > 0)
      {
         StartCoroutine(ReadMovements());
      }
      else
      {
        
      }
   }
}
