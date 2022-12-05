
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class src_BasicPlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpForce;
    private Rigidbody playerRb;
    public bool isOnGround = true;
    private float horizontalInput; //x axis (upArrow goes +X, downArrow goes -X)
    private float forwardInput; //z axis (rightArrow goes -Z, leftArrow goes +Z)

    public GameObject Chair;

    public static bool isStarted; //whether player entered the game page
    private Game_Manager _manager;
    private bool GameStarted;

    private void Awake()
    {
        _manager = GameObject.FindObjectOfType<Game_Manager>();
        GameStarted = _manager.gameStart;

        // get the current scene name
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;

        // if game started, but this scene reload, which means the player goes back to Bathroom
        // the player will move to the door position
        if (GameStarted == true && currentSceneName == "Bathroom")
        {
            Chair.transform.position = new Vector3(1.75f, 0.17f, 1.66f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        isStarted = false;   // set game start as false
    }

    // Update is called once per frame
    void Update()
    {
        if(GameStarted == true) // variable that don't destroy on load
        {                       
            isStarted = true;
        }

        // if the game is not started yet
        if(isStarted == false)  
        {
            // get the current scene name
            var currentScene = SceneManager.GetActiveScene();
            var currentSceneName = currentScene.name;
                
            // if SPACE is pressed, OR, the active current scene isn't bathroom
            if (Input.GetKeyDown(KeyCode.Space) || currentScene.name != "Bathroom")
            {
                isStarted = true;   // the game state is started
            }
        }
        else if(isStarted == true)   // else if game started, run normally
        {
            //get player Input
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            Vector3 movementDirection = new Vector3(horizontalInput, 0, forwardInput);
            movementDirection.Normalize();

            transform.Translate(movementDirection * speed *Time.deltaTime, Space.World);
            //rotates player in the forward direction
            if(movementDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up) ;

                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }
            // makes player jump, and checks if player is on ground
            if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
            {
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnGround = false;
            }

        }




    }

    //makes sure player is back on ground
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
