using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float_Animation : MonoBehaviour
{
    [SerializeField] private float animation_speed;
    [SerializeField] private float max_y_position;

    private bool going_up = true;


    void Start()
    {
    //    Check_For_Direction();
    }

    private void Check_For_Direction()
    {
        if (going_up == true)
            Do_Floating(1);
        else
            Do_Floating(-1);
         
    }

   private void Do_Floating(int modifier)
    {
        Vector2 moving_point = new Vector2(transform.position.x, max_y_position * modifier);

        Vector2.Lerp(transform.position, moving_point, animation_speed);

        going_up = !going_up;

        Check_For_Direction();
    }
}
