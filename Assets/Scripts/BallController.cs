using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public float force = 50;
    public float speed;
    public float turnSpeed;
    public Rigidbody ball;
    private bool space;

	// Use this for initialization
	void Start () {
        
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void FixedUpdate() {
        force += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        if (Input.GetKeyDown("space") && ball.velocity.magnitude < .5f) {
            ball.AddForce(transform.forward * force, ForceMode.Impulse);
            space = true;
        }
        if (space = true && ball.velocity.magnitude < .5f)
        {
            ball.velocity = new Vector3(0, 0, 0);
            space = false;
        }
    }
}
