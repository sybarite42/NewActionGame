using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject manager;
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Start()
    {
        manager = GameObject.Find("Manager");
    }

    void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        StartCoroutine(manager.GetComponent<TimeManager>().TimedUnpause(0.3f));
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}
