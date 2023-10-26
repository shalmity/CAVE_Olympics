using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Dummy : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent nav;
    private bool isChase;
    private float targetDis;
    private GameObject target;
    private GameObject rightHand;
    private int hp;
    private BoxingScoreboard board;
    private SummonDummy summonDummy;
    public bool isHit;
    public float cool;
    private AudioSource audioSource;
    private AudioClip audioClip;


    void Start()
    {
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("OVRPlayerController");
        targetDis = Vector3.Distance(target.transform.position, transform.position);
        board = GameObject.Find("ScoreBoardManage").GetComponent<BoxingScoreboard>();
        summonDummy = GameObject.Find("RoundManager").GetComponent<SummonDummy>();
        isChase = false;
        rightHand = GameObject.Find("glove");
        rightHand.SetActive(false);
        hp = 3;
        cool = 0f;
        isHit = false;
        audioSource = GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("Punch");
    }

    // Update is called once per frame
    void Update()
    {
        targetDis = Vector3.Distance(target.transform.position, transform.position);
        if (targetDis > 2 && isChase == false)
        {
            isChase = true;
            nav.SetDestination(target.transform.position);
            rightHand.SetActive(false);
            anim.SetBool("isAttack", false);
            anim.SetFloat("Speed", 1f);
        }
        else
        {
            isChase = false;
            rightHand.SetActive(true);
            anim.SetBool("isAttack", true);
            anim.SetFloat("Speed", 0f);
        }
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

        if (col.tag == "Glove" && isHit == false)
        {
            //����ٰ� Ÿ���� �־��ּ���! put sound effect
            hp--;
            anim.SetTrigger("Damage");
            isHit = true;
            if (hp <= 0)
            {
                //score ���, destroy
                board.PlayerAttackedEnemy();
                summonDummy.isDummy = false;
                GameObject.Destroy(this.gameObject);
            }

        }
    }
    
}
