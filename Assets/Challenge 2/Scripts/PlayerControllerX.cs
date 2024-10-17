using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeDelay = 1.0f;
    private float timePlay = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timePlay += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timePlay >= timeDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            timePlay = 0.0f;
        }
    }
}
