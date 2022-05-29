using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Assigning Variables
    [SerializeField] float steerSpeed = 1f; // Serialize Field allows me to
    [SerializeField] float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; // Gets the axis number and multiplies it by speed e.g. 1 * 5
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime ;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount , 0);

    }
}
