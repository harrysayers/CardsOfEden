using UnityEngine;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Vuforia;
using UnityEngine.SceneManagement;
using System.Collections;

public class GetQuestions : MonoBehaviour, ITrackableEventHandler
{
    public GameObject GM;
    private TrackableBehaviour mTrackableBehaviour;
    private GameMode controller;
   
    public void Start(){
        
        controller = GM.GetComponent<GameMode>();
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
          mTrackableBehaviour.RegisterTrackableEventHandler(this);

        }
    }

    void ITrackableEventHandler.OnTrackableStateChanged(
      TrackableBehaviour.Status previousStatus,
      TrackableBehaviour.Status newStatus)
    {
        
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            switch (mTrackableBehaviour.TrackableName)
            {
                case "EXTREME":
                    Debug.Log("extreme card");
                    controller.RandQuestion(2);
                    //controller.RandQuestion(2);
                    //SpinBtn.SetActive(true);
                    ///Need to generate question
                    //Application.LoadLevel("Main");
                    break;

                case "MEDIUM":
                    Debug.Log("medium card");
                    controller.RandQuestion(1);
                    //SpinBtn.SetActive(true);
                    ///Need to generate question
                    //Application.LoadLevel("Main");
                    break;

                case "BASIC":
                    Debug.Log("basic card");
                    controller.RandQuestion(0);
                    //SpinBtn.SetActive(true);
                    ///Need to generate question
                    //Application.LoadLevel("Main");
                    break;

                case "BoxArt":

                    ///Need to generate question
                    //Application.LoadLevel("Main");
                    break;


            }
        }
    }

}