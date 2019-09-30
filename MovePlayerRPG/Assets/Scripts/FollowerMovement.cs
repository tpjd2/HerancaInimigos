using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMovement : ComplexMovement
{
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameController.instancia.getPlayer();        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        UpdateDirection(transform.position, target.position);
        UpdateAnimation();
    }
}
