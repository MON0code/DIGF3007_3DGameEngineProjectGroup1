using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game_Manager : MonoBehaviour
{
    private static bool isStarted = false;

    //Accessible only trough editor or from this class
    [SerializeField]
    public bool gameStart = false;
    public GameObject start_screen;


    // Game Manager that record the stage of the game 
    // in case if player go back to the frist room

    private void Awake()
    {
        if (!isStarted)
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && start_screen)
        {
            gameStart = true;

        }



    }

}