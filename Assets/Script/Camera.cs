using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Vector3 distanceFromThePlayer;
    [SerializeField] private float speed;

    private void Update()
    {
        Vector3 targetPosition = gameManager.GetActivePlayer().transform.position + distanceFromThePlayer;

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }
}
