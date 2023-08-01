using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable_Hero : MonoBehaviour
{
    private void OnMouseDown()
    {
        Event_Manager.Send_Hero_Click();
    }
}
