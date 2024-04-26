using System;
using UnityEngine;
using UnityEngine.Audio;

public class CollisionPainter : MonoBehaviour{
    public Color paintColor;
    
    public float radius = 1;
    public float strength = 1;
    public float hardness = 1;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Paintable>())
        {
        audioSource.Play();
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.GetComponent<Paintable>())
        {
            audioSource.Pause();
        }

    }

    private void OnCollisionStay(Collision other) {
        Paintable p = other.collider.GetComponent<Paintable>();
        if(p != null){
            Vector3 pos = other.contacts[0].point;
            PaintManager.instance.paint(p, pos, radius, hardness, strength, paintColor);
        }
    }
}
