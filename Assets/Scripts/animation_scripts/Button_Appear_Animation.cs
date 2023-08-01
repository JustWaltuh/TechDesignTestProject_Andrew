using UnityEngine;

public class Button_Appear_Animation : MonoBehaviour
{
   [SerializeField] private GameObject button;

    private void Start()
    {
      Event_Manager.On_Hero_Click += Enable_Button;
    }

    private void Enable_Button()
    {
        button.SetActive(true);
    }


    private void OnDestroy()
    {
        Event_Manager.On_Hero_Click -= Enable_Button;
    }
}
