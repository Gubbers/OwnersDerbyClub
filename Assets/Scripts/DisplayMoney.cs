using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour {
	Text txt;
	private double money=50000;

	void Start () {
		txt = gameObject.GetComponent<Text> ();
		txt.text = "Money: " + money;
	}
	

	void Update () {
		txt.text = "Mooney: " + money;
	}

	public double GetMoney(){
		return money;
	}

	public void SpendMoney(double spendingAmount){
		money -= spendingAmount;
	}
}
