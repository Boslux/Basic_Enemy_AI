using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movements();
    }
    void Movements()
    {
        float hMove=Input.GetAxis("Horizontal")*Time.deltaTime*speed*100;
        float vMove=Input.GetAxis("Vertical") * Time.deltaTime * speed * 100;
        Vector2 Move=new Vector2(hMove, vMove);
        
        rb.velocity= Move;
    }
}
