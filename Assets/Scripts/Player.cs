using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int moveSpeed = 5;

    public bool paused = true; 

	void FixedUpdate () {

        if (Input.GetAxis("Horizontal") < 0)
        {
            gameObject.transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
            paused = false;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            gameObject.transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
            paused = false;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            gameObject.transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
            paused = false;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            gameObject.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
            paused = false;
        }

        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
            paused = true;
    }
}
