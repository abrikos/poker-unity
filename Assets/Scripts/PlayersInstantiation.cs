using UnityEngine;

public class PlayersInstantiation: MonoBehaviour
{
    public GameObject myPrefab;

    public Vector3 location;
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        var originalScale = myPrefab.transform.localScale;
        var parent = Instantiate(myPrefab, location, Quaternion.identity);
        parent.transform.localPosition = new Vector3(4, 4, 4);
        parent.transform.localScale = new Vector3(1, 1, 1);
        // parent.transform.SetParent(myPrefab.transform);
    }
}
