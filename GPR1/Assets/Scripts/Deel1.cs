using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deel1: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Fade");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fade()
    {
        Debug.Log("Ik start nu de coroutine");
        yield return new WaitForSeconds(.5f);
        Debug.Log("ik kan hier wel tegen");
        yield return new WaitForSeconds(.5f);
        Debug.Log("ik kan hier niet tegen");
        yield return new WaitForSeconds(.5f); 
    }
}
