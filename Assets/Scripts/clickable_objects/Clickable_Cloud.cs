using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable_Cloud : MonoBehaviour
{
    private void OnMouseDown()
    {
        Event_Manager.Send_Cloud_Click();
    }
}
