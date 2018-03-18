using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public int score = 0;
	public int life = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int AddDamage(int damage){
		life -= damage;
		return life;
	}

	public bool IsDead(){
		return (life <= 0);
	}

	public int GetScore(){
		return score;
	}

}
