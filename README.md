# AvatarPointerGenerator

A tool to automatically generate default pointers for humanoid ChilloutVR avatars.

The tool can be found under `Tools/Avatar Pointer Generator`.

- Currently will generate Head, Hand, and Feet colliders for humanoid avatars.
- Colliders are sized to match your avatar as best as possible.
- Support for Unity undo system. 
- There are no generic "Hand" or "Foot" colliders. Triggers can look for multiple types if needed.

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
