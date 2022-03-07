using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    private float speed = 50;

    private float minZ = 3.5f;
    private Vector3 initPosition;
    private Vector3 limitPosition;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initPosition = rb.position;
        limitPosition = rb.position - Vector3.forward * minZ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightShift)) {
            Vector3 toPosition = rb.position - Vector3.forward * speed * Time.deltaTime;
            if(toPosition.z < limitPosition.z) {
                toPosition = limitPosition;
            }
            rb.MovePosition(toPosition);  
        } 
        if(Input.GetKeyUp(KeyCode.RightShift)) {
            rb.MovePosition(initPosition);
        }
    }

    void FixedUpdate() {

    }
}
