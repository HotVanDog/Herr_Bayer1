  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerrBayer : MonoBehaviour
{
    public float speed = 30;
    public float richtung;
    private Rigidbody2D rb;
    public float jumpH = 20;
    private bool amBoden = false;
    private Animator animator;
    private Vector3 rotation;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rotation =transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        richtung = Input.GetAxis("Horizontal");

        if(richtung != 0)
        {
            animator.SetBool("läuft", true);
        }
        else
        {
            animator.SetBool("läuft", false);
        }

        if(richtung < 0)
        {
            transform.eulerAngles = rotation - new Vector3(0, 180, 0);
            transform.Translate(Vector2.right * speed * -richtung * Time.deltaTime);
        }

        if (richtung > 0)
        {
            transform.eulerAngles = rotation - new Vector3(0, 0, 0);
            transform.Translate(Vector2.right * speed * richtung * Time.deltaTime);
        }



        if (Input.GetKeyDown(KeyCode.Space) && amBoden == true)
        {
            rb.AddForce(Vector2.up * jumpH, ForceMode2D.Impulse);
            amBoden=false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boden")
        {
            amBoden = true;
        }
    }
}
