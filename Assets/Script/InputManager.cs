using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    float horizontal;
    float vertical;
    public float speed = 5f;

    void Update()
    {
        horizontal = (Input.GetAxisRaw("Horizontal"));
        vertical = (Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        if (horizontal != 0)
        {
            gameObject.transform.position += transform.forward * horizontal * Time.fixedDeltaTime * speed;
        }

        if (vertical != 0)
        {
            gameObject.transform.position += transform.right * vertical * Time.fixedDeltaTime * speed;
        }
    }
}
