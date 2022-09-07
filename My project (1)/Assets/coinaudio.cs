using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinaudio : MonoBehaviour
{
    public AudioSource src;
    public AudioClip ballSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            src.clip = ballSound;
            src.Play();
        }
    }
}
