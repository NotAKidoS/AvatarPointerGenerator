# AvatarPointerGenerator

A tool to automatically generate default pointers for humanoid ChilloutVR avatars.

The tool can be found under `Tools/Avatar Pointer Generator`.

- Currently will generate Head, Hand, and Feet colliders for humanoid avatars.
- Colliders are sized to match your avatar as best as possible.
- Support for Unity undo system. 

The tool follows the naming scheme for [HumanBodyBones](https://docs.unity3d.com/ScriptReference/HumanBodyBones.html) in Unity.

Current Types:
- Head
- LeftHand
- RightHand
- LeftFoot
- RightFoot

Planned Types:
- Chest
- Index, Middle, Ring, Little fingers

Planned Functionality:
- Easy collider tweaking via sliders
- Transform gizmos and highlighting
- Switch collider types to CapsuleCollider

---

Note on Generic Pointers:

The Trigger and Pointer system in ChilloutVR uses collision callbacks to detect when two colliders interact. 

When a collider enters a trigger, the trigger will check if the collider gameobject has a CVRPointer component. If it does, the trigger will check the type to see if it is allowed.

However, triggers do not check for multiple pointer components- it will always return the first one found. This means that to add a generic pointer, a new game object, pointer, and collider would need to be added to the avatar. 

This would be more complex than simply having the trigger look for both Left and Right variants.
