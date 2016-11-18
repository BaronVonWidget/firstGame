using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallController : MonoBehaviour
{

    public Transform target;
    public float force = 50;
    public float speed;
    public Rigidbody ball;
    public Slider power;
    public Text WinText;
    private Vector3 forceDir;
    private bool space;

    // Use this for initialization
    void Start()
    {
        space = false;
        WinText.text = "";
    }

    void Update()
    {
        force += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        power.value = force;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space") && ball.velocity.magnitude < .6f)
        {
            forceDir = Vector3.ProjectOnPlane(target.forward, Vector3.up);
            forceDir.Normalize();
            ball.AddForce(forceDir * force, ForceMode.Impulse);
            space = true;
        }
        if (space = true && ball.velocity.magnitude < .6f)
        {
            ball.velocity = new Vector3(0, 0, 0);
            space = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            other.gameObject.SetActive(false);
            WinText.text = "YOU WIN!";
        }
    }
}
