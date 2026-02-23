using System;
using UnityEngine;

public class MarcarPonto : MonoBehaviour
{
    public Transform disco;  
    public Rigidbody2D discoRb;  
  
    public Transform discoEsquerda;  
    public Transform discoDireita;  
  
    Vector3 posInicialDisco;  
    Vector3 posInicialEsquerda;  
    Vector3 posInicialDireita;  
  
    void Awake()  
    {  
        if (disco) posInicialDisco = disco.position;  
        if (discoEsquerda) posInicialEsquerda = discoEsquerda.position;  
        if (discoDireita) posInicialDireita = discoDireita.position;  
    }  
  
    private void OnTriggerEnter2D(Collider2D other)  
    {  
        if (other.transform != disco) return;  
  
        ResetPositions();  
    }  
  
    void ResetPositions()  
    {  
        if (discoRb) discoRb.linearVelocity = Vector2.zero;  
  
        if (disco) disco.position = posInicialDisco;  
        if (discoEsquerda) discoEsquerda.position = posInicialEsquerda;  
        if (discoDireita) discoDireita.position = posInicialDireita;  
    }
}
