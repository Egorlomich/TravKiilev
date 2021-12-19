using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour
{
    new AudioSource audio;
    public AudioClip finalboss;
    public Transform hero;

    void Start()
    {
        audio = GetComponent<AudioSource>();
      
    }

    void Update()
    {

            audio.PlayOneShot(finalboss);

    }
}