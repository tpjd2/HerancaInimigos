using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 target;
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime
            );
    }

    public void setTarget(Vector3 target)
    {
        this.target = (target - transform.position) * 100f;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
