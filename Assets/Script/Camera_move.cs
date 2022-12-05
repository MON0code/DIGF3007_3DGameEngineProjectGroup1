using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    public Transform cameraaa;
    public Transform chair;

    void Update()
    {   

        // calculate the camera position based on the chair position
        // values are designed to be a comfortable angle

        float camera_x = chair.transform.position.x + 5.5f;
        float camera_y = chair.transform.position.y + 8.5f;
        float camera_z = chair.transform.position.z + -2.5f;

        // transform the camera into the new position

        cameraaa.transform.position = new Vector3(camera_x, camera_y, camera_z);

    }


}
