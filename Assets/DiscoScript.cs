using System;
using UnityEngine;

public class DiscoScript : MonoBehaviour
{
    private AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        source.Play();
        Debug.Log("Colisao!");
    }
}
