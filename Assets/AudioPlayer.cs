using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    public AudioClip[] audios;

    private AudioSource player;

    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.A))
        {

            player.clip = audios[0];
            player.Play();
        }

        if (Input.GetKeyUp(KeyCode.S))
        {

            player.clip = audios[1];
            player.Play();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {

            player.clip = audios[2];
            player.Play();
        }
    }
}
