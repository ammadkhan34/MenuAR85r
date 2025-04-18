using UnityEngine;

public class RestaurantsList : MonoBehaviour
{
    GameObject buttonTemplate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
buttonTemplate = transform.GetChild(0).gameObject;
for (int i = 0 ; i < 50; i++) {
    GameObject g = Instantiate(buttonTemplate,transform);
}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
