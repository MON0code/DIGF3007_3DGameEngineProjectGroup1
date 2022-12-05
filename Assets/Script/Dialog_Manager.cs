using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog_Manager : MonoBehaviour
{

    // define gameobjects to manipulate

    public GameObject Chair;
    public Transform chair;

    public GameObject begin_bubble; // begin dialog bubble

    public GameObject All_bubbles; // all the other bubble

    public GameObject Toilet;         // colliding objects
    public GameObject Toilet_bubble;  // bubble show up for that specific object

    public GameObject Basin;
    public GameObject Basin_bubble;

    public GameObject Bed;
    public GameObject Bed_bubble;

    public GameObject Shelf;
    public GameObject Shelf_bubble;

    public GameObject OfficeChair;
    public GameObject OfficeChair_bubble;

    public GameObject Plant1;
    public GameObject Plant1_bubble;

    public GameObject Plant2;
    public GameObject Plant2_bubble;

    public GameObject Sofa;
    public GameObject Sofa_bubble;

    public GameObject Stair;
    public GameObject Stair_bubble;

    public GameObject Window;
    public GameObject Window_bubble;

    private Game_Manager _manager;
    private bool GameStarted;

    private void Awake()
    {
        _manager = GameObject.FindObjectOfType<Game_Manager>();
        GameStarted = _manager.gameStart;

    }

    private void Update()
    {
        if(GameStarted == true)
        {
            begin_bubble.SetActive(false);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        All_bubbles.SetActive(true);

        if (collision.gameObject == Toilet)
        {
            begin_bubble.SetActive(false);

            Toilet_bubble.SetActive(true);
        }else if(collision.gameObject == Basin)
        {
            begin_bubble.SetActive(false);
            Toilet_bubble.SetActive(false);

            Basin_bubble.SetActive(true);
        }
        else if (collision.gameObject == Bed)
        {
            begin_bubble.SetActive(false);

            Bed_bubble.SetActive(true);
        }
        else if (collision.gameObject == OfficeChair)
        {
            begin_bubble.SetActive(false);
            Bed_bubble.SetActive(false);

            OfficeChair_bubble.SetActive(true);
        }
        else if (collision.gameObject == Shelf)
        {
            begin_bubble.SetActive(false);
            Bed_bubble.SetActive(false);

            Shelf_bubble.SetActive(true);
        }
        else if (collision.gameObject == Plant1)
        {
            begin_bubble.SetActive(false);
            OfficeChair_bubble.SetActive(false);

            Plant1_bubble.SetActive(true);
        }
        else if (collision.gameObject == Plant2)
        {
            begin_bubble.SetActive(false);
            Sofa_bubble.SetActive(false);

            Plant2_bubble.SetActive(true);
        }
        else if (collision.gameObject == Sofa)
        {
            begin_bubble.SetActive(false);
            Plant2_bubble.SetActive(false);

            Sofa_bubble.SetActive(true);
        }
        else if (collision.gameObject == Window)
        {
            begin_bubble.SetActive(false);

            Window_bubble.SetActive(true);
        }

        else if (collision.gameObject == Stair)
        {
            begin_bubble.SetActive(false);

            Window_bubble.SetActive(false);
            Plant2_bubble.SetActive(false);
            Sofa_bubble.SetActive(false);

            Stair_bubble.SetActive(true);
        }


    }

    // if not colliding, turn off all the bubbles 

    void OnCollisionExit(Collision collision)
    {
        setAllFalse();


    }

    void setAllFalse()
    {
        All_bubbles.SetActive(false);

        for (int i = 0; i < All_bubbles.transform.childCount; i++)
        {
            var child = All_bubbles.transform.GetChild(i).gameObject;
            child.SetActive(false);
        }
    }




}
