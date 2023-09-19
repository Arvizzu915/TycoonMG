using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float walkSpeed, runSpeed, rotationSpeed;
    [SerializeField] bool canMove = true;
    [SerializeField] Transform cameraAim;

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
            AllignPlayer();
        }

        Gravity();
        
    }

    void Walk()
    {
        vectorMovement.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        vectorMovement.z = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        vectorMovement = cameraAim.TransformDirection(vectorMovement);

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

    void AllignPlayer()
    {
        if(characterController.velocity.magnitude > 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(vectorMovement), rotationSpeed * Time.deltaTime);
        }
    }
}
