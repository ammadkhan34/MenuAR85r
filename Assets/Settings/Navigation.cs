using UnityEngine;

public class Navigation1 : MonoBehaviour
{
    GameObject ArCamera;
    public GameObject initialScreen;
    GameObject menuPanel;
    public GameObject imageTarget;
    public GameObject MenuScreen;
    public GameObject RestaurantPanel;
    public GameObject RestaurantScreen;

    public GameObject MenuPanel;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ArCamera = GameObject.FindGameObjectWithTag("ARCamera");
        menuPanel = GameObject.FindGameObjectWithTag("MenuPanel");
    }

    public void showARCamera() 
    {
        initialScreen.SetActive(false);
    //  ArCamera.SetActive(true);
      menuPanel.SetActive(false);
      imageTarget.SetActive(true);
     ArCamera.GetComponent<Camera>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void showMenu(int i) {
        RestaurantScreen.SetActive(false);
        MenuScreen.SetActive(true);
       MenuPanel.GetComponent<menu>().showItems(i);
    }


    public void showRestaurants() {
        initialScreen.SetActive(false);
        RestaurantScreen.SetActive(true);
    }
}
