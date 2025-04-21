using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class menu : MonoBehaviour
{
    string[][] dishNames = new string [][] { new string[] {"cheese toastie","Onion Pie"},
    new string[] {"lemon tart","sticky toffee"},
    new string[] {"scoth egg","liver pate"},
    new string[] {"fish","trout"} }; 
    GameObject refrenceForButtons;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      

        
    }


    public void showItems(int size1 ) {
  GameObject buttonTemplate = transform.GetChild(0).gameObject;
  int length1 = dishNames[size1].Length;
  print("length is");
  print(length1);
        for (int i = 0 ;i < length1; i++) { 
            refrenceForButtons = Instantiate(buttonTemplate,transform);
            refrenceForButtons.transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load<Texture2D>("" + dishNames[size1][i]);
            refrenceForButtons.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "" + dishNames[size1][i];
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
