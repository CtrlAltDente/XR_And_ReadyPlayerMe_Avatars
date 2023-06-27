using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AvatarPartsPositionUpdater : MonoBehaviour
{
    [SerializeField] private Avatar _avatar = default;

    [SerializeField] private Transform _avatarNeckPosition = default;
    [SerializeField] private Transform _avatarHeadPosition = default;
    [SerializeField] private Transform _avatarLeftHandPosition = default;
    [SerializeField] private Transform _avatarRightHandPosition = default;

    public void Update()
    {
        UpdateAvatar();
    }

    private void UpdateAvatar()
    {
        UpdatePositions();
    }

    private void UpdatePositions()
    {
        if (_avatar == null)
        {
            return;
        }

        UpdatePositionForPart(_avatar.Neck, _avatarNeckPosition);
        UpdatePositionForPart(_avatar.Head, _avatarHeadPosition);
        UpdatePositionForPart(_avatar.LeftHand, _avatarLeftHandPosition);
        UpdatePositionForPart(_avatar.RightHand, _avatarRightHandPosition);
    }

    private void UpdatePositionForPart(AvatarPart avatarPart, Transform avatarPartParent)
    {
        if (avatarPart == null)
        {
            return;
        }

        avatarPart.CoreBone.position = avatarPartParent.position + avatarPart.PositionOffset;
        avatarPart.CoreBone.rotation = avatarPartParent.rotation * Quaternion.Euler(avatarPart.RotationOffset);
    }
}
