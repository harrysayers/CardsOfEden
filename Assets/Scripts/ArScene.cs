using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;
using System.Collections;
 
public class ArScene : MonoBehaviour, ITrackableEventHandler
{
    //public GameObject CanRotateBtn;
    private TrackableBehaviour mTrackableBehaviour;
    public GameObject SpinBtn;
    private SpinBottle BoolControl;

    void Start()
    {
       // BoolControl = CanRotateBtn.GetComponent<SpinBottle>();
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            
            mTrackableBehaviour.RegisterTrackableEventHandler(this);

        }

           SpinBtn.SetActive(false);
   
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            switch (mTrackableBehaviour.TrackableName)
            {
             
                case "BoxArt":
                    SpinBtn.SetActive(true);
                    break;

            }
        } else{
            
            OnTrackingLost();
        }
    }


    public void OnTrackingLost(){
      //  SpinBtn.SetActive(false);
        //BoolControl.canRotate = false;

    }

}