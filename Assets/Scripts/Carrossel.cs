﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel: MonoBehaviour {

	[SerializeField]
	private float velocidade;
	private Vector3 posicaoInicial;
	private float tamanhoRealDaImagem;

	// Use this for initialization
	void Awake () {
		posicaoInicial = transform.position;
		float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
		float escala = transform.localScale.x;
		tamanhoRealDaImagem = tamanhoDaImagem * escala;
	}
	
	// Update is called once per frame
	void Update () {
		float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoRealDaImagem);
		transform.position = this.posicaoInicial + Vector3.left * deslocamento;
		//transform.position = 
	}
}
