using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GUIStyle myStyle;
	string score;

	// Use this for initialization
	void Start()
	{
		/*StreamReader scoreData = new StreamReader(Application.persistentDataPath + "score.gd");
		score = scoreData.ReadLine();
		scoreData.Close();*/

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnGUI()
	{
		//GUI.Box(new Rect(Screen.width * 0.15f, Screen.height * 0.8f, Screen.width * 0.7f, Screen.height * 0.1f), "Рекаорд:" + score, myStyle);

		if (GUI.Button(new Rect(Screen.width * 0.27f, Screen.height * 0.25f, Screen.width * 0.2f, Screen.height * 0.1f), "Начать игру", myStyle))
		{
            SceneManager.LoadScene(1);
		}
		if (GUI.Button(new Rect(Screen.width * 0.32f, Screen.height * 0.4f, Screen.width * 0.2f, Screen.height * 0.1f), "Рекорды", myStyle))
		{
			Application.LoadLevel(1);
		}
		if (GUI.Button(new Rect(Screen.width * 0.67f, Screen.height * 0.25f, Screen.width * 0.2f, Screen.height * 0.1f), "Настройки", myStyle))
		{
			print("Выход");
			Application.Quit();
		}
		if (GUI.Button(new Rect(Screen.width * 0.62f, Screen.height * 0.4f, Screen.width * 0.2f, Screen.height * 0.1f), "Справка", myStyle))
		{
			print("Выход");
			Application.Quit();
		}

	}
}
