using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Keypad1 : Action_Scenario_Etape
{
  	public string curPassword = "8279";
	public string input;
	public bool onTrigger;
	public static bool keypadScreen;


	override public void Start () {
        base.Start();
	}

	void OnTriggerEnter(Collider other)
	{
		onTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		onTrigger = false;
		keypadScreen = false;
		input = "";
	}

	override public void Update()
	{
		if(input == curPassword)
		{
			keypadScreen = false;
			Cursor.lockState = CursorLockMode.None;
			Declencher_Etape_Suivante_Du_Scenario();
		}

	}

	void OnGUI()
	{
		if(onTrigger)
			{
				GUI.Box(new Rect(0, 0, 400, 25), "Press 'K' to open keypad and Echap for Press keypad.");

				if(Input.GetKeyDown(KeyCode.K))
				{
					Cursor.lockState = CursorLockMode.None;
					keypadScreen = true;
					onTrigger = false;
				}
			}

			if(keypadScreen)
			{
				GUI.Box(new Rect(325, 0, 200, 25), "Press 'C' to close keypad .");
				GUI.Box(new Rect(0, 0, 320, 455), "");
				GUI.Box(new Rect(5, 5, 310, 25), input);

				if(GUI.Button(new Rect(5, 35, 100, 100), "1"))
				{
					input = input + "1";
				}

				if(GUI.Button(new Rect(110, 35, 100, 100), "2"))
				{
					input = input + "2";
				}

				if(GUI.Button(new Rect(215, 35, 100, 100), "3"))
				{
					input = input + "3";
				}

				if(GUI.Button(new Rect(5, 140, 100, 100), "4"))
				{
					input = input + "4";
				}

				if(GUI.Button(new Rect(110, 140, 100, 100), "5"))
				{
					input = input + "5";
				}

				if(GUI.Button(new Rect(215, 140, 100, 100), "6"))
				{
					input = input + "6";
				}

				if(GUI.Button(new Rect(5, 245, 100, 100), "7"))
				{
					input = input + "7";
				}

				if(GUI.Button(new Rect(110, 245, 100, 100), "8"))
				{
					input = input + "8";
				}

				if(GUI.Button(new Rect(215, 245, 100, 100), "9"))
				{
					input = input + "9";
				}

				if(GUI.Button(new Rect(110, 350, 100, 100), "0"))
				{
					input = input + "0";
				}
				if(GUI.Button(new Rect(215, 350, 100, 100), "Clear"))
				{
					input = "";
				}

				if(Input.GetKeyDown(KeyCode.C))
				{
					Cursor.lockState = CursorLockMode.Locked;
					keypadScreen = false;
					onTrigger = true;
				}
			}
	}

	override public void Declencher_Etape_Suivante_Du_Scenario()
    {
        base.Declencher_Etape_Suivante_Du_Scenario();
        this.enabled = true;
    }
}
