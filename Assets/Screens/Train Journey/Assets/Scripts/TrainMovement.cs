using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour {

    private Vector3 startPos;
    [SerializeField]
    private float t;
    [SerializeField]
    private float waitTime;
    private Vector3 finalPos;
    private float newX;
    [SerializeField]
    private float moveDis;

    // Start is called before the first frame update
    void Start() {
        startPos = gameObject.transform.position;
        StartCoroutine(MoveTrain());
    }

    IEnumerator MoveTrain() {
        yield return new WaitForSeconds(waitTime);
        startPos = gameObject.transform.position;
        newX = startPos.x - moveDis;
        finalPos = new Vector3(newX, startPos.y, startPos.z);
        transform.position = Vector3.Lerp(startPos, finalPos, t);
        yield return new WaitForSeconds(waitTime);
        newX = gameObject.transform.position.x + moveDis;
        finalPos = new Vector3(newX, startPos.y, startPos.z);
        transform.position = Vector3.Lerp(gameObject.transform.position, finalPos, t);
        StartCoroutine(MoveTrain());
    }
}
