using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RestaurantsList : MonoBehaviour
{
    GameObject buttonTemplate;

    string[] restaurantsList = {"Hero Restaurant","Meghan's","Diner Inn","Eat my way"};
    public int numberOfRestaurants = 0;

    string[] restaurantNames = {"Hero","Meghan","nawab",""};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {  }

public void showRestaurantList() {
buttonTemplate = transform.GetChild(0).gameObject;
print(restaurantsList.Length);
numberOfRestaurants = restaurantsList.Length-1;
for (int i = 0 ; i < restaurantsList.Length; i++) {
    GameObject g = Instantiate(buttonTemplate,transform);
    int index = i;
    g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "" + restaurantsList[i];
    g.transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load<Texture2D>("" + restaurantNames[index]);
    
    g.GetComponent <Button>().onClick.AddListener(delegate{buttonPressed(index);});
} 
Destroy(buttonTemplate);
}

public void deleteItems() {
      for (int i = 0;i < numberOfRestaurants; i++) {
GameObject buttonTemplate = transform.GetChild(i).gameObject;
Destroy(buttonTemplate);
        }
}
    void buttonPressed(int i ) {
        GameObject naviagtion = GameObject.FindGameObjectWithTag("Navigation");
        naviagtion.GetComponent<Navigation1>().showMenu(i);
        print(i);
    }
}
