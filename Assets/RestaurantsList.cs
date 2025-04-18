using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RestaurantsList : MonoBehaviour
{
    GameObject buttonTemplate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
buttonTemplate = transform.GetChild(0).gameObject;
for (int i = 0 ; i < 10; i++) {
    GameObject g = Instantiate(buttonTemplate,transform);
    g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "" + i;
    int index = i;
    g.GetComponent <Button>().onClick.AddListener(delegate{buttonPressed(index);});
}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void buttonPressed(int i ){
        GameObject naviagtion = GameObject.FindGameObjectWithTag("Navigation");
        naviagtion.GetComponent<Navigation1>().showMenu(i);
        print(i);
    }
}
