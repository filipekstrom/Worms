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
            GameManager.gameManager.activeCharacter.Jump();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameManager.gameManager.activeCharacter.gameObject.GetComponent<RaycastGun>().Shoot();
        }

        
    }

    private void FixedUpdate()
    {
        if (vertical != 0)
        {
            GameManager.gameManager.activeCharacter.MoveForward(vertical);
        }

        if (horizontal != 0)
        {
            GameManager.gameManager.activeCharacter.MoveToTheSide(horizontal);
        }
    }
}
