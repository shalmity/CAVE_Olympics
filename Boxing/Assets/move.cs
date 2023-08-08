using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
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