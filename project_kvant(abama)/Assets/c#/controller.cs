using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private Rigidbody2D rb;

    public Vector2 vector;

    [SerializeField] private int speed=10;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(transform.up * 10, ForceMode2D.Impulse);
            
            
        }
        vector = new Vector2(Input.GetAxis("Horizontal"),-0.2f);
        rb.velocity = (vector * speed);
        
    }
}
