using UnityEngine;
using System.Collections;

public class Parallaxing : MonoBehaviour {

	public Transform[] backgrounds;		//array (list) of all back- and forgrounds to be parallaxed
	public float[] parallaxScales;	//the proportion of the camera's movement to move the backgrounds by
	public float smoothing = 1f;	//how smooth the parallax is going to be, Must be above 0 otherwize the parallax will not work
    Matrix4x4 baseMatrix = Matrix4x4.identity;
	private Transform cam;	//reference to the camera's transform
    public bool IsMoving = true;
	//called before Start(), using to assign references.
	void Awake() {
		//set up camera the reference
		cam = Camera.main.transform;
	}

	// Use this for initialization
	void Start () {


		//declares the length of the array
		parallaxScales = new float[backgrounds.Length];

		//assigning coresponding parallaxScales
		for (int i = 0; i < backgrounds.Length; i++) {
			parallaxScales[i] = backgrounds[i].position.z * -1;
		}
	}

	// Update is called once per frame
	void Update() {

		//for each background
            for (int i = 0; i < backgrounds.Length; i++) {
             
                //the parallax is the opposite of the camera movement because the previous frame multiplied by the scale
                float parallax = (AdjustedAccelerometer.y * 0.05f - cam.position.y) * parallaxScales[i];

                //set a target y position that is the current position plus the parallax
                float backgroundTargetPosY = backgrounds[i].position.y + parallax;

                //create a target position which is the backgrounds current position with it's target x position
                Vector3 backgroundTargetPos = new Vector3(backgrounds[i].position.x, backgroundTargetPosY, backgrounds[i].position.z);

                //fade batween current position and the target position using lerp
                backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        } 
		
	}

   

    public void Calibrate()
    {
        Quaternion rotate = Quaternion.FromToRotation(new Vector3(0.0f, 0.0f, -1.0f), Input.acceleration);

        Matrix4x4 matrix = Matrix4x4.TRS(Vector3.zero, rotate, new Vector3(1.0f, 1.0f, 1.0f));

        this.baseMatrix = matrix.inverse;
    }

    public Vector3 AdjustedAccelerometer
    {
        get
        {
            return this.baseMatrix.MultiplyVector(Input.acceleration);
        }
    }
}
