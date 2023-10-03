using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatdroppertext : MonoBehaviour
{
    [SerializeField] GameObject player;
    void Update()
    {
        transform.LookAt(player.transform.position);
    }
}
