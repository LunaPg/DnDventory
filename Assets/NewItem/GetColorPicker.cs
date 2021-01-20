using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetColorPicker : MonoBehaviour
{
  public GameObject colorpicker;
  public Button btn;
    void Start()
    {
      if ( btn == null )
      {
        btn=GetComponent<Button> ( );
        btn.onClick.AddListener (DisplayColorPicker);
    }
  }

    // Update is called once per frame
    void Update()
    {
        
    }

  void DisplayColorPicker() {
    colorpicker.SetActive (true);
  }

}
