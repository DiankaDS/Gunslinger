using System.Collections.Generic;
using UnityEngine;

public static class TargetManager
{
    private static List<Target> targets = new List<Target>();
    private static int currentTarget = -1;

    public static void SetTarget(Target target)
    {
        targets.Add(target);
    }

    public static Target GetTarget()
    {
        return targets[++currentTarget % targets.Count];
    }
}
