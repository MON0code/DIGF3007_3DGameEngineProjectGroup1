using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Screen_Script : MonoBehaviour
{
    public GameObject start_screen;

    private Game_Manager _manager;
    private bool isStarted;


    private void Awake()
    {
        _manager = GameObject.FindObjectOfType<Game_Manager>();
        isStarted = _manager.gameStart;
    }


    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && start_screen)
        {
            Destroy(start_screen);

        }

        if(isStarted == true && start_screen)
        {
            Destroy(start_screen);
        }


        
    }





}
