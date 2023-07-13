using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    public void Interact()
    {
        Debug.Log("Interact");
        //Instantiate a tomato prefab on the counterTopPoint position
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        //Set tomato local position to zero, to make sure that the tomato will spawn in the exactly zero point of the counterTopPoint.
        kitchenObjectTransform.localPosition = Vector3.zero;

        kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO();
        Debug.Log(kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
