using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glove : MonoBehaviour
{
    public float pushForce = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody other = collision.collider.attachedRigidbody;

        if (other != null && other.tag == "Player")
        {
            Vector3 pushDirection = collision.contacts[0].point - transform.position;
            pushDirection.y = 0f;

            other.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
        }
    }
}
