using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerimeterMovement : ComplexMovement
{
    [SerializeField] float operatingRange;
    GameObject[] checkPoints;
    int currentPoint;
    // Start is called before the first frame update
    void Start()
    {
        checkPoints = GameObject.FindGameObjectsWithTag("CheckPoint");
        anim = GetComponent<Animator>();
        currentPoint = 0;
        target = checkPoints[currentPoint].transform;
        UpdateDirection(transform.position, target.position);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        UpdateAnimation();
    }

    private void Move()
    {
        base.Move();

        if (Vector3.Distance(transform.position, checkPoints[currentPoint].transform.position) < operatingRange)
        {
            currentPoint = ++currentPoint % checkPoints.Length;
            target = checkPoints[currentPoint].transform;
            UpdateDirection(transform.position, target.position);
        }
    }
}
