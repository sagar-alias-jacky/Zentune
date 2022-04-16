using System.Collections;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine;

public class lightning : MonoBehaviour
{

    [SerializeField] float secondsBetweenFlickers;
    Light2D pointLight;
    int count;


    // Start is called before the first frame update
    void Start()
    {
        count=0;
        pointLight=GetComponent<Light2D>();
        StartCoroutine(CallLightning());
    }


    IEnumerator CallLightning()
    {
        yield return new WaitForSeconds(secondsBetweenFlickers);
        pointLight.intensity=Random.Range(0,3);
        count++;
        if(count>=Random.Range(15,25))
        {
            count=0;
            pointLight.intensity=0;
            yield return new WaitForSeconds(Random.Range(2,7));
        }
        StartCoroutine(CallLightning());
    }
}
