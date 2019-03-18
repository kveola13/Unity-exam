using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainPlayerController : PlayerController
{
    private void Update()
    {
        keyController();
        gameOverChecker();
        if (Input.GetKey(KeyCode.Space))
        {
            player.transform.Translate(Vector3.up * Time.deltaTime * 100);
        }
    }
    private void FixedUpdate()
    {
        playerController();
    }
}
