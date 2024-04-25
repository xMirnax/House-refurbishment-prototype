using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThrowingTrash : MonoBehaviour
{
    public string targetTag;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            audioSource.Play();
            Destroy(other.gameObject);
        }
    }
}
