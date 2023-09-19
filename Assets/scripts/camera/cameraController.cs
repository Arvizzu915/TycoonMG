using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField] float sensibility;
    [SerializeField] Transform cameraJointY, targetObject;

    public bool canRotate;

    private float xRotation = 0, yRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        canRotate = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(canRotate)
        {
            Rotate();
        }

        FollowTarget();
    }

    void Rotate()
    {
        xRotation += Input.GetAxis("Mouse X") * Time.deltaTime * sensibility;
        yRotation += Input.GetAxis("Mouse Y") * Time.deltaTime * sensibility;

        yRotation = Mathf.Clamp(yRotation, -65, 65);

        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);
        cameraJointY.transform.localRotation = Quaternion.Euler(-yRotation, 0f, 0f);

    }

    void FollowTarget()
    {
        transform.position = targetObject.position;
    }
}
