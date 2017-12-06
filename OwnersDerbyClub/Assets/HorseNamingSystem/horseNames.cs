using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class horseNames : MonoBehaviour {

 

    void Start() {

        //Unity's way of loading a .txt file, located in "Resources" Folder, file name "horseNames".
        TextAsset nameText = Resources.Load<TextAsset>("horseNames");

        //Splits each entry that has an enter after it and #'s em.
        string[] lines = nameText.text.Split("\n"[0]);

        //Does math to find random name, names it "sire".
        string randomlyGeneratedName = (lines[Random.Range(0, lines.Length)]);

        //Logs a randomly generated name (WORKING)!
        Debug.Log(randomlyGeneratedName);


        //*TO DO*\\
    //CAN NOT GET IT OUT OF DEBUG.LOG. INFO DOESN'T TRANSFER NO MATTER WHAT I DO
    //SYSTEM IS WORKING BUT *ONLY* IN DEBUG.LOG
    //I'm sure there is a better solution/easier way




    }
    void Update () {



	}

    //This does stuff with a random GUI to Display the random horse name. doesn't work.
    //void OnGUI()
    //{
        //if (GUI.Button(new Rect(50, 50, 50, 50), "generate name"))
        //{
           // Debug.Log(lines());
        //}
    //}

}
