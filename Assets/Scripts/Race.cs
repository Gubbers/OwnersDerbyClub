using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Create_Race (Horse entryHorse){
		List<Horse> horses = new List<Horse>();
		horses.Add (entryHorse);
		while(horses.Count < 6){
			horses.Add(new Horse());
		}
	}

	Horse Determine_Winner (List<Horse> horses){
		return horses [0];
	}
}
