using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed;
	Rigidbody2D rb;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> () ;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void PixedUpdate(){
		float move = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2 (speed * move, rb.velocity.y);
	}
}
