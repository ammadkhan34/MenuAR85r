using UnityEngine;

public class GoToAR : MonoBehaviour
{
    GameObject ArCamera;
    GameObject menuPanel;
    public GameObject imageTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ArCamera = GameObject.FindGameObjectWithTag("ARCamera");
        menuPanel = GameObject.FindGameObjectWithTag("MenuPanel");
    }

    public void showARCamera() 
    {
    //  ArCamera.SetActive(true);
      menuPanel.SetActive(false);
      imageTarget.SetActive(true);
           ArCamera.GetComponent<Camera>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
