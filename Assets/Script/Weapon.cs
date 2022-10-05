using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private float damage;

    [SerializeField]
    private float fireDistance;

    [SerializeField]
    private Transform bulletPoint;

    private bool fireCooldown;

    private RaycastHit hit;

    public void Fire(string enemy)
    {
        if (fireCooldown) return;

        Ray ray = new Ray();
        ray.origin = bulletPoint.position;
        ray.direction = bulletPoint.TransformDirection(Vector3.forward);

        //Debug.DrawRay(ray.origin, ray.direction = fireDistance, Color.green);

        /*if (Physics.Raycast(ray, out hit, fireDistance))
        {
            if (hit.collider.CompareTag("enemyTag"))
            {
                var life = hit.collider.GetComponent<CharacterManager>();  
            }
        }*/
    }

}
