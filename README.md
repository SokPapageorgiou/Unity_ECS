# Summer Project - DOTS

Unity has been working in a high-performance multithreaded Data-Oriented Technology Stack (Dots). The graphics and the physics have their own threads, but everything related to MonoBehaviours happen in a single thread.

Object-Oriented Programming(OOP) is human readable, but not optimal for computers. This is no issue for modern machines and most of the programs, however video-games have to squeezy every single bit to have the best performance possible.

To have the best performance it is important to break the mind set and not think think about Objetcs, but Entities, Components and Systems (ECS).

- **Entity** is an archetype that holds a set of components
- **Componets** are data holders and are used to filter entity queries
- **System** contains the logic to process the entities. It uses C# Job System

Unity Dots builds up over the ECS, rebuilding the whole the core of the engine. 

**Goal**: My goal with this project is to learn how to set-up a project using Unity Dots package and start to exercise this new mindset of programming. I did split this project into two different scenes. In first one I am implementing a simple hybrid ECS, and in the second one I am testing the physics package.

