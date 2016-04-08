using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

    public float speed;
    private float prevH=0,prevV;
    private float HorV, VertV;
    private Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if(gameObject.tag == "player1")
        {
            
            HorV = Input.GetAxis("Horizontal");
            VertV = Input.GetAxis("Vertical");
        }
        else if (gameObject.tag == "player2")
        {
            HorV = Input.GetAxis("Horizontal2");
            VertV = Input.GetAxis("Vertical2");

        }

        Vector3 force = new Vector3(speed * HorV, 0, speed * VertV);
        rb.AddForce(force);
    }
}
