using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
// My idea is to attach this to AR Camera 
// all image Targets with their canvases will be attached to camera , for exmaple if we have 5 resturants so 5 image atrgets will be observed
//If we get a target we will be returned a Tag from rawimage (menu ) from that target 
//Based on that target we will load models and indexes required 
public class TouchScript : MonoBehaviour
{ 
//Models to be got from Class Object
    private GameObject[] models;
    private int[] Constrains;
    //This is preBuilt
    public GameObject UI;
    // Every time we update object we need to remoce previous one in order for next one to be shown 
    private GameObject lastObject;
    public static int count = 0;



     void Start() { 
        // Initializing an empty Object
        lastObject = new GameObject();
    }
    void Update()
    {
        //This gives details about touch like where touch has  happend
        PointerEventData pointer = new PointerEventData(EventSystem.current);
        //This gives details of all touches like what has been touched 
        List<RaycastResult> raycastResult = new List<RaycastResult>();

        foreach (Touch touch in Input.touches)
        {
            if(touch.phase.Equals(TouchPhase.Began))
            {
                pointer.position = touch.position;
//          if my ui is not visible
            if (UI.activeSelf == false) {
                    lastObject.SetActive(false);
                    UI.SetActive(true);
                    return;
                }

                EventSystem.current.RaycastAll(pointer, raycastResult);
                
                foreach(RaycastResult result in raycastResult)
                { 
                                     // get object of menu type being touched 
                                      var myObject = GameObject.FindWithTag(result.gameObject.tag)?.GetComponent<returnMenu>();
                                      //Assign details 
                                      models = myObject?.models;
                                      Constrains = myObject?.listOfIndexes;
                                      count = count + 1;
                                if (count > 300) {

                                    var i = 0;
                                    //Loop until we find section pressed 
                                      while (touch.position.y < Constrains[i] && i < 5) {
                                             i = i + 1;
                                            }
                                            //Remove ui , last object and set new object 
                                            UI.SetActive(false);
                                            lastObject.SetActive(false);
                                            models[i].SetActive(true);
                                            lastObject = models[i];

                }

                }
                //Clear all details of ray cast
                raycastResult.Clear();
            }       
        }
    }
}
