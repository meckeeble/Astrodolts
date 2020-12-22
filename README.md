# Astrodolts
This project has been through several iterations evolving from a now defunct repo to a game with as potential commercial release. Although that is quite some way off.

Local multiplayer in action:
https://vimeo.com/493678840

Demonstration and commentary:
https://vimeo.com/493743448

Notes on Hierarchy set up:
The player prefab consists of the visible player character and a camera which is currently positioned to minimise clipping.

The player has a rigid body, collider, and operates with the scripts:

-Player Look Original (named for when I had multiple scripts handling the camera in different ways. Other movement/camera scripts may be repurposed for a spectator view)

-Add Force Movement (this script is based on a very buggy script I found here https://wiki.unity3d.com/index.php/RigidbodyFPSWalker)

-Death (no working demonstration yet)

In front of the camera is an empty game object which handles the spawning of a grenade prefab.
