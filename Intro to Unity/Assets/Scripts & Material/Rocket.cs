using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    public static GameManager scores; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        print("Collision");
        if (col.gameObject.tag == "Diamond") {
            Destroy(col.gameObject);
            GameManager.Instance.IncScore(10);
        }
    }
}
