using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour
{
    [Header("Camera List")]
    //public GameObject Cam1;
    //public GameObject Cam2;
    //public GameObject Cam3;
    //public GameObject Cam4;
    //public GameObject Cam5;
    //public GameObject Cam6;
    //public GameObject Cam7;
    //public GameObject Cam8;
    public List<GameObject> cameras;

    private int currentCameraIndex = 8;

    void Start()
    {
        // Ensure only the first camera is active at the start
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(i == currentCameraIndex);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ToggleCamera(1);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ToggleCamera(-1);
        }
    }

    void ToggleCamera(int direction)
    {
        // Deactivate the current camera
        cameras[currentCameraIndex].SetActive(false);

        // Calculate the new camera index
        currentCameraIndex = (currentCameraIndex + direction + cameras.Count) % cameras.Count;

        // Activate the new camera
        cameras[currentCameraIndex].SetActive(true);
    }
}
