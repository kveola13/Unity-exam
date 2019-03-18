using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterBelow : MonoBehaviour
{
    public bool spawnedGeo = false;
    public Transform spawnGeo;
    public Transform playerPos;
    public Text screenText;

    public void SpawnGeometricShapes()
    {
        Instantiate(spawnGeo, spawnGeo.position, spawnGeo.rotation);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && !spawnedGeo)
        {
            SpawnGeometricShapes();
            spawnedGeo = true;
        }
        if (col.tag == "Player")
        {
            screenText.text = "Press Q for objects!";
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
