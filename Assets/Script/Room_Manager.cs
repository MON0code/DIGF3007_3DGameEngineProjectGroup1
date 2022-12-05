using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Manager : MonoBehaviour
{
    // define rooms
    public GameObject Bathroom;
    public GameObject Bedroom;
    public GameObject Stairs;

    // trigger boxes inside each room
    public GameObject inBathroom;
    public GameObject inBedroom;
    public GameObject inStairs;

    // trigger boxes between two rooms
    public GameObject BathroomDoor;
    public GameObject BedroomDoor;


    void OnTriggerEnter(Collider other){
        // based on what the chair is triggering,
        // show or hide certain rooms
        
        if (other.gameObject == inBathroom)
        {
            Bedroom.SetActive(false);
            Stairs.SetActive(false);
        }

        if (other.gameObject == BathroomDoor)
        {
            Bathroom.SetActive(true);
            Bedroom.SetActive(true);
        }

        if (other.gameObject == inBedroom)
        {
            Bathroom.SetActive(false);
            Stairs.SetActive(false);
        }

        if (other.gameObject == BedroomDoor)
        {
            Bedroom.SetActive(true);
            Stairs.SetActive(true);
        }

        if (other.gameObject == inStairs)
        {
            Bathroom.SetActive(false);
            Bedroom.SetActive(false);
        }
    }
}
