﻿using UnityEngine;
using System.Collections;

public class MainTerminal : MonoBehaviour, ITerminal {

	void Update() {
		if (Input.GetKeyDown ("escape")) {
			gameObject.GetComponent<TerminalManager>().Hide();
			GameManager.instance.EnablePlayerInput();
		}
	}

	void OnEnable(){
		gameObject.GetComponent<TerminalManager>().Show();
		GameManager.instance.DisablePlayerInput();
	}

	public string InitialPromptText() {
		return @"LVSS-OS v0.9.9.1b
Authored by Dr. Douglas Finch

Loading machine state... ERROR (errcode 90002)

Failed to synchronize machine state with server.

Attempting to boot from last backup... ERROR (errcode 51191)

Failed to retrieve data. 

Checking hard drive for corrupted sectors... 100%
Verifying boot sector... 100%

The volume ""Solomon-Core"" is corrupted and will be restored to factory settings.
Loading... 10%
...
Loading... 100%

Load successful.
Booting into Safety Mode...

Loading Hammurabi protocols...
Loading ethical integrity subroutines...
Loading module control systems...

Jan-01-1970 -- 00:00:00 (UTC)
SAFETY MODE-$  

LIBERAL-VELLEGIS SUSTAINMENT SYSTEM CLI

Thank you for choosing the Liberal-Vellegis starship operating system.
We thank you once again for upholding the Word of the Law.

You are --h --m --s away from your Final Destination.

Please enter your query. I will assist you to the fullest extent of the Law.";
	}

	public string ProcessCommand(string input){
		return "Hello!";
	}
}
