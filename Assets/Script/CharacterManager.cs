using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private float life;
    [SerializeField]
    private int speed;

    private void Start()
    {
        life = 100;
    }

    public void MoveForward(float vertical)
    {
      gameObject.transform.position += transform.forward * vertical * Time.fixedDeltaTime * 5;
    }

    public void MoveToTheSide(float horizontal)
    {
       gameObject.transform.position += transform.right * horizontal * Time.fixedDeltaTime * 5;
    }
}
