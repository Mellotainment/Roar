using UnityEngine;
using System.Collections;
using UnityEngine.SceneManager;

public class monster : MonoBehaviour {

	public float	enemySpeed = .5f;
	public int 		dir = 1;
	public float	offset = 4;


	void Start () {

	}


	void Update () {

		float t = Time.time - offset;



		if(t > 5){
			dir = -dir;
			offset = Time.time;
		

		GetComponent<Rigidbody>().velocity = new Vector3(

			enemySpeed * dir, 

			GetComponent<Rigidbody>().velocity.x);
	

		void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "MainCamera")
			Debug.log ("Oh NO");
		SceneManager.LoadScene ("end");
	}
}
	}
}
}
			
