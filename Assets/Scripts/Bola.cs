using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {

	private Rigidbody2D rb;
	private AudioSource audioSource;
	public AudioClip somPong, somPontuacao;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		audioSource = GetComponent<AudioSource>();
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0 && Input.anyKeyDown) {
			AplicarForcaInicial();
			Time.timeScale = 1;
		}
	}

	void OnCollisionEnter2D(Collision2D outro) {
		if (outro.gameObject.tag == "Player") {
			rb.velocity += outro.gameObject.GetComponent<Rigidbody2D>().velocity/3;
			audioSource.PlayOneShot(somPong);
		}
	}

	void OnTriggerEnter2D(Collider2D parede) { 
		if (parede.gameObject.tag == "paredeDir") {
			Pontuacao.pontosJogador1++;
			ZerarBola();
		} else if (parede.gameObject.tag == "paredeEsq") {
			Pontuacao.pontosJogador2++;
			ZerarBola();
		}
	}

	public void AplicarForcaInicial() {
		// configura força aleatorioa inicial da bola
		float forcaAleatoriaX = Random.Range(0,10) < 5 ? 0.05f : -0.05f;
		float forcaAleatoriaY = Random.Range(0.02f, -0.02f);
		rb.AddForce(new Vector2(forcaAleatoriaX, forcaAleatoriaY));
	}

	public void ZerarBola() {
		audioSource.PlayOneShot(somPontuacao);
		transform.position = new Vector3(0, 0, transform.position.z);
		rb.velocity = new Vector2(0, 0);
		Time.timeScale = 0;
	}
}
