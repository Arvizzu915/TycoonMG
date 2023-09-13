using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float walkSpeed, runSpeed;
    [SerializeField] bool canMove = true;

    private Vector3 vectorMovement;
    private float speed;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        speed = walkSpeed;
        vectorMovement = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            Walk();
            Run();
        }

        Gravity();
    }

    void Walk()
    {
        vectorMovement.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        vectorMovement.z = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        characterController.Move(vectorMovement * speed);
    }

    void Run()
    {
        if (Input.GetAxis("Run") > 0f)
        {
            speed = runSpeed;
        }
        else speed = walkSpeed;
    }

    void Gravity()
    {
        characterController.Move(new Vector3(0, -4f * Time.deltaTime, 0));
    }
}
