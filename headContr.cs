using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class headContr : MonoBehaviour
{
    public Transform playerBody;
    public CharacterController contr;
    float speed=12f;
    
    float xRotation=0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        playerBody.Rotate(0, mouseX, 0);

        xRotation=xRotation-mouseY;

        xRotation = Math.Clamp(xRotation, -90f, 90f);

        transform.localRotation=Quaternion.Euler(xRotation,0,0);//извлекли градусы и передали localRotation
        float vertical=Input.GetAxis("Vertical");
        float horizontal=Input.GetAxis("Horizontal");
        contr.Move(transform.forward*speed*vertical*Time.deltaTime);
        contr.Move(transform.right*speed*horizontal*Time.deltaTime);
    }
}
