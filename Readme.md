# Physics System
This project will show some logics and information about the Physics in the videogames.

## Rigidbody vs. CharacterController
In Unity, Rigidbody and CharacterController are components, and they are used to move object in a 3D Environment, both of them are valid and used, but the work differently:
- Rigidbody uses unity's physics engine for realisti motion and collisions.
- CharacterController is designer for player characters, with precise and predictable control, but there is not physics simulation.

I Created 2 different scenes (RigidbodyExample and CharacterControllerExample) to understand the difference.

About the rigidbodyExample Scene, I created a simple sphere with a plane, I added a rigidbody component on the sphere, and with a simple script I added a movement behaviour. the gameplay shows:
- The object reacts to forces, gravity and collision automatically.
- Movement fells realistic, but less precise.
- Is good for physycs-based gameplay (rolling, pushing, falling, etc.)

The second scene (CharacterControllerExample), I created a simple capsule with a plane, I added CharacterController component on the capsule, and with a simple script I added a movement behaviour. The gameplay shows:
- the movement is predictable and responsive.
- Gravity and jumping must be handled manually.
- The player doen't reach to physical forces(for example an explosion)
- This is good for First Person and Third Person.

### Conclusion
The rigidbody and CharacterController are really good for 3D videogames, but actually, they must be used correctly, The rigidbody is best for realistic Physics-based movement, it allow natural interaction between objects, but as you can see in the example, it offer less control, The CharacterController is best for player controlled characters, the choice is between realism and control.

