using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{

    // Accessible only through editor or from this class
    [SerializeField]
    public bool gameStart = false;
    public GameObject start_screen;

    // public GameObject currentRoom;


    // Game Manager that record the stage of the game 
    // in case if player go back to the first room

    private void Awake()
    {
        // DontDestroyOnLoad(this.gameObject);


    }
    
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && start_screen)
        {
            gameStart = true;

        }

    }

}