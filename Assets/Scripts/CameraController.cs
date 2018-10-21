using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player; // mantiene riferimento al giocatore

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position; // calcolo la differenza per mantenere la camera fissa 
	}
	
	// Update is called once per frame
	void LateUpdate () { // usiamo LateUpdate per essere sicuri 
        transform.position = player.transform.position + offset;
	}
}
