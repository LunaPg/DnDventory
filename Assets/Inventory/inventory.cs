using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using UnityEditor.PackageManager;
using UnityEngine;

public class inventory
{
  Save save = new Save ( );
  public List<GameObject> inventoryList = new List<GameObject> ( );

  public Save Create() {
    foreach ( GameObject inventoryItem in inventoryList )
    {
      insert(inventoryItem.GetComponent<items> ( ));
    }
    return save;
  }

  public void add(items item){
    save.inventoryItems.Add (item);
  }

   public int findIndex(items item)
  {
    int index = save.inventoryItems.IndexOf (item);
    if ( index<0 )
    {
      throw new Exception ("404 : Item not found !");
    }
    return index;
  }

  public void insert(items item) {
    try
    {
      findIndex (item);
    }
    catch {
      insert (item);
    }
  }

  public void modify(items item) {
    try
    {
     int index =  findIndex (item);
      save.inventoryItems [ index ] = item;
    }
    catch(Exception e)
    {
      throw e;
    }
  }

  public void delete(items item)
  {
    try
    {
      int index = findIndex (item);
      save.inventoryItems.Remove (item);
    }
    catch ( Exception e )
    {
      throw e;
    }
  }

}
