using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public GUISkin skin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey)
			Application.LoadLevel(0);
	}
	void OnGUI()
	{
		
		GUI.skin = skin;
		GUI.Box (new Rect (0, 0, Screen.width, Screen.height), "");
		GUI.Label (new Rect (0, 0, Screen.width, Screen.height), "在鄉民的擁戴下，你率領台灣民主國英勇的與日本人奮戰，保衛台灣直至最後一兵一卒，後人見你忠義滿人間，給你蓋了個大廟，香火鼎盛留芳百世，甚至還有人把這事做成遊戲，真是可喜可賀，可喜可樂");
		GUI.Label (new Rect (0, Screen.height-40, Screen.width, Screen.height), "GOOD END");
	}
}

