using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRespawnAudio : MonoBehaviour
{
    public AudioSource audioSource;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.Play();
        
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}