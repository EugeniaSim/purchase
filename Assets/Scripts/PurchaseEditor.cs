using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Shop))]
public class PurchaseEditor : Editor
{
    public List<Purchase> allProducts = new List<Purchase>();

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
        var product = CreateInstance<Purchase>();
        product.currency = Target.currency;
        product.productName = Target.productName;
        product.price = Target.price;
        product.salePricel = Target.salePricel;
        product.isOnSale = Target.isOnSale;
        product.pictureId = Target.pictureId;
        allProducts.Add(product);
        product.name = Target.productName;
        AssetDatabase.AddObjectToAsset(product, Target);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log(allProducts.Count);

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
        if (allProducts.Count <= 0)
        {
            return;
        }
        var temp = allProducts[allProducts.Count - 1];
        allProducts.RemoveAt(allProducts.Count - 1);
        DestroyImmediate(temp, true);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

}
