using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NonPlayerCharacterController : MonoBehaviour
{
    [SerializeField] protected GameObject firePrefab;
    [SerializeField] protected float speed;
    protected Animator anim;
    // Start is called before the first frame update
    protected abstract void Move();
    protected abstract void UpdateAnimation();
    protected void Fire()
    {
        GameObject fire = (GameObject)Instantiate(
            firePrefab,
            transform.position, 
            Quaternion.identity
            );
        fire.GetComponent<FireController>()
            .Target = GameController.instancia.getPlayer().position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Fire();
        }
    }
}
