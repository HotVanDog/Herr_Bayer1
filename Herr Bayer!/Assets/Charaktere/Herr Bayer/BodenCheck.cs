using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private Transform rayCastOrigin;
    [SerializeField] private Transform HerrBayerF��e;
    [SerializeField] private LayerMask layerMask;
    private RaycastHit2D Hit2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void BodenCheckMethod()
    {
        Hit2D = Physics2D.Raycast(rayCastOrigin.position, -Vector2.up, 100f, layerMask);

        if (Hit2D != false)
        {
            Vector2 temp = HerrBayerF��e.position;
            temp.y = Hit2D.point.y;
            HerrBayerF��e.position = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        BodenCheckMethod();
    }
}
