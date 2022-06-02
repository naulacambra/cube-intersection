# cube-intersection
There are three main components, `CubeIntersection.UI.Console`, `CubeIntersection.Core`, `CubeIntersection.Application`.

`UI.Console` is the interface defined to allow the user enter data. The idea is any interface can be defined, and use `Core` and `Application` to compute collisions and intersections.

`Core` has the entities defined (such as `Cube`, the `Body` collider), the entities interfaces, and the exceptions required to inform the user any wrong data input.

`Application` has the `Collider` interface defined, with an implementation called `TwoBodyCollider` wich manages two bodies and can check their interactions. Another `NBodyCollider` can be defined to work with more than two bodies.

I\'ve used a "mini" layered architecture, since it seemed the more scalable and allowed me to easily separate the UI, the entities and the applications itself.

I\'ve thought about moving the `Collides` and `Intersection` algorithms out from `Cube` into `Collider` but in my head, I\'ve ended up thinking this as very initial state game engine, and it made sense to leave those algorithms there.