using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeometryPlayerController : PlayerController
{
    private void Start()
    {
        FindObjectOfType<EnterAbove>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            FindObjectOfType<EnterBelow>().SpawnGeometricShapes();
        }

        if (FindObjectOfType<EnterAbove>().powerUp == true)
        {
            moveSpeed = 100;
            turnSpeed = 300;
        }
        keyController();
    }
    private void FixedUpdate()
    {
        playerController();
        gameOverChecker();
    }
}
