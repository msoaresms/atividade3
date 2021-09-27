using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;

    public float Speed;

    public Transform rightCol;
    public Transform leftCol;

    public Transform heightPoint;
    private bool colliding;

    public LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(Speed, rig.velocity.y);
        colliding = Physics2D.Linecast(rightCol.position, leftCol.position, layer);
        //Debug.Log(colliding);

        if (colliding)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1f, transform.localScale.y);
            Speed *= -1f;
        }
    }
}
