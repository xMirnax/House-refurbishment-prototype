using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThrowingTrash : MonoBehaviour
{
    public string targetTag;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            Destroy(other.gameObject);
        }
    }
}
