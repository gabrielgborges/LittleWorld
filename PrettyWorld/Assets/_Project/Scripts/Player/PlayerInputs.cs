using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
   public Action<Vector2> OnPressToMoveSideways;
   public Action OnStopToMove;
   
   private PlayerControls _controllers;
   private int _moveButtonsPressed = 0;
   private bool _isReadingInputs = false;

   public void Initialize()
   {
      if (_controllers != null)
      {
         _controllers.Disable();
      }
      _controllers = new PlayerControls();
      _controllers.Enable();
      _controllers.Standard.MoveSideWays.performed += StartMoveHandler;
      _controllers.Standard.MoveHeightWays.performed += StartMoveHandler;
      _controllers.Standard.MoveSideWays.canceled += StopMoveHandler;
      _controllers.Standard.MoveHeightWays.canceled += StopMoveHandler;

   }

   private void StartMoveHandler(InputAction.CallbackContext receiver)
   {
      _moveButtonsPressed++;
      if (!_isReadingInputs)
      {
         Debug.Log("Startei");
         _isReadingInputs = true;
         StartCoroutine(ReadMovements());
      }
   }

   private void StopMoveHandler(InputAction.CallbackContext receiver)
   {
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
         _isReadingInputs = false;
         OnStopToMove?.Invoke();
      }
   }
}
