using HSVPicker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetColor : MonoBehaviour
{
  public GameObject colorpicker;
  public GameObject colorpickerPannel;
  public GameObject target;
  void Start()
  {
      Button btn=GetComponent<Button> ( );
      btn.onClick.AddListener (getColor);
  }
  void getColor()
  {
    Color  color = colorpicker.GetComponent<ColorPicker> ().CurrentColor ;
    Image targetColor = target.GetComponent<Image> ( );
    targetColor.color=color;
    colorpickerPannel.SetActive (false);
  }
}
