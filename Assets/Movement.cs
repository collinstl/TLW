using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private float curSpeed;
    
    void Start()
    {
        
    }
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Fast!");
            curSpeed = speed * 1.3f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Slow!");
            curSpeed = speed * 0.7f;
        }
        else
        {
            Debug.Log("Norm!");
            curSpeed = speed;
        }

        gameObject.transform.Translate(new Vector3(0, 0, curSpeed * Time.deltaTime));
    }

}
