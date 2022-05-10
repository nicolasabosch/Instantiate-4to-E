using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public Text txtUserCloneAmount;

    cloneAmount = int.Parse(txtUserCloneAmount.text);


    public void MultiInstantiate()
    {
        int counter = 0;
        while (counter < cloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
