using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveItem : MonoBehaviour
{
    public GameObject[] items;
    public Sprite[] ItemSprites;
    public int itemToGive;
    // Use this for initialization
    public void giveItem(int itemNumber)
    {
        items[itemNumber].SetActive(true);
        items[itemNumber].transform.GetChild(0).gameObject.GetComponent<Image>().sprite = ItemSprites[itemNumber];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider == gameObject.GetComponent<Collider2D>())
            {

                giveItem(itemToGive);
            }
        }
    }
}
