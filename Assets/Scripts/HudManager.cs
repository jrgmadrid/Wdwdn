﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{

		public Text textToUpdate;
		public Text countDownText;

		// Update is called once per frame
		void FixedUpdate () {
			textToUpdate.text = PlayerStateManager.instance.playerEnergy + "/" + PlayerStateManager.MAX_ENERGY;
			if (PlayerStateManager.instance.hasUnlockedBridge) {
				countDownText.gameObject.SetActive(true);
				var timeInSeconds = PlayerStateManager.REAL_TIME_COUNTDOWN_IN_SECONDS - PlayerStateManager.instance.realTimeElapsedInSeconds;
				var minutesString = Mathf.FloorToInt((timeInSeconds / 60)).ToString("00");
			var secondsString = Mathf.FloorToInt(timeInSeconds % 60).ToString("00");

				countDownText.text =  minutesString + ":" + secondsString;
			}
		}
}
