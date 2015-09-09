using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	public GUISkin skin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{

			GUI.skin = skin;
			GUI.Box (new Rect (0, 0, Screen.width, Screen.height), "");
			GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "一八九五台灣民主國");
		GUI.Label (new Rect (0, 50, Screen.width, Screen.height), "Formosa 1895");
		if(GUI.Button (new Rect ( Screen.width/2, Screen.height/2+100, 150, 80), "開始遊戲"))
			Application.LoadLevel(3);
	}
}
