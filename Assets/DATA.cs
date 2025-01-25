using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DATA
{
    public static int level = 0;
    public static bool once;

    public static bool Trophy1;
    public static bool Trophy2;
    public static bool Trophy3;
    public static bool Trophy4;
    public static bool Trophy5;

    public static void set_once()
    {
        level = 5;

        Trophy1 = false;
        Trophy2 = false;
        Trophy3 = false;
        Trophy4 = false;
        Trophy5 = false;
        once=true;
    }
}
