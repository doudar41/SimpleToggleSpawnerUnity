# Simple Toggle Spawner Menu


This is a simple approach to build a spawnable toggle menu in Unity. 

ToggleHolder - script attached to toggle prefab (should has Toggle script attached)

GetToggleIndex - script which spawn toggle prefabs according to amount of sprites in a collecion of toggle sprites

SpritesStorage - scriptable object script which has two Lists of sprites for background and checked images of a toggle

IndexOfToggleToImage - example script which using index from toggle to show a chosen image

You can change toggles to buttons or images by changing ToggleHolder script. 
Or modify this script to use it without spawning by not using Spawer function in GetToggleIndex, adding manually GetToggleIndex to toggles. 

Thanks Kenney​ for amasing assets. ​​​
