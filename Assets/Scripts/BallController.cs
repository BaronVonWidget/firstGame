using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallController : MonoBehaviour
{

    static public  float MAX_FORCE = 60;
    public Transform target;
    public float force;
    public float speed;
    public Rigidbody ball;
    public Slider power;
    public Text shotText;
    private int shots;
    private Vector3 forceDir;
    private bool space = false;

    // Use this for initialization
    void Start()
    {
        space = false;
        shotText.text = "";
        shots = 0;
    }

    void Update()
    {
        force += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        force = Mathf.Clamp(force, 0, MAX_FORCE);
        power.value = force;
        shotText.text = shots + " Shots";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space") && ball.velocity.magnitude < .6f)
        {
            forceDir = Vector3.ProjectOnPlane(target.forward, Vector3.up);
            forceDir.Normalize();
            ball.AddForce(forceDir * force, ForceMode.Impulse);
            shots++;
            space = true;
            Debug.Log("Starting");
        }
        if (space = true && ball.velocity.magnitude < .6f)
        {
            ball.velocity = new Vector3(0, 0, 0);
            space = false;
            Debug.Log("Stopping");
        }
    }
}
