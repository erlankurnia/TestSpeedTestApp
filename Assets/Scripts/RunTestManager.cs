using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunTestManager : MonoBehaviour
{
	[SerializeField]
	private Button stopwatchBtn;

	private void Start()
	{
		stopwatchBtn.onClick.AddListener(() => OpenPanelStopwatch());
	}

	private void OpenPanelStopwatch()
	{
		MenuActions.instance.panelStopwatch.SetActive(true);
		MenuActions.instance.panelRunTest.SetActive(false);
		MenuActions.instance.saveBtn.gameObject.GetComponentInChildren<Text>().text = "Save";
	}
}
