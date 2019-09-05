using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    
    private GameObject manager;
    private GameObject target;

    public int rotateSpeed = 6;
    public int moveSpeed = 6;
    

    void Start()
    {
        manager = GameObject.Find("Manager");
        target = GameObject.Find("Player");
    }

    void FixedUpdate(){

        if (!manager.GetComponent<TimeManager>().IsPaused())
        {

            Vector3 vectorToTarget = target.transform.position - transform.position;

            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;

            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);

            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotateSpeed);







        }
    }
}
