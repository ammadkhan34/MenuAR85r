using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class menu : MonoBehaviour
{
    string[,] dishNames = {{"cheese toastie","Onion Pie"},{"lemon tart","summer jelly"},{"scoth egg","liver pate"},{"fish","trout"}}; 
    GameObject refrenceForButtons;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      

        
    }


    public void showItems(int size1 ) {
  GameObject buttonTemplate = transform.GetChild(0).gameObject;
  int length1 = dishNames.GetLength(size1);
        for (int i = 0 ;i < length1-1; i++) { 
            refrenceForButtons = Instantiate(buttonTemplate,transform);
            refrenceForButtons.transform.GetChild(1).GetComponent<RawImage>().texture = Resources.Load<Texture2D>("cods cheeks");
            refrenceForButtons.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "" + dishNames[size1,i];
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
