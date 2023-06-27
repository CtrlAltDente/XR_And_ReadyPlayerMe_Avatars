using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarsLoader : MonoBehaviour
{
    [SerializeField] private Avatar _avatar = default;

    [SerializeField] private AvatarsSkinList _avatarsList = default;

    [SerializeField] private int _currentAvatarIndex = default;

    private void Start()
    {
        ChooseAvatar(_currentAvatarIndex);
    }

    public void ChooseNext(int value)
    {
        ChooseAvatar(CheckIndex(value));
    }

    private void ChooseAvatar(int avatarIndex)
    {
        _avatar.Model.sharedMesh = _avatarsList.SkinList[avatarIndex].SkinnedMeshRenderer.sharedMesh;
        _avatar.Model.material = _avatarsList.SkinList[avatarIndex].SkinnedMeshRenderer.sharedMaterial;
    }

    private int CheckIndex(int index)
    {
        _currentAvatarIndex += index;

        if (_currentAvatarIndex > _avatarsList.SkinList.Count - 1)
        {
            _currentAvatarIndex = 0;
        }
        else if (_currentAvatarIndex < 0)
        {
            _currentAvatarIndex = _avatarsList.SkinList.Count - 1;
        }

        return _currentAvatarIndex;
    }

}
