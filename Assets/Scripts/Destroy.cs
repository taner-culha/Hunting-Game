using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private float topBound = 30;
    [SerializeField] private float lowerBound = -10;
    void Update()
    {
        if (transform.position.z>topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over Bro!!");
            Destroy(gameObject);
        }
    }
}