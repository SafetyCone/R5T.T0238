# R5T.T0238
Catch-all for types.

Targets the latest .NET target framework to allow types to depend on *any* type in *any* library. (Since the latest framework can depend on libraries targeting all prior frameworks.)

This means the library dependencies (both project and package) of this library will be a snarled mess... but that's ok! This is the types library where that is allowed.

It also means types currently in this library might move in the future! The move might entail movement in one or both of:

* Project reference location
* Namespace location

That is the tradeoff of putting a type in this library: the future cost of moving the type is exchanged for the immediate benefit of just being able to slap a type into a commonly accessible location.


## Allowed Dependencies

All dependencies are allowed.


## How this library works

If you have an idea for a type, put it in the specific project you are working on.
If you have an idea for a type, and you want to site it in a library to make it commonly accessible, follow the waterfall in the "How To" file for siting types.
If you have an idea for a type, you want it somewhere commonly accessible, and following the waterfall in the "How To" file for siting types doesn't yield an answer, create a new library for the type, and make a new entry for it in the right place in the types waterfall.
But if you have an idea for a type, you want it somewhere commonly accessible, and you don't want to think through siting the type at *all* (either selecting the right library, creating a new library, or putting it one of the a target framework-specific catch-all type library, and it might be complicated with associated functionality)... THIS is the library for you!

Put differently, this library contains any type, that depends on any type, for any of its functionality, that has not been sited in any other library for any reason.


## Contents




## See Also

In reverse waterfall order:

=> R5T.T0238: This library is the bottom of the waterfall.
* R5T.T0237: The same catch-all for types, but those types limited to targeting netstandard2.1.
* R5T.T0221: Catch-all for types targeting netstandard2.1, but with associated functionality dependent on R5T.L0066.
* R5T.T0232: Catch-all for types targeting netstandard2.1, but with no associated functionality or with independent associated functionality (independent even of of R5T.L0066).
* R5T.T0236: IHasX/IWithX strictly-framework (netstandard2.1) with no associated functionality, catch-all.
