using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AvatarAnimationsController : MonoBehaviour
{
    [SerializeField] private Avatar _avatar = default;

    public void LeftTriggerButtonPressed(InputAction.CallbackContext callbackContext)
    {
        _avatar.LeftHand.SetAnimatorBools(callbackContext.ReadValueAsButton(), false, false);
        Debug.Log("Tigger pressed");
    }

    public void LeftPrimaryButtonPressed(InputAction.CallbackContext callbackContext)
    {
        _avatar.LeftHand.SetAnimatorBools(false, callbackContext.ReadValueAsButton(), false);
        Debug.Log("Primary button pressed");
    }

    public void LeftSecondaryButtonPressed(InputAction.CallbackContext callbackContext)
    {
        _avatar.LeftHand.SetAnimatorBools(false, false, callbackContext.ReadValueAsButton());
        Debug.Log("Secondary button pressed");
    }

    public void RightTriggerButtonPressed(InputAction.CallbackContext callbackContext)
    {
        _avatar.RightHand.SetAnimatorBools(callbackContext.ReadValueAsButton(), false, false);
        Debug.Log("Tigger pressed");
    }

    public void RightPrimaryButtonPressed(InputAction.CallbackContext callbackContext)
    {
        _avatar.RightHand.SetAnimatorBools(false, callbackContext.ReadValueAsButton(), false);
        Debug.Log("Primary button pressed");
    }

    public void RightSecondaryButtonPressed(InputAction.CallbackContext callbackContext)
    {
        _avatar.RightHand.SetAnimatorBools(false, false, callbackContext.ReadValueAsButton());
        Debug.Log("Secondary button pressed");
    }
}
