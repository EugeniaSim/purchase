using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Shop))]
public class PurchaseEditor : Editor
{
    public Shop Target {

        get { return target as Shop; }
    }


     public  override void OnInspectorGUI() {
        base.OnInspectorGUI();
        
         if (GUILayout.Button("Add")) {
            AddProduct();
            Clear();
          }

        if (GUILayout.Button("remove")) {

            Remove();
        }
      }


    void AddProduct()
    {
        Purchase product = new Purchase();
        product.currency = Target.currency;
        product.productName = Target.productName;
        product.price = Target.price;
        product.salePricel = Target.salePricel;
        product.isOnSale = Target.isOnSale;
        product.pictureId = Target.pictureId;
        Target.all.Add(product);
        //product.name = Target.productName;
        //AssetDatabase.AddObjectToAsset(product, Target);
        //AssetDatabase.SaveAssets();
        //AssetDatabase.Refresh();
        Debug.Log(Target.all.Count);
        
        
    }


    void Clear() {
        Target.currency = null;
        Target.productName = null;
        Target.salePricel = 0;
        Target.pictureId = 0;
        Target.price = 0;
        Target.isOnSale = false;
    }

    void Remove() {
        if (Target.all.Count <= 0)
        {
            return;
        }
        var temp = Target.all[Target.all.Count - 1];
        Target.all.RemoveAt(Target.all.Count - 1);
        DestroyImmediate(temp, true);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log(Target.all.Count);
    }

}
