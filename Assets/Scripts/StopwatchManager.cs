using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopwatchManager : MonoBehaviour
{
	[SerializeField]
	private Button stopwatchBtn;
	[SerializeField]
	private Text counterText;
	public float multiplier = 1;
	private bool isCounting = false;
	private float time = 0f;

	private void Start()
	{
		stopwatchBtn.gameObject.GetComponentInChildren<Text>().text = "Start";
		stopwatchBtn.onClick.AddListener(() => StartStopwatch());
		counterText.text = "00 : 00 : 00 : 00";
	}

	private void Update()
	{
		if (isCounting)
		{
			time += Time.deltaTime * multiplier;
		}
		UpdateCounterText(time);
	}

	private void StartStopwatch()
	{
		isCounting = !isCounting;
		stopwatchBtn.gameObject.GetComponentInChildren<Text>().text = (!isCounting) ? "Start" : "Stop";
		time = (isCounting) ? time : 0f;
	}

	private void UpdateCounterText(float time)
	{
		if (isCounting)
		{
			int second = (int)(time % 60);
			float miliSecond = time - second;
			int minute = (int)((time / 60) % 60);
			int hour = (int)((time / 3600) % 60);
			miliSecond = ((miliSecond) * 60f) - (minute * 3600);
			counterText.text = string.Format("{3:00} : {0:00} : {1:00} : {2:00}", minute, second, miliSecond, hour);
		}
	}
}
