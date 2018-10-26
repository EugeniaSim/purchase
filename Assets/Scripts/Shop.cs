using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewProduct", menuName = "AddNewProduct", order = 5)]
public class Shop : ScriptableObject {

    public int price, salePricel, pictureId;
    public string currency, productName;
    public bool isOnSale;

}
