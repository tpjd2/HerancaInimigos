using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 _target;
    public Vector3 Target
    {
        set { _target = (value - transform.position) * 100f; }
        get
        {
            return _target;
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            Target,
            speed * Time.deltaTime
            );
    }
    
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    /*
    public void setTarget(Vector3 target)
    {
        this.target = (target - transform.position) * 100f;
    }
    */
}
