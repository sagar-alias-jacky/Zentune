using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class StormLightning : MonoBehaviour
{
    [SerializeField] float secondsBetweenFlickers;
    [SerializeField] float minIntensity;
    [SerializeField] float maxIntensity;
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
        pointLight.intensity=Random.Range(minIntensity,maxIntensity);
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
