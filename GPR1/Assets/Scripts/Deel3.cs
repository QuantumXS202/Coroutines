using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deel3: MonoBehaviour
{
    public float ex;
    public Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("space"))
        {
          StartCoroutine("Fade");
        }
    }

    IEnumerator Fade()
    {
        for (float ft = ex; ft >= 0; ft -= 0.1f)
        {
            Color c = renderer.material.color;
            c.a = ft;
            renderer.material.color = c;
            yield return new WaitForSeconds(.1f);
        }          
    }
}
