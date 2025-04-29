using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


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

    public GameObject UI;

    Dictionary <string, int> mapStringToIndex;
    public GameObject[] dishes3DObjects;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mapStringToIndex = new Dictionary<string, int>();
        ArCamera = GameObject.FindGameObjectWithTag("ARCamera");
        menuPanel = GameObject.FindGameObjectWithTag("MenuPanel");
        mapStringToIndex.Add("cheese toastie", 0);
        mapStringToIndex.Add("Onion Pie", 1);
         mapStringToIndex.Add("lemon tart", 2);
        mapStringToIndex.Add("sticky toffee", 3);  
        mapStringToIndex.Add("scotch egg", 4);
        mapStringToIndex.Add("liver pate", 5);
          mapStringToIndex.Add("fish", 6);
        mapStringToIndex.Add("trout", 7);
    }

    public void showARCamera() 
    {
     initialScreen.SetActive(false);
      menuPanel.SetActive(false);
      ArCamera.GetComponent<TouchScript>().showSinglePageMenu = true;
      ArCamera.GetComponent<Camera>().enabled = true;
      imageTarget.SetActive(true);
      UI.SetActive(true);
    }

     public void showObjectInAR(string dishName) 
    {
     initialScreen.SetActive(false);
    menuPanel.SetActive(false);
    UI.SetActive(false);
    imageTarget.SetActive(true);
    dishes3DObjects[mapStringToIndex[dishName]].SetActive(true);
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

     public void showRestaurant() {
         MenuPanel.GetComponent<menu>().deleteItems();
        MenuScreen.SetActive(false);
        RestaurantScreen.SetActive(true);
    }


    public void showRestaurants() {
        initialScreen.SetActive(false);
        RestaurantScreen.SetActive(true);
    }
}
