using System;


public static class Event_Manager
{
    public static Action On_Cloud_Click;

    public static void Send_Cloud_Click()
    {
        On_Cloud_Click?.Invoke();
    }
}
