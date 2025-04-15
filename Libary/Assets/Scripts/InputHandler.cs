using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    FirstPersonCamera firstPersonCamera;
    CharacterMovement characterMovement;
    PlayerInteraction PlayerInteraction;
    void Start()
    {
        firstPersonCamera = GetComponent <FirstPersonCamera>();
        characterMovement = GetComponent<CharacterMovement>();
        PlayerInteraction = GetComponent<PlayerInteraction>();
    }

    void Update()
    {
        HandleCameraInput();
        HandleMoveInput();
        HandleInteractionInput();
    }
    void HandleCameraInput()
    {
        firstPersonCamera.AddAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCamera.AddYAxisInput(Input.GetAxis("Mouse X" +
            "") * Time.deltaTime);
    }

    void HandleMoveInput()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");

       characterMovement.AddMoveInput(forwardInput, rightInput);
    }

    void HandleInteractionInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerInteraction.TryInteract();
        }
    }

}
