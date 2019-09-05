using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	
	public Transform firePoint;
	public GameObject bulletPrefab;
	public GameObject player;

	private GameObject manager;
	
	private float coolDown;
	private int moveSpeed = 4;


	void Start()
	{
		manager = GameObject.Find("Manager");
	}

	void FixedUpdate () {

        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float radius = 1.5f;

        Vector3 centerPosition = player.transform.position;
        Vector3 currentPosition = transform.position;

        float distance = Vector3.Distance(currentPosition, centerPosition);
        
        if (distance > radius)
        {
            Vector3 v = currentPosition - centerPosition;
            v = Vector3.ClampMagnitude(v, radius);
            currentPosition = centerPosition + v;
            transform.position = currentPosition;
        }
        else
        {
            
            targetPos.z = transform.position.z;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }
        




		if (coolDown > 0)
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
