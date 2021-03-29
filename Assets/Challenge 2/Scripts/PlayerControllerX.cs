using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogCooldown = 2;
    private float dogTimer;

    // Update is called once per frame
    // void Update()
    // {
    //     // On spacebar press, send dog
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    //     }
    // }
    
    // WITH TIMER
    void Update()
    {
        dogTimer += Time.deltaTime; // track time 
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dogTimer > dogCooldown) // check to see if enough time as passed
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogTimer = 0; // reset timer
            }

        }
    }
}
