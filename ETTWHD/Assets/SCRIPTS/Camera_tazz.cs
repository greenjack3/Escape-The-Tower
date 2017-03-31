using UnityEngine;
using System.Collections;

//[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class Camera_tazz : MonoBehaviour {

    public static Camera_tazz instance = null;
	public Transform target;
	public GameObject player;
	public float distance = 5.0f;
	public float xSpeed = 120.0f;
	public float ySpeed = 120.0f;

	public float yMinLimit = -20f;
	public float yMaxLimit = 80f;

	public float distanceMin = .5f;
	public float distanceMax = 15f;

	private Rigidbody rigidbody;
	public float MaxZoom;
	public float MinZoom;
	public float MouseWheel;


	public Camera MainCam;

	float x = 0.0f;
	float y = 0.0f;

    // Use this for initialization
    public void Awake()
    {
        if (instance == null)

            instance = this;

        else if (instance != this)


            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void Start () 


	{
		Vector3 angles = transform.eulerAngles;
		x = angles.y;
		y = angles.x;

		rigidbody = GetComponent<Rigidbody>();
		player = GameObject.FindGameObjectWithTag("Player");
		target = player.transform;



		// Make the rigid body not change rotation
		if (rigidbody != null)
		{
			rigidbody.freezeRotation = true;
		}
	}


	void Update () 
	{
		if (target) 
		{


			x += Input.GetAxis("Vertical") * xSpeed * distance * 0.02f;
			y -= Input.GetAxis("Horizontal") * ySpeed * 0.02f;


			y = ClampAngle(y, yMinLimit, yMaxLimit);

			Quaternion rotation = Quaternion.Euler(x, y, 0);

		  //mouse = Input.GetAxis ("MouseScrollWheel");

			distance = Mathf.Clamp(distance, distanceMin, distanceMax);

			RaycastHit hit;
			if (Physics.Linecast (target.transform.position, transform.position, out hit)) 
			{
				distance -=  hit.distance;
			}
			Vector3 negDistance = new Vector3(0f, 0f, -distance);
			Vector3 position = rotation * negDistance + target.position;

			transform.rotation = rotation;
			transform.position = position;




		}

	
	
	}


	public static float ClampAngle (float angle, float min, float max)
	{
		if (angle < -360F)
			angle += 360F;
		if (angle > 360F)
			angle -= 360F;
		return Mathf.Clamp(angle, min, max);
	}






void LateUpdate ()
	{

		MouseWheel = Input.GetAxis ("Mouse ScrollWheel");

		if (Input.GetAxis ("Mouse ScrollWheel") < 0f) { // forward
			if (MainCam.orthographicSize <= MaxZoom) {
				MainCam.orthographicSize++;
			}
		} 
		if (Input.GetAxis ("Mouse ScrollWheel") > 0f) { // backwards
			if (MainCam.orthographicSize >= MinZoom) {
				MainCam.orthographicSize--;
			}
		}

	}

}

