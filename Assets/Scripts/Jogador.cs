using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	private Rigidbody2D rb;
	private bool indoCima, indoBaixo;

	public float velocidade;
	public KeyCode teclaCima, teclaBaixo;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(teclaCima)) {
			indoCima = true;
		} else {
			indoCima = false;
		}

		if (Input.GetKey(teclaBaixo)) {
			indoBaixo = true;
		} else {
			indoBaixo = false;
		}
	}

	void FixedUpdate () {
		if (indoCima) {
			rb.velocity = new Vector2(0, velocidade);
		} else if (indoBaixo) {
			rb.velocity = new Vector2(0, -velocidade);
		} else {
			rb.velocity = new Vector2(0, 0);
		}
	}
}
