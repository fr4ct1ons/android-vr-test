using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody myRb;
    private Vector3 bufferVector;

    private void Awake()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bufferVector.Set(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        Debug.Log("bufferVector: " + bufferVector);
        bufferVector *= speed * Time.deltaTime;
        transform.position = transform.position + bufferVector;
    }
}
