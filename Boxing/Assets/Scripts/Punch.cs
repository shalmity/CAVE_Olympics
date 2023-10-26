using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public bool isHit;
    public float cool;
    private AudioSource audioSource;
    private AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        cool = 0f;
        isHit = false;
        audioSource = GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("Punch");
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            cool += Time.deltaTime;
            if (cool >= 0.2f)
            {
                cool = 0f;
                isHit = false;
            }

        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Dummy" && isHit == false)
        {
            isHit = true;
            audioSource.Play();
        }
    }
}
