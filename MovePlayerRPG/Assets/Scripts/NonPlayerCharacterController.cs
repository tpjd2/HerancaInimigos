using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NonPlayerCharacterController : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Animator anim;
    // Start is called before the first frame update
    protected abstract void Move();
    protected abstract void UpdateAnimation();
}
