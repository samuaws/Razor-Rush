using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E)  || Input.GetMouseButtonDown(0))
        {
            GameManager.Instance.InvertBlades();
        }

    }
}
