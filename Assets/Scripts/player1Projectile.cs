using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1Projectile : MonoBehaviour
{
    public int projectileVelocity = 100;
    public Rigidbody projectile;
    public GameObject spawnPoint;
    public bool isVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            Rigidbody hitPlayer;
            hitPlayer = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            hitPlayer.velocity = transform.TransformDirection(Vector3.forward * projectileVelocity);
        }
        for(var i =0; i < Input.touchCount; ++i)
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(Vector3.forward * (projectileVelocity * 2));
            Debug.Log("collision");
        }
    }
}
