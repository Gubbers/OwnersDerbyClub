using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseCreation : MonoBehaviour {
	public GameObject moneyHolder;

	int HORSECOST = 500;

	List<Horse> horses = new List<Horse>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void BuyHorse(){
		if (HORSECOST <= moneyHolder.GetComponent<DisplayMoney> ().GetMoney ()) {
			horses.Add(new Horse ());
			horses [horses.Count - 1].PrintStats ();
			moneyHolder.GetComponent<DisplayMoney> ().SpendMoney (HORSECOST);
			Debug.Log ("Horse Q: " + horses.Count);
		}
	}
}
