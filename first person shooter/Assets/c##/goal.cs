using UnityEngine;
using System.Collections;
using UnityEngine.SceneManager;

public class goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (other.gameObject.tag == "MainCamera")
			Debug.log ("Oh NO");
		SceneManager.LoadScene ("end");
	}
}