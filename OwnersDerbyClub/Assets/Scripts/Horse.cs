using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : MonoBehaviour {
	// Integrals
	string horseName;
	double age;
	bool gender;
	Dictionary<string, double> stats;

	List<string> statNames = new List<string>{
		// Potential Internals
		"speed", "speedDelta", "stamina", "staminaDelta", "sharp", "sharpDelta", 
		// Performance Internals
		"dirt", "offTrack", "tiredness", 
		// Externals (viewable by user)
		"start", "corner", "outOfBox", "competing", "tenacious", "spurt"
	};
		
	// Use this for initialization
	void Start () {
		
	}

	// maek random horse
	public Horse(double buff=1){
		horseName = "Roger"; // Austin- stick yah filthy generater here.
		gender = ((int)(Random.value + .5)) == 1; // Be you boy or girl?
		age = Random.value * 4 + 2;  // Equal distribution between 2 and 6.

		stats = new Dictionary<string, double>();
		foreach (var stat in statNames){
			// Gives each attribute a score between 1 and 16, with heavy bias around 4.
			double newValue = buff + Random.value * 16 - Random.value * 12;
			if (newValue < 1) {
				newValue = Random.value * 3 + 1;
			} else if (newValue > 16) {
				newValue = 16;
			}

			stats.Add (stat, newValue);
		}
	}

	public Horse(Horse papaHorse, Horse mamaHorse){
		if (papaHorse.gender != mamaHorse.gender) {
			horseName = "Roget";
			gender = ((int)(Random.value + .5)) == 1; // Be you boy or girl?
			age = 0;  // Equal distribution between 2 and 6.
			stats = new Dictionary<string, double>();
			foreach (var stat in statNames){
				double newValue = (papaHorse.stats[stat] + mamaHorse.stats[stat]) / 1.9;
				newValue += 2 * Random.value - 1;
				if (newValue < 0) {
					newValue = 1;
				} else if (newValue > 16) {
					newValue = 16;
				}

				stats.Add (stat, newValue);
			}
		} else {
			Debug.Log ("Just like Pastor Dan said, it may be fun, but there's no bun.");
		}
	}


	public void PrintStats(){
		foreach (var stat in statNames) {
			Debug.Log (stat + ":\t\t" + stats [stat]);
		}
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}
}
