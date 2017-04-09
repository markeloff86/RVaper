using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMoving : MonoBehaviour {
    private float jumpForce = 15.0F;
    private Rigidbody2D rigid;

    // Use this for initialization
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Jump")) Jump();
    }

    
    private void Jump()
    {
        rigid.AddForce(transform.up * jumpForce,ForceMode2D.Impulse);
    }

    
}
