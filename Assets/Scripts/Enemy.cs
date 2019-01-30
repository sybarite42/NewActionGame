using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    
    public GameObject manager;
    public GameObject target;
    public int moveSpeed = 6;

    void Start()
    {
        manager = GameObject.Find("Manager");
        target = GameObject.Find("Player");
    }

    void FixedUpdate(){

        if (!manager.GetComponent<TimeManager>().IsPaused())
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        }

    }
   
}
