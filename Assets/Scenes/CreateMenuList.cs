using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateMenuList : MonoBehaviour
{
    public Texture[] images;
    public string[] names;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject view1 = transform.GetChild(0).gameObject;
        GameObject g;
        for (int i = 0; i < images.Length ; i++) {
g = Instantiate(view1,transform);
g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = names[i];
g.transform.GetChild(1).GetComponent<RawImage>().texture = images[i];
g.GetComponent<Button>().onClick.AddListener(delegate(){
print("Item Clicked");
print(i);
itemClicked(i);
});
        }
       Destroy(view1); 
    }


void itemClicked(int name) {
    print(name);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
