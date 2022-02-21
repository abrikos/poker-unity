using UnityEngine;

public class PlayersInstantiation: MonoBehaviour
{
    public GameObject myPrefab;

    public Vector3 location;
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0));
        Debug.Log(stageDimensions);
        var parent = Instantiate(myPrefab, location, Quaternion.identity);
        parent.transform.localPosition = new Vector3(-stageDimensions.x, 0, 4);
        Debug.Log(myPrefab.transform.localScale);
        // parent.transform.localScale = myPrefab.transform.localScale;
        // parent.transform.SetParent(myPrefab.transform);
    }
}
