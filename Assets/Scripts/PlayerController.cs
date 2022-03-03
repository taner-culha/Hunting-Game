using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalI;
    public float speed = 10f;
    public float xRange = 10;
    public GameObject carrotprefab;
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalI = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalI * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(carrotprefab, transform.position, carrotprefab.transform.rotation);
        }
    }
}