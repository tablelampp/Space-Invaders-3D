using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPlayer : MonoBehaviour
{
    GameObject target;

    public GameObject bullet;
    public Transform shootPoint;

    public float shootSpeed = 10f;
    public float timeToShoot = 1.3f;
    float originalTime;


    void Start()
    {
        originalTime = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        timeToShoot -= Time.deltaTime;
        if(timeToShoot < 0)
        {
            ShootPlayer();
            timeToShoot = originalTime;

        }
    }
    private void ShootPlayer()
    {
        GameObject currentBullet = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        Rigidbody rig = currentBullet.GetComponent<Rigidbody>();

        rig.AddForce(transform.forward * shootSpeed, ForceMode.VelocityChange);
         
    }
}
