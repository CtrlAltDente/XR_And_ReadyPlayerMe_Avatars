using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public SkinnedMeshRenderer Model = default;

    public AvatarPart Neck = default;
    public AvatarPart Head = default;
    public AvatarPart LeftHand = default;
    public AvatarPart RightHand = default;
}
