using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/**
 * This component moves its object one step up/down,
 * whenever the player clicks a key. 
 * The key is customizable via the editor.
 */
public class ClickMover : MonoBehaviour
{
    [Tooltip("Step size in meters")]
    [SerializeField] 
    float stepSize = 1f;

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveRight = new InputAction(type: InputActionType.Button);


    void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveLeft.Enable();
        moveRight.Enable();
    }

    void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
        moveLeft.Disable();
        moveRight.Disable();
    }

    void Update()
    {
        if (moveUp.IsPressed())
        {
            transform.position += new Vector3(0, stepSize * Time.time, 0);
        }
        else if (moveDown.IsPressed())
        {
            transform.position += new Vector3(0, -stepSize * Time.time, 0);
        }
        else if (moveLeft.IsPressed())
        {
            transform.position += new Vector3(-stepSize * Time.time, 0, 0);
        }
        else if (moveRight.IsPressed())
        {
            transform.position += new Vector3(stepSize * Time.time, 0, 0);
        }
    }
}