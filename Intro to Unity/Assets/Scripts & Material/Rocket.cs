using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public GameObject gameObjectToMove;
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
    public void launch(){
        gameObjectToMove.transform.position = new Vector2((transform.position.x + 0.0f), (transform.position.y + 0.02f));
    }
}
   //Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
   //   transform.position = new Vector2(pos.x, transform.position.y);