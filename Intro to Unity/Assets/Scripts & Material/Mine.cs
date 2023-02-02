using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{


    public GameObject Diamond;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ThrowDiamond");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopThrow() {
        StopCoroutine("ThrowDiamond");
    }

    IEnumerator ThrowDiamond() {
        for (;;){
            Instantiate(Diamond);
            yield return new WaitForSeconds(Random.Range(1.5f, 3.5f));
        }
    }
}
