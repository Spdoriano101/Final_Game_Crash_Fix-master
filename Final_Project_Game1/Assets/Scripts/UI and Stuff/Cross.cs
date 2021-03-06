﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour {

    //Setting "AuidoSource" to "Coin_Pickup"
    public AudioSource Coin_Pickup;

    public Score scoreObject;

    public int crossValue;

    // Use this for initialization
    void Start()
    {

        //Asking the program to then retrive the audio source file and apply it to Coin_Pickup
        Coin_Pickup = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    //Unity calls this function when coin touches any other object in the game
    // If the player touched the coin, it should vanish and the score should increase
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check if the thing we touched was the player 
        Player playerScript = collision.collider.GetComponent<Player>();
        //Player2 playerScript2 = collision.collider.GetComponent<Player2>();

        //If the player collides with an object or asset(s) that 
        //Have a playerscript attached to it
        if (playerScript)
        {

            Coin_Pickup.Play();


            Score.scoreValue += 50;
            // Destroy the gameObject that this script is attracted to
            // (the coin) 



            Destroy(gameObject);
        }
    }
}
