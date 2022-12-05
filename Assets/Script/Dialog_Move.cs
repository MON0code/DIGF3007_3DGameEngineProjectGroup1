using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Move : MonoBehaviour
{

    public Transform dialog;
    public Transform chair;

    void Update()
    {
        //Make dialog position to match with the chair
        dialog.position = chair.position;

    }




}
