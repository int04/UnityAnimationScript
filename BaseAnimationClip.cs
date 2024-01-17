using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAnimationClip : MonoBehaviour
{
    private List<string> _listClip = new List<string>(); // danh sách clip của đối tượng

    public void CreateClip(string nameClip, List<Sprite> sprites, float speed = 0.1f, bool loop = true)
    {
        AnimationClipScript.Create(nameClip, sprites, speed, loop);
    }

    public void AddClip(string nameCLip)
    {
        _listClip.Add(nameCLip);
    }
    protected float TimeClip = 0; // thời gian hiện tại của clip

    public bool isPlay = false; // trạng thái đang play hay không
    public bool loop = false; // trạng thái lặp hay không
    public string namePlay = ""; // tên clip đang play
    public float speed = 0.1f; // tốc độ play
    protected short Index = 0; // vị trí hiện tại của clip
    protected List<Sprite> Frame = new List<Sprite>(); // danh sách sprite của clip
    public int sum = 0; // số lần đã lặp

    public void Play(string nameClip, short indexStart = -1)
    {
        TimeClip = 0;
        sum = 0;
        if (nameClip == namePlay)
        {
            if(indexStart != -1) Index = (short) indexStart;
            else Index = 0;
            isPlay = true;
            return;
        }

        if (!_listClip.Contains(nameClip)) return;
        if(!AnimationClipScript.Data.ContainsKey(nameClip)) return;
        AnimationClipScriptClass clipData = AnimationClipScript.Data[nameClip];
        Frame = clipData.sprites;
        speed = clipData.speed;
        loop = clipData.loop;
        namePlay = nameClip;
        if(indexStart != -1) Index = (short) indexStart;
        else Index = 0;
        isPlay = true;
    }


}