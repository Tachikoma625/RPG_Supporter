using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Player_Anime_Control : MonoBehaviour {
	private Animator m_player;
	public int m_player_state = 3;

	// Use this for initialization
	void Start () {
		m_player = GetComponent<Animator> ();
		m_player.SetInteger ("Walk", 3);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.DownArrow)) {
			m_player.SetInteger ("Walk", 3);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			m_player.SetInteger ("Walk", 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			m_player.SetInteger ("Walk", 1);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			m_player.SetInteger ("Walk", 2);
		}

	}
}
