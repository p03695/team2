using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickNext : MonoBehaviour
{
    public Image []_UI_Charts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMouseUp()
    {
        _UI_Charts[2].gameObject.SetActive(true);
        _UI_Charts[1].gameObject.SetActive(true);
        _UI_Charts[0].gameObject.SetActive(false);
        _UI_Charts[3].gameObject.SetActive(false);

    }
}
