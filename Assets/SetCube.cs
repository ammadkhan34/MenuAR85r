using UnityEngine;

public class SetCube : MonoBehaviour
{
    public GameObject cube; // The original prefab/template
    private GameObject myCube; // The live clone

    void Start()
    {
        // Do not instantiate yet. Just keep the reference ready.
    }

    public void setCubeVisible()
    {
            Destroy(myCube);
            myCube = null;
            myCube = Instantiate(cube, transform);
            myCube.SetActive(true);
    }

    public void setCubeInVisible()
    {
        if (myCube != null)
        {
            Destroy(myCube);
            myCube = null;
        }
    }
}
