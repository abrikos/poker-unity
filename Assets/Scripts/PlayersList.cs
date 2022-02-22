using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayersList: MonoBehaviour
{
    public GameObject myPrefab;

    void Start()
    {
        Round();
    }

    private void AddPlayer(int i, float angle)
    {
        var loc = new Vector3(Mathf.Sin(angle)*Screen.width / 3f, Mathf.Cos(angle)*Screen.height / 3f, 0);
        // Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0));
        // Debug.Log(stageDimensions);
        var parent = Instantiate(myPrefab, loc, Quaternion.identity);
        parent.SetActive(true);
        parent.transform.SetParent (GameObject.Find("Canvas").transform, false);
        parent.name = "Player" + i;
        //parent.transform.localPosition = new Vector3(-stageDimensions.x, 0, 4);
        //parent.transform.localScale = new Vector3(0.01f,0.01f,1);
        var player = parent.transform;
        player.Find("PlayerCard1").GetComponent<SpriteRenderer>().sortingOrder = 2;
        player.Find("PlayerCard2").GetComponent<SpriteRenderer>().sortingOrder = 2;
        var text =player.Find("PlayerText").GetComponent<TMPro.TextMeshProUGUI>();
        text.text = "Screen.width.ToString()";
        // text.sortingOrder = 2;

    }

    private void Round()
    {
        const int count = 6;
        for (var i = 1; i < count + 1; i++)
        {
            var angle = i * Mathf.PI*2f / count;
            AddPlayer(i, angle);
        }
    }
}
