using UnityEngine;
using System.Collections;

public class plusplus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	int nr = 0;
	int nummer = 0;
	public void plus () {
		nummer = PlayerPrefs.GetInt("nummer");
		nummer++;
		Debug.Log (nummer);
		PlayerPrefs.SetInt("nummer", nummer);

	}
	// Update is called once per frame
	void Update () {
	
	}
}
