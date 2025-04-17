using UnityEngine;

public class Navigation : MonoBehaviour
{ GameObject mainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("ARCamera");
        mainCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
