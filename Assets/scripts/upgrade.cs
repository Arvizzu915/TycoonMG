using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgrade : MonoBehaviour
{
    [SerializeField] GameObject dropper;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            dropper.GetComponent<dropper>().tier += 1;
        }
    }
}
