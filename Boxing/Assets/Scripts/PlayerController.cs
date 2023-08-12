using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int userScore = 0;

    public float turnSpeed = 4.0f;
    private float xRotate = 0.0f;

    private Animator animator;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        //in test
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        float yRotate = transform.eulerAngles.y + yRotateSize;
        transform.eulerAngles = new Vector3(0, yRotate, 0);

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("IsLeadJab", true);
        }
        else
        {
            //animator.SetBool("IsLeadJab", false);
        }
    }
}