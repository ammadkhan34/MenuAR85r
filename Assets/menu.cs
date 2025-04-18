using UnityEngine;
using TMPro;

public class menu : MonoBehaviour
{
    GameObject refrenceForButtons;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      

        
    }


    public void showItems(int size ) {
  GameObject buttonTemplate = transform.GetChild(0).gameObject;

        for (int i = 0 ;i < size; i++){
            refrenceForButtons = Instantiate(buttonTemplate,transform);
            refrenceForButtons.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "" + i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
