using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    private Tweener tweener;

    private List<GameObject> itemList;

    // Start is called before the first frame update
    void Start()
    {
        this.tweener = this.GetComponent<Tweener>();
        this.itemList = new List<GameObject>();
        this.itemList.Add(this.item);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //tweener.AddTween(item.transform, item.transform.position, new Vector3(-2.0f, 0.5f, 0.0f), 1.5f);
            this.AddTweens("a");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //tweener.AddTween(item.transform, item.transform.position, new Vector3(2.0f, 0.5f, 0.0f), 1.5f);
            this.AddTweens("d");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //tweener.AddTween(item.transform, item.transform.position, new Vector3(0.0f, 0.5f, -2.0f), 0.5f);
            this.AddTweens("s");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //tweener.AddTween(item.transform, item.transform.position, new Vector3(0.0f, 0.5f, 2.0f), 0.5f);
            this.AddTweens("w");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            this.itemList.Add(Object.Instantiate<GameObject>(this.item, item.transform.position, Quaternion.identity));
        }
      
    }

    private void AddTweens(string gameKey)
    {
        bool flag = false;

        for (int i = 0; i < itemList.Count; i++)
        {
            if (gameKey == "a")
            {
                flag = this.tweener.AddTween(itemList[i].transform, itemList[i].transform.position, new Vector3(-2f, 0.5f, 0.0f), 1.5f);
            }
            else if (gameKey == "d")
            {
                flag = this.tweener.AddTween(itemList[i].transform, itemList[i].transform.position, new Vector3(2f, 0.5f, 0.0f), 1.5f);
            }
            else if (gameKey == "s")
            {
                flag = this.tweener.AddTween(itemList[i].transform, itemList[i].transform.position, new Vector3(0.0f, 0.5f, -2f), 0.5f);
            }
            else if (gameKey == "w")
            {
                flag = this.tweener.AddTween(itemList[i].transform, itemList[i].transform.position, new Vector3(0.0f, 0.5f, 2f), 0.5f);
            }
            else if (flag)
                break;
        }
    }
}
