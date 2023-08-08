using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerrBayer : MonoBehaviour
{
    public float speed = 30;
    public float richtung;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        richtung = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * richtung * Time.deltaTime);
    }
}
