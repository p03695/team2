using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchClipboard : MonoBehaviour
{
    public Image _UI_ChartA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
    }

    private void OnMouseUp()
    {
        _UI_ChartA.gameObject.SetActive(true);

    }

}
