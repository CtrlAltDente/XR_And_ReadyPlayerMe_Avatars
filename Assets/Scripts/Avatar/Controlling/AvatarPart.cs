using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarPart : MonoBehaviour
{
    public Transform CoreBone = default;

    public Vector3 PositionOffset = new Vector3(0, 0, 0);
    public Vector3 RotationOffset = new Vector3(0, 0, 0);

    public Animator Animator = default;

    public void SetAnimatorBools(bool trigger, bool primary, bool secondary)
    {
        if (Animator != null)
        {
            Animator.SetBool("trigger", trigger);
            Animator.SetBool("primary", primary);
            Animator.SetBool("secondary", secondary);
        }
    }
}
