# About
Create a simple animation from a Sprite array list.

# Install
Download this source code and drag it into the folder containing your project.

# How to use?

````
AnimationScript animation = gameObject.AddComponent<AnimationScript>();
animation.CreateClip("NameClip",LISTSPRITE, SPEED?, LOOP?);
animation.AddClip("NameClip");
animation.Play("NameClip");
````

A Gameobject can contain many Clips.
You can use :
````
 animation.Play(Name_Clip);
````

# Method

````
// Play from index
animation.Play(Name_Clip, INDEX)
animation.isPlay; // => true or false
animation.namePlay; => name Clip are playing
animaton.speed => time a frame


````

1. Listen event on start
   
   Every time we restart to the 0th frame, this event will be called.
   ````
     animation.OnStart(() => {
      Debug.Log("Animation start");
    });
   ````
2. Listen event on Change Frame
   
   Every time to the change frame, this event will be called.
   ````
     animation.OnChangeFrame((short i) => {
      Debug.Log("Animation change i="+i);
    });
   ````

3. Listen event on Finish
   
   Active where is loop = false.
   ````
     animation.OnFinish((short i) => {
      Debug.Log("Animation finish i="+i);
    });
   ````


# Write
@int04
Thank for see !
