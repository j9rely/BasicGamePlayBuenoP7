using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;

    public float zMin;
    public float zMax;
    public float verticalInput;
    public Transform projectileSpawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, projectileSpawnPoint.position,
                projectilePrefab.transform.rotation);
        }
        // Keep the player in bounds
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y, zMin);
        }

        if(transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y, zMax);
        }
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        }
    }
