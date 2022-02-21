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
        parent.transform.localPosition = new Vector3(-10, 2.5f, 4);
        parent.transform.localScale = new Vector3(1, 1, 1);
        // parent.transform.SetParent(myPrefab.transform);
    }
}
