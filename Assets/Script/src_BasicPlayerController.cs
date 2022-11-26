
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_BasicPlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput; //x axis (upArrow goes +X, downArrow goes -X)
    private float forwardInput; //z axis (rightArrow goes -Z, leftArrow goes +Z)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
       
    }
}
