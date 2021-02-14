using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deel2: MonoBehaviour
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
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            Debug.Log("ik kan hier wel tegen");
            yield return new WaitForSeconds(.5f);
        }          
        Debug.Log("ik kan hier niet tegen");
        yield return new WaitForSeconds(.5f); 
    }
}
