using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glove : MonoBehaviour
{
    public float pushForce = 1f;
    private BoxingScoreboard board;

    void Start()
    {
        board = GameObject.Find("ScoreBoardManage").GetComponent<BoxingScoreboard>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody other = collision.collider.attachedRigidbody;

        if (other != null && other.GetComponent<Collider>().tag == "Player")
        {
            Vector3 pushDirection = collision.contacts[0].point - transform.position;
            pushDirection.y = 0f;

            other.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
            board.PlayerAttackedEnemy();
        }
    }
}
