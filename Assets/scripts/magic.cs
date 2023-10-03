using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic : MonoBehaviour
{
    [SerializeField] float speedConveyor;
    [SerializeField] public int value = 0;
    private float speedConveyorFake = 0;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.velocity = new Vector3(speedConveyorFake * Time.deltaTime, rb.velocity.y, 0f);
    }

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "conveyor")
        {
            speedConveyorFake = speedConveyor;
        }
    }

    private void OnCollisionExit(Collision collision)
    {   
        if (collision.gameObject.tag == "conveyor")
        {
            speedConveyorFake = 0;
        }
    }
}
