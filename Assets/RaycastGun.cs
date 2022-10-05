using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RaycastGun : MonoBehaviour
{
    public Transform laserOrigin;
    public float gunRange = 50f;
    public float laserDuration = 0.05f;

    LineRenderer laserLine;

    private void Awake()
    {
        laserLine = GetComponent<LineRenderer>();
    }

    public void Shoot()
    {
        laserLine.SetPosition(0, laserOrigin.position);
        Vector3 rayOrigin = laserOrigin.transform.position;
        RaycastHit hit;
        if (Physics.Raycast(rayOrigin, laserOrigin.transform.forward, out hit, gunRange))
        {
            laserLine.SetPosition(1, hit.point);
            hit.transform.gameObject.GetComponent<CharacterManager>().Hit(25);
        }
        else
        {
            laserLine.SetPosition(1, rayOrigin + (laserOrigin.transform.forward * gunRange));
        }

        
       StartCoroutine(GameManager.gameManager.ChangeActivePlayer());
    }
}
