using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Scene_Management : MonoBehaviour
{
    [SerializeField] private int scene_index; 

    public void Change_Scene()
    {
        StartCoroutine(Change_Scene_After_Some_Time());
    }

    private IEnumerator Change_Scene_After_Some_Time()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(scene_index);
    }
}
