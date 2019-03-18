using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(0,100)]
    public int moveSpeed;
    [Range(0,300)]
    public int turnSpeed;
    public Rigidbody player;

    public void playerController()
    {
        float forwardsBackwards = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float leftRight = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;

        transform.Translate(0, 0, forwardsBackwards);
        transform.Rotate(0, leftRight, 0);
    }
    public void gameOverChecker()
    {
        if (player.position.y < -30f)
        {
            FindObjectOfType<LevelManager>().GameOver();
        }
    }
    public void keyController()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            FindObjectOfType<LevelManager>().RestartGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<LevelManager>().MainMenu();
        }
    }
}
