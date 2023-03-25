using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float rotateAngle = 45.0f;
    public float rotateTime = 0.2f;

    private Vector3 nextAngle = new Vector3(0, 0, 0);
    private bool isRotating = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;

        Rotate();
    }

    void Rotate()
    {
        if(isRotating) { return; }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(RotateAround(-rotateAngle, rotateTime));
        } else if(Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(RotateAround(rotateAngle, rotateTime));
        }
    }

    IEnumerator RotateAround(float angle, float time)
    {
        isRotating = true;

        float totalTime = 60 * time;
        float deltaAngle = angle / totalTime;
        nextAngle.z = deltaAngle;

        for(int i = 0; i < totalTime; i++)
        {
            transform.Rotate(nextAngle);
            yield return new WaitForFixedUpdate();
        }

        isRotating = false;
    }
}
