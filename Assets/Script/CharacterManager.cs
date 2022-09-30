using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private float life;
    [SerializeField]
    private int speed;

    private Rigidbody rb;

    [SerializeField]
    private int jumpForce;

    private void Start()
    {
        life = 100;
        rb = GetComponent<Rigidbody>();
    }

    public void MoveForward(float vertical)
    {
        //Change 5 into speed
      gameObject.transform.position += transform.forward * vertical * Time.fixedDeltaTime * 5;
    }

    public void MoveToTheSide(float horizontal)
    {
        //Change 5 into speed
        gameObject.transform.position += transform.right * horizontal * Time.fixedDeltaTime * 5;
        //Vector3(0,0,1) * horizontal * Time.fixedDeltaTime * 5;
    }

    public void Jump(){
        //Google is grounded
        //Apply jump force multiplier
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void Hit(float damage)
    {
        life -= damage;
        if (life <= 0)
        {
            //DIE
        }
    }
}
