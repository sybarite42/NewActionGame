using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

    public GameObject manager;

    void Start()
    {
        manager = GameObject.Find("Manager");
    }

    void FixedUpdate () {

        if (manager.GetComponent<TimeManager>().IsPaused() == false)
            rb.velocity = transform.right * speed;
        else
            rb.velocity = new Vector2(0,0);
	}
	
}
