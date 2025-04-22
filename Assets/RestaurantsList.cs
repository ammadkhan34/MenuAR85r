using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RestaurantsList : MonoBehaviour
{
    GameObject buttonTemplate;

    string[] restaurantsList = {"Hero Restaurant","Meghan's","Diner Inn","Eat my way"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
buttonTemplate = transform.GetChild(0).gameObject;
for (int i = 0 ; i < restaurantsList.Length; i++) {
    GameObject g = Instantiate(buttonTemplate,transform);
    g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "" + restaurantsList[i];
    int index = i;
    g.GetComponent <Button>().onClick.AddListener(delegate{buttonPressed(index);});
} 
Destroy(buttonTemplate);
    }

    // Update is called once per frame
    void Update()
    {  }

    void buttonPressed(int i ) {
        GameObject naviagtion = GameObject.FindGameObjectWithTag("Navigation");
        naviagtion.GetComponent<Navigation1>().showMenu(i);
        print(i);
    }
}
