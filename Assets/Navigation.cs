using UnityEngine;

public class Navigation : MonoBehaviour
{
     GameObject ArCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     ArCamera = GameObject.FindGameObjectWithTag("ARCamera");
     ArCamera.GetComponent<Camera>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}