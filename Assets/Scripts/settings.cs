using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings: MonoBehaviour {

    public GameObject panel;
    public GameObject CloseBtn;
    public GameObject OpenBtn;

	private void Start()
	{
        panel.SetActive(false);
        CloseBtn.SetActive(false);
	}

	public void OpenPanel(){
        panel.SetActive(true);
        OpenBtn.SetActive(false);
        CloseBtn.SetActive(true);
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        OpenBtn.SetActive(true);
        CloseBtn.SetActive(false);
    }
}
