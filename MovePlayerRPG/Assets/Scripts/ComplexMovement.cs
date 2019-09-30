using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ComplexMovement : NonPlayerCharacterController
{
    protected float dirX, dirY;
    protected Transform target;

    protected override void Move()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
            );
    }

    protected void UpdateDirection(Vector3 source, Vector3 target)
    {
        Vector2 diff = target - source;

        if (Mathf.Abs(diff.x) < Mathf.Abs(diff.y)) diff.x = 0f;
        else diff.y = 0f;

        if (diff.x < 0f) dirX = -1f;
        else if (diff.x > 0f) dirX = 1f;
        else dirX = 0f;

        if (diff.y < 0f) dirY = -1f;
        else if (diff.y > 0f) dirY = 1f;
        else dirY = 0f;
    }

    protected override void UpdateAnimation()
    {
        anim.SetFloat("DirX", dirX);
        anim.SetFloat("DirY", dirY);
    }
}
