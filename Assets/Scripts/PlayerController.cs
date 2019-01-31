using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public GameObject manager;
    public int moveSpeed = 5;


    void Start()
    {
        manager = GameObject.Find("Manager");
    }


    void Update () {

        if (Input.GetAxis("Horizontal") < 0)
        {
            gameObject.transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
            manager.GetComponent<TimeManager>().Unpause();
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            gameObject.transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
            manager.GetComponent<TimeManager>().Unpause();
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            gameObject.transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
            manager.GetComponent<TimeManager>().Unpause();
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            gameObject.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
            manager.GetComponent<TimeManager>().Unpause();
        }

        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
            manager.GetComponent<TimeManager>().Pause();
    }
}
