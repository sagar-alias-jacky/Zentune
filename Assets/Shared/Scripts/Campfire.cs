using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Campfire : MonoBehaviour
{
    [SerializeField] float firstIntensity;
    [SerializeField] float secondIntensity;
    [SerializeField] float firstOuterRadius;
    [SerializeField] float secondOuterRadius;
    [SerializeField] float secondsBetweenFlickers;

    Light2D campfire;


    // Start is called before the first frame update
    void Start()
    {
        campfire=GetComponent<Light2D>();
        StartCoroutine(LightFlicker());
    }

    IEnumerator LightFlicker()
    {
        yield return new WaitForSeconds(secondsBetweenFlickers);
        campfire.pointLightOuterRadius=Random.Range(firstOuterRadius,secondOuterRadius);
        campfire.intensity=Random.Range(firstIntensity,secondIntensity);
        StartCoroutine(LightFlicker());
    }

}
