using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    [SerializeField] GameObject[] objectToDrop;
    [SerializeField] Transform spawn;

    public int tier = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropObject", 0.0f, 1.5f);
    }

    void DropObject()
    {
        Instantiate(objectToDrop[tier], spawn.position, Quaternion.identity);
    }
}
