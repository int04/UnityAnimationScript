

using System.Collections.Generic;
using UnityEngine;

public class AnimationClipScriptClass
{
    public string name;
    public float speed;
    public bool loop = true;
    public List<Sprite> sprites = new List<Sprite>();
}

public static class AnimationClipScript
{
    public static Dictionary<string, AnimationClipScriptClass> Data = new Dictionary<string, AnimationClipScriptClass>();

    public static void Create(string name, List<Sprite> sprites, float speed = 0.1f, bool loop = true)
    {
        // check name exist
        if (Data.ContainsKey(name))
        {
            return;
        }
        AnimationClipScriptClass animationClipScriptClass = new AnimationClipScriptClass();
        animationClipScriptClass.name = name;
        animationClipScriptClass.speed = speed;
        animationClipScriptClass.loop = loop;
        animationClipScriptClass.sprites = sprites;
        Data.Add(name, animationClipScriptClass);
    }
}