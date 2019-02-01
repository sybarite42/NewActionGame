using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject manager;
    public Transform firePoint;
    public GameObject bulletPrefab;

    private float coolDown;


    void Start()
    {
        manager = GameObject.Find("Manager");
    }

    void Update () {

        if(coolDown > 0)
            coolDown -= Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && coolDown <= 0)
        {
            coolDown = 0.3f;
            Shoot();
        }
	}

    void Shoot()
    {
        StartCoroutine(manager.GetComponent<TimeManager>().TimedUnpause(0.3f));
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}
