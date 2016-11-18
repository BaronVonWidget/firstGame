using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

    public Transform target;
    public float speed;
    public float distance;
    private float currentAngle = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentAngle -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            currentAngle += speed * Time.deltaTime;
        }
        Quaternion q = Quaternion.Euler(25, currentAngle, 0);
        Vector3 direction = q * Vector3.forward;
        transform.position = target.position - direction * distance;
        transform.LookAt(target.position);
    }
}
