using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{


    public GameObject Diamond;
    // Start is called before the first frame update
    void Start()
    {
        ThrowDiamond();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ThrowDiamond() {
        for (;;){
            Instantiate(Diamond);
            yield return new WaitForSeconds(Random.Range(1.0f, 2.5f));
        }
    }
}
