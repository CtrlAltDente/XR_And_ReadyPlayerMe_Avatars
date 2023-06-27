using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AvatarsList", menuName = "Avatars/AvatarsList", order = 0)]
public class AvatarsSkinList : ScriptableObject
{
    public List<AvatarSkin> SkinList = new List<AvatarSkin>();
}
