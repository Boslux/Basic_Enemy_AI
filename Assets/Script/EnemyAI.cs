using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [Header("")]
    public Transform player;
    private Animator anim;
    private Rigidbody2D rb;

    [Header("config")]
    public float detectionRange;
    public float attackRange;
    public float speed;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        MoveControl();
    }
    void MoveControl()
    {
        float distanceToPlayer=Vector2.Distance(transform.position, player.position);


        if (distanceToPlayer < detectionRange) 
        {
            if (distanceToPlayer < attackRange)
            {
                Debug.Log("Attack to Player");
            }
            else
            {
                Vector2 moveDirection = (player.transform.position - rb.transform.position).normalized;
                rb.velocity = new Vector2(moveDirection.x * (speed * Time.deltaTime * 100), rb.velocity.y);
            }
        }
        else
        {
            rb.velocity= Vector2.zero;
        }
    }
}
