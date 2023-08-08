using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniController : MonoBehaviour
{
    public float turnSpeed = 4.0f;
    private float xRotate = 0.0f;
    public float moveSpeed = 4.0f;

    // 추가: Animator 컴포넌트를 저장할 변수
    private Animator animator;

    void Start()
    {
        // 추가: Animator 컴포넌트 가져오기
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        float yRotate = transform.eulerAngles.y + yRotateSize;
        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);
        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);

        Vector3 move =
            transform.forward * Input.GetAxis("Vertical") +
            transform.right * Input.GetAxis("Horizontal");

        transform.position += move * moveSpeed * Time.deltaTime;

        // 추가: 마우스 왼쪽 클릭 시 애니메이션 활성화
        if (Input.GetMouseButtonDown(0))
        {
            // Lead Jab 애니메이션 활성화
            animator.SetTrigger("IsLeadJab");
        }

    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Hand")
        {
            animator.SetTrigger("IsHitToBody");
        }
    }
}
