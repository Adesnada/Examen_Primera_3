using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    float velocidad = 10f;

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("d"))
        {
            this.transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            this.transform.Translate(-velocidad * Time.deltaTime, 0, 0);
        }
    }
}
