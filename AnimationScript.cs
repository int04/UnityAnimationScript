using System;
using JetBrains.Annotations;
using UnityEngine;

public class AnimationScript : BaseAnimationClip
{
    public delegate void Int04CallBackFrameWork(short msg =0);
    public event Int04CallBackFrameWork OnStartCallBack;
    public event Int04CallBackFrameWork OnChangeFrameCallBack;
    public event Int04CallBackFrameWork OnFinishCallBack;

    public void OnStart(Action<short> callback)
    {
        OnStartCallBack += (msg) => callback(msg);
    }
    public void OnStart(Action callback)
    {
        OnStartCallBack += (msg) => callback();
    }

    public void OnChangeFrame(Action<short> callback)
    {
        OnChangeFrameCallBack += (msg) => callback(msg);
    }
    public void OnChangeFrame(Action callback)
    {
        OnChangeFrameCallBack += (msg) => callback();
    }
    public void OnFinish(Action<short> callback)
    {
        OnFinishCallBack += (msg) => callback(msg);
    }
    public void OnFinish(Action callback)
    {
        OnFinishCallBack += (msg) => callback();
    }



    void Update()
    {
        if(isPlay == false) return;
        if (Frame.Count == 0) return;
        TimeClip += Time.deltaTime;
        if(TimeClip < speed) return;
        TimeClip = 0;
        if(Index >= Frame.Count)
        {
            if (loop)
            {
                Index = 0;
                sum++;
                OnStartCallBack?.Invoke(Index);
            }
            else
            {
                isPlay = false;
                OnFinishCallBack?.Invoke(Index);
                return;
            }
        }
        GetComponent<SpriteRenderer>().sprite = Frame[Index];
        Index++;
        OnChangeFrameCallBack?.Invoke(Index);

    }
}