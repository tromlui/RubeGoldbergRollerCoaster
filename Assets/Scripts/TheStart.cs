using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheStart : MonoBehaviour {

	public GameObject startText;
	public GameObject startDomino1;
	public GameObject startDomino2;
	public GameObject startingBlock;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			startText.SetActive (false);
			startDomino1.SetActive (true);
			startDomino2.SetActive (true);
			startingBlock.SetActive (false);
		}
	}
		
}
