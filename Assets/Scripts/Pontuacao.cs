using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {

	//public static Pontuacao instance;

	public static int pontosJogador1, pontosJogador2;
	public Text score1, score2;

//	public static Pontuacao GetInstance() {
//		if (instance == null) {
//			instance = Cam;
//		}
//		return instance;
//	}


	// Use this for initialization
	void Start () {
		pontosJogador1 = 0;
		pontosJogador2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		AtualizarPontuacao();
	}

	public void AtualizarPontuacao() {
		score1.text = pontosJogador1.ToString();
		score2.text = pontosJogador2.ToString();
	}
}
