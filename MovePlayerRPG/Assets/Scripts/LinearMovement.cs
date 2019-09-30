using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : NonPlayerCharacterController
{
    [SerializeField] float distance;
    Vector3 posicaoInicial;
    Vector3 posicao;
    bool right;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        posicaoInicial = transform.position;
        right = true;
    }

    private void Update()
    {
        Move();
    }

    // Update is called once per frame
    protected override void Move()
    {
        posicao = posicaoInicial + Vector3.right * Mathf.Sin(Time.time * speed) * distance;
        if (right != transform.position.x < posicao.x)
        {
            right = !right;
            UpdateAnimation();
        }
        transform.position = posicao;
    }

    protected override void UpdateAnimation()
    {
        anim.SetBool("Right", right);
    }
}
