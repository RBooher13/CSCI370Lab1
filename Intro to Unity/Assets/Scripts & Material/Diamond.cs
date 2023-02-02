using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{

    private bool missed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5 && !missed){
            StartCoroutine("miss");
            missed = true;
        }
    }

    void miss(){
        Destroy(gameObject);
    }
}
