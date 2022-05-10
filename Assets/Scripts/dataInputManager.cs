using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataInputManager : MonoBehaviour
{
    public Text txtUsrName;
    
    public void ShowGreetings()
    {
        Debug.Log ("Hola" + txtUsrName.text);
    }
}
