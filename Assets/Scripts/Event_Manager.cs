using System;


public static class Event_Manager
{
    public static Action On_Hero_Click;

    public static void Send_Hero_Click()
    {
        On_Hero_Click?.Invoke();
    }
}
