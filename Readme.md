# Physics System
This project will show some logics and information about the Physics in the videogames.

## Rigidbody vs. CharacterController
In Unity, Rigidbody and CharacterController are components, and they are used to move object in a 3D Environment, both of them are valid and used, but the work differently:
- Rigidbody uses unity's physics engine for realisti motion and collisions.
- CharacterController is designer for player characters, with precise and predictable control, but there is not physics simulation.

I Created 2 different scenes (RigidbodyExample and CharacterControllerExample) to understand the difference.

### Rigidbody
About the rigidbodyExample Scene, I created a simple sphere with a plane, I added a rigidbody component on the sphere, and with a simple script I added a movement behaviour. the gameplay shows:
- The object reacts to forces, gravity and collision automatically.
- Movement fells realistic, but less precise.
- Is good for physycs-based gameplay (rolling, pushing, falling, etc.)

### Character Controller
The second scene (CharacterControllerExample), I created a simple capsule with a plane, I added CharacterController component on the capsule, and with a simple script I added a movement behaviour. The gameplay shows:
- the movement is predictable and responsive.
- Gravity and jumping must be handled manually.
- The player doen't reach to physical forces(for example an explosion)
- This is good for First Person and Third Person.

### Conclusion
The rigidbody and CharacterController are really good for 3D videogames, but actually, they must be used correctly, The rigidbody is best for realistic Physics-based movement, it allow natural interaction between objects, but as you can see in the example, it offer less control, The CharacterController is best for player controlled characters, the choice is between realism and control.

## Discrete Collision Detection vs. Continuous Collision Detection
In unity, collision detection determines whether two colliders intersect or pass throught each other. we can have multiple type of collision:
- Discrete (it's the default one)
- Continuous
- Continuous Dynamic (Not consider in this section)
- Continuous Speculative (Not consider in this section)

### Discrete Collision Detection
To begin with, let's talk about Discrete Collision Detection. In this scene we create 3 different gameobjects (a basement plane, a wall cube and a sphere), this sphere will'have rigidbody with collision detection discrete. In a simple script we'll let this sphere move agains the wall. When the sphere collide against the wall, we'll see the detection. I choose to let public the speed, to let the user set the speed, if the user set an high speed, the sphere will pass through the wall and the detection will not be warned! This case is called "Tunneling".

The advantages are:
- Very efficient (Low CPU Cost).
- Works perfectly for slow or static objects.

The disadvantages are:
- As I said, it may miss collision for fast moving object (bullets for example)
- Not reliable for small or fast rigidbodies.

### Continuous Collision Detection
The continuous collision detection have a dedicated scene too. In that scene we create 3 different gameobjects (a basement plane, a wall cube and a sphere), this sphere will'have rigidbody with collision detection continuous. In a simple script we'll let this sphere move agains the wall. When the sphere collide against the wall, we'll see the detection. I choose to let public the speed, to let the user set the speed, in this case, even if the speed is high, the wall will be always block the sphere.

The advantages are:
- Works perfectly for fast-moving objects.
- The collision are never missed.

The disadvantages are:
- The performance will be worst
- Useless for static or slow moving objects.

### Conclusion
Both of detection are good, but they must be used correctly. I suggest to mix both modes.
Discrete Detection is efficient for most gameplay objects.
Continuous Detection should be used for fast motion to avoid tunneling.

## PhysX Logics
In this section we'll see how PhysX works, PhysX is based on NVIDIA PhysX, uses optimization and staibility features to make simulation accurate and efficient, we'll see the following key parameters:
- Sleeping
- Interpolation
- Solver Iteration Count

### Sleeping
Sleeping is a parameter of physX and literally stop a Rigidbody when it remains still foa a period of time. As you can see in the PhysXSleeping, we have a sphere that when is still, its rigidbody is sleeping(stop to being simulated), I Suggest to press the space button to make the sphere jump, and press multiple time to see that object is not sleeping, why this? Because saves CPU resources, and keep physics simulation stable(no micro Jitter), but be careful, a sleeping object can not react immediatly to a very small forces. As we used in the dedicated script, you can wake up the rigidbody with WakeUp() function.

### Interpolation
The interpolation works to make the movement more smooths, in the dedicate scene, we can see a little difference between two sphere, one with the interpolation active, and one without the interpolation, as you can see the movement is more smooth.

### Solver Iteration Count
The Solver Iteration Count resolve contacts, joints, and contraints between objects, it must be verified with a lot of object, make the game more stable stacking, and joint accuracy better. But use more the CPU.

### Conclusions
each of the parameter we saw previously is very useful, I suggest to remember the following things:
- Use sleeping for static or idle objects
- user Interpolation for all visible moving rigidbodies, to make they more realistic
- Increase Solver Iterations only when objects jitter, slider or penetrate each other


