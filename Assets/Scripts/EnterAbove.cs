using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterAbove : MonoBehaviour
{
    public bool powerUp = false;
    public Transform player;
    public Vector3 parDist;
    public ParticleSystem parSys;
    public Text screenText;

    void Start()
    {
        parSys.GetComponent<ParticleSystem>();
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            screenText.text = "Powered up!";
        }
        if (col.tag == "Player" && !powerUp)
        {
            ParticleSystem clone = Instantiate(parSys, player.transform.position, player.rotation) as ParticleSystem;
            clone.transform.parent = player;
            powerUp = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            screenText.text = "To exit, press Esc";
        }
    }
}
