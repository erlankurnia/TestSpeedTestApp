using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuActions : MonoBehaviour
{
	//	Sidebar Button
	public Button menuBtn1, menuBtn2, homeMenuBtn, speedListMenuBtn, intervalResistMenuBtn, setTimeMenuBtn, runTestMenubtn, saveBtn;
	public GameObject panelHome, panelAllContents, panelIntervalResist, panelSetByTime, panelRunTest, panelStopwatch, panelSidebar;
	[SerializeField]
	private Animator sidebarAnim, speedListItemAnim;
	private static MenuActions _instance;

	public static MenuActions instance
	{
		get
		{
			return (_instance == null) ? FindObjectOfType<MenuActions>() : _instance;
		}
	}

	private void Start()
	{
		menuBtn1.onClick.AddListener(() => TogglePanelSidebar());
		menuBtn2.onClick.AddListener(() => TogglePanelSidebar());
		homeMenuBtn.onClick.AddListener(() => TogglePanelMenuHome());
		speedListMenuBtn.onClick.AddListener(() => ToggleSpeedListItem());
		intervalResistMenuBtn.onClick.AddListener(() => TogglePanelIntervalResist());
		setTimeMenuBtn.onClick.AddListener(() => TogglePanelSetByTime());
		runTestMenubtn.onClick.AddListener(() => TogglePanelRunTest());

		panelHome.SetActive(true);
		panelAllContents.SetActive(false);
		panelSetByTime.SetActive(false);
		panelIntervalResist.SetActive(false);
		panelRunTest.SetActive(false);
		panelStopwatch.SetActive(false);
	}

	private void TogglePanelMenuHome()
	{
		panelHome.SetActive(true);
		panelAllContents.SetActive(false);
		TogglePanelSidebar();
	}

	private void TogglePanelIntervalResist()
	{
		TogglePanelSidebar();
		panelAllContents.SetActive(true);
		panelIntervalResist.SetActive(true);
		panelHome.SetActive(false);
		panelSetByTime.SetActive(false);
		panelRunTest.SetActive(false);
		panelStopwatch.SetActive(false);
		SetSaveBtn("Save to PDF");
	}

	private void TogglePanelSetByTime()
	{
		TogglePanelSidebar();
		panelAllContents.SetActive(true);
		panelSetByTime.SetActive(true);
		panelHome.SetActive(false);
		panelIntervalResist.SetActive(false);
		panelRunTest.SetActive(false);
		panelStopwatch.SetActive(false);
		SetSaveBtn("Save to PDF");
	}

	private void TogglePanelRunTest()
	{
		TogglePanelSidebar();
		panelAllContents.SetActive(true);
		panelRunTest.SetActive(true);
		panelSetByTime.SetActive(false);
		panelHome.SetActive(false);
		panelIntervalResist.SetActive(false);
		panelStopwatch.SetActive(false);
		SetSaveBtn("Save to PDF");
	}

	private void ToggleSpeedListItem()
	{
		speedListItemAnim.SetBool("isClose", !speedListItemAnim.GetBool("isClose"));
	}

	private void TogglePanelSidebar()
	{
		sidebarAnim.SetBool("isClose", !sidebarAnim.GetBool("isClose"));
	}

	private void SetSaveBtn(string name)
	{
		saveBtn.gameObject.GetComponentInChildren<Text>().text = name;
	}
}

