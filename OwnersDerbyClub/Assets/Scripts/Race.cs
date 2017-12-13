using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	List<Horse> Determine_Placing(List<Horse> horses){
		horses.Sort ();
		return horses;
	}

	void Stat_Changes (Horse entryHorse, int placement){
		Debug.Log("Stat Changes Here");
	}

	void Display_Winnings(int placement){
		Debug.Log("Winnings Desplay Here");
	}

	double Create_Race (Horse entryHorse){
		double level = 2.0;
		List<Horse> horses = new List<Horse> ();
		horses.Add (entryHorse);
		while (horses.Count < 6) {
			horses.Add(new Horse(level));
		}
		horses = Determine_Placing(horses);
		int placement = horses.IndexOf (entryHorse);
		Stat_Changes(entryHorse, placement);
		Display_Winnings(placement);
		return 12.0;
	}

	// Update is called once per frame
	void Update () {

	}
}
OwnersDerbyClub