using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_RoomChangeTrigger : MonoBehaviour
{

    public string room;

    void Start(){

        Scene scene = SceneManager.GetActiveScene();
        room = scene.name;
    }

    void OnTriggerEnter(Collider other){

        if (room == "Bathroom"){
            SceneManager.LoadScene(1);

        } else if (room == "Bedroom"){
            SceneManager.LoadScene(0);

        }
    }
}
