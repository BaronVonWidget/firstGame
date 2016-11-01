using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public Transform target;
    public float force = 50;
    public float speed;
    public Rigidbody ball;
    private Vector3 forceDir;
    private bool space = false;

	// Use this for initialization
	void Start () {
        
	}

    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        force += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        if (Input.GetKeyDown("space") && ball.velocity.magnitude < .5f) {
            forceDir = Vector3.ProjectOnPlane(target.forward, Vector3.up);
            forceDir.Normalize();
            ball.AddForce(forceDir * force, ForceMode.Impulse);
            space = true;
        }
        if (space = true && ball.velocity.magnitude < .5f)
        {
            ball.velocity = new Vector3(0, 0, 0);
            space = false;
        }
    }
}
