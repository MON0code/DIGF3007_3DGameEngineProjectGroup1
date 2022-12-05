using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Screen_Script : MonoBehaviour
{
    public GameObject start_screen;
    


    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && start_screen)
        {
            Destroy(start_screen);
        }
        
    }





}
