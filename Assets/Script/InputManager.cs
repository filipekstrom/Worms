using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    float horizontal;
    float vertical;

    void Update()
    {
        vertical = (Input.GetAxisRaw("Vertical"));
        horizontal = (Input.GetAxisRaw("Horizontal"));

        if (Input.GetButton("Jump"))
        {

        }

        if (Input.GetButton("Fire1"))
        {

        }
    }

    private void FixedUpdate()
    {
        if (vertical != 0)
        {
            GameManager.activeCharacter.MoveForward(vertical);
        }

        if (horizontal != 0)
        {
            GameManager.activeCharacter.MoveToTheSide(horizontal);
        }
    }
}
