
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_BasicPlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpForce;
    private Rigidbody playerRb;
    public bool isOnGround = true;
    private float horizontalInput; //x axis (upArrow goes +X, downArrow goes -X)
    private float forwardInput; //z axis (rightArrow goes -Z, leftArrow goes +Z)


    public static bool isStarted; //whether player entered the game page


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        isStarted = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(isStarted == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isStarted = true;
            }
        }
        else if(isStarted == true)
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
                Quaternion toRotation = Quaternion.LookRotation(-movementDirection, Vector3.up) ;

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
