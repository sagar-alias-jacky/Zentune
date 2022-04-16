using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour {
    private float spriteLength;
    private float startPos;
    private Camera cam;
    [SerializeField]
    private float parallaxMultiplier;

    // Start is called before the first frame update
    void Start() {
        cam = Camera.main;
        startPos = transform.position.x;
        spriteLength = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate() {
        float temp = cam.transform.position.x * (1 - parallaxMultiplier);
        float distance = cam.transform.position.x * parallaxMultiplier;
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if (temp > startPos + spriteLength)
        {
            startPos+=spriteLength;
        }
        else if (temp < startPos - spriteLength)
        {
            startPos -= spriteLength;
        }
    }
}
