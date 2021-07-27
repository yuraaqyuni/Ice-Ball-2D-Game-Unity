using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
	Text infonyawa;

	public Rigidbody2D rb;
	public bool tanah;
	public LayerMask targetlayer;
	public Transform deteksitanah;
	public float jangkauan;

	public int nyawa;

	public bool jatuh;
	public LayerMask targetLayerrr;
	public Transform jatuhApaGak;
	public float jangkauanJatuh;

	public bool manang;
	public LayerMask targetLayerrrManang;
	public Transform MenangGak;
	public float jangkauanMenang;

	public GameObject gameOver, win;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

	void Update() {
		rb.velocity = new Vector2(3, rb.velocity.y);
		tanah = Physics2D.OverlapCircle (deteksitanah.position, jangkauan, targetlayer);      
		if (Input.GetMouseButtonDown(0) && tanah)  {
			rb.velocity = new Vector2(rb.velocity.x, 5);
		}
		jatuh = Physics2D.OverlapCircle (jatuhApaGak.position, jangkauanJatuh, targetLayerrr);
		if (jatuh == true) {
			Destroy (gameObject);
			gameOver.SetActive (true);
		}
		manang = Physics2D.OverlapCircle (MenangGak.position, jangkauanMenang, targetLayerrrManang);
		if (manang == true) {
			Destroy (gameObject);
			win.SetActive (true);
		}
	}

}
