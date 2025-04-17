using UnityEngine;

public class liverPateScript : MonoBehaviour
{
    public GameObject liverPateModel;
    public GameObject arCamera;
    public GameObject imageTarget; 
    private bool hasPlaced = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // print("hi");
        // Debug.Log("gi");
    }

    // Update is called once per frame
    void Update()
    {
       // if (!hasPlaced && imageTarget.activeInHierarchy)
   //      {
 // PlaceModelOnce();
     //    }
    }
public void removeImageTarget() {
 //   imageTarget.SetActive(false);
   // liverPateModel.SetActive(true);
}

     void toastieStuck() {
      //  Debug.Log("Toastie Stuck");
        //Destroy(liverPateModel);
        //hasPlaced = false;
    }

    // public void showLiverPate() {
    //     print("Hey");
    //     print(liverPateModel);
    //     Debug.Log(liverPateModel);
    //     hasPlaced = true;
    //     if (liverPateModel.activeSelf == false) {
    //      Debug.Log("It should be once only");   
    //     liverPateModel.SetActive(true);
    //     liverPateModel.transform.position = arCamera.transform.position + liverPateModel.transform.forward;
    // }
    // }

    //     private void PlaceModelOnce()
    // {
    //     hasPlaced = true;

    //     // Set model active and position it exactly where image target is
    //     liverPateModel.SetActive(true);
    //     liverPateModel.transform.position = imageTarget.transform.position;
    //     liverPateModel.transform.rotation = imageTarget.transform.rotation;

    //     // Unparent the model so it stays in world space
    //     liverPateModel.transform.parent = null;

    //     Debug.Log("Model placed in world space and detached from image target");
    // }
}




// public class LiverPateScript : MonoBehaviour
// {
//     public GameObject liverPateModel;
//     public GameObject imageTarget;
//     private bool hasPlaced = false;

//     void Update()
//     {
//         // Place the model only once when the image target is tracked
//         if (!hasPlaced && imageTarget.activeInHierarchy)
//         {
//             PlaceModelOnce();
//         }
//     }

//     private void PlaceModelOnce()
//     {
//         hasPlaced = true;

//         // Set model active and position it exactly where image target is
//         liverPateModel.SetActive(true);
//         liverPateModel.transform.position = imageTarget.transform.position;
//         liverPateModel.transform.rotation = imageTarget.transform.rotation;

//         // Unparent the model so it stays in world space
//         liverPateModel.transform.parent = null;

//         Debug.Log("Model placed in world space and detached from image target");
//     }
// }

