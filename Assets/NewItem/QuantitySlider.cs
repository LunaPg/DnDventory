using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuantitySlider : MonoBehaviour
{
  InputField quantity;
  Slider slider;
  // Start is called before the first frame update
  void Start()
  {
    slider=this.GetComponentInChildren<Slider> ( );
    quantity=this.GetComponentInChildren<InputField> ( );
    slider.onValueChanged.AddListener (delegate { updateQuantity ( ); });
    quantity.onValueChanged.AddListener(delegate { updateSlider ( ); });

    if ( quantity.text!="" )
    {
      slider.value =Int32.Parse (quantity.text);
    }
  }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateQuantity()
    {
      quantity.text=slider.value.ToString();
    }

  void updateSlider()
  {
    slider.value=Int32.Parse (quantity.text);
  }
}

