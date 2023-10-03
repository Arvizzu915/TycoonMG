using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    [SerializeField] GameObject currency;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "magic")
        {
            currency.GetComponent<currency>().magic += collision.gameObject.GetComponent<magic>().value;
            Destroy(collision.gameObject);
        }
    }

}
