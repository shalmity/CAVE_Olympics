using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float speed = 5.0f;

    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        Vector3 moveVelocity = moveDirection.normalized * speed;

        // 캐릭터 컨트롤러에 중력 적용
        moveVelocity.y = Physics.gravity.y;

        // 충돌 처리와 이동 적용
        controller.Move(moveVelocity * Time.deltaTime);
    }
}

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
            animator.SetBool("IsLeadJab", true);
        }
        else
        {
            // Lead Jab 애니메이션이 활성화되지 않았을 때는 애니메이션 비활성화
            animator.SetBool("IsLeadJab", false);
        }

        // 추가: Lead Jab 애니메이션 활성화 여부 확인 후 Hit to Body 애니메이션 활성화
        if (animator.GetBool("IsLeadJab"))
        {
            // Lead Jab 애니메이션을 찾을 때만 Hit to Body 애니메이션 활성화
            // Hit to Body 애니메이션의 조건은 여기에 따로 추가해야 합니다.
            // 이 예제에서는 Lead Jab 애니메이션이 실행 중일 때 특정 조건을 만족하면 Hit to Body를 활성화한다고 가정합니다.
            animator.SetBool("IsHitToBody", true);
        }
        else
        {
            // Lead Jab 애니메이션이 비활성화되면 Hit to Body 애니메이션도 비활성화
            animator.SetBool("IsHitToBody", false);
        }
    }
}
