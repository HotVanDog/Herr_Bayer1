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
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        richtung = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * richtung * Time.deltaTime);

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
