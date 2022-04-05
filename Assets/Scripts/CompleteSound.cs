using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteSound : MonoBehaviour
{
    private AudioSource CompletionSound;

    private void Start()
    {
        CompletionSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            CompletionSound.Play();
        }
    }
       
    
}
