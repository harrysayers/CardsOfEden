using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour {

    public GameObject GM;
    private GameMode controller;
    public GameObject basic;
    public GameObject medium;
    public GameObject extreme;
    public GameObject ArScene;
    public GameObject scanScene;

	public void Start()
	{
        controller = GM.GetComponent<GameMode>();
	}

    public void bottleBtnBack()
    {
        switch (controller.Bottleback)
        {
            case 0:
                scanScene.SetActive(false);
                ArScene.SetActive(false);
                basic.SetActive(true);
                medium.SetActive(false);
                extreme.SetActive(false);
                break;
            case 1:
                scanScene.SetActive(false);
                ArScene.SetActive(false);
                basic.SetActive(false);
                medium.SetActive(true);
                extreme.SetActive(false);
                break;
            case 2:
                scanScene.SetActive(false);
                ArScene.SetActive(false);
                basic.SetActive(false);
                medium.SetActive(false);
                extreme.SetActive(true);
                break;
        }
    }

	public void GotoMainScene()
    {
        SceneManager.LoadScene("main");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GotoBasicScene()
    {
        SceneManager.LoadScene("Basic");
    }

    public void GotoMediumScene()
    {
        SceneManager.LoadScene("Medium");
    }

    public void GotoExtremeScene()
    {
        SceneManager.LoadScene("Extreme");
    }

    public void GotoArScene()
    {
        SceneManager.LoadScene("ArScene");
    }

    public void GotoScanScene()
    {
        SceneManager.LoadScene("Scan");
    }

    public void ChangeUiOld(Transform old){
        old.gameObject.SetActive(false);
    }

    public void ChangeUiNew(Transform newObject)
    {
        newObject.gameObject.SetActive(true);

    }


}
