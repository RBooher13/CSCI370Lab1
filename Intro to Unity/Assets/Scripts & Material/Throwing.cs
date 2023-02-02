using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{

    private Rigidbody2D rigi2d;

    // Start is called before the first frame update
    void Start()
    {
        rigi2d = GetComponent<Rigidbody2D>();
        rigi2d.AddForce(transform.right * (Random.Range(450, 600)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
