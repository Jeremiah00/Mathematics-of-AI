using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform goal;
    public float speed = 0.1f;
    public float accuracy = 0.8f;

    void Start()
    {
        this.transform.LookAt(goal.position);

    }

    void LateUpdate()
    {
        Vector3 direction = goal.position - this.transform.position;
        if(direction.magnitude > accuracy)
        {
            this.transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
        
    }
}
