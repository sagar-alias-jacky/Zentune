using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantVelocity : MonoBehaviour
{

    [SerializeField] private float constantVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vector = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        vector.x += constantVelocity * Time.deltaTime;
        transform.position = vector;
    }
}
